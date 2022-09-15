using Core.Controllers;
using Core.Models;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using PulsLibrary.Extensions.DevForm;
using PulsLibrary.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PsBiaGe.GeneralForms
{
    public partial class HtmlParserForm : XtraForm
    {
        private string _url = "https://www.bia.ge/<LANGUAGE>/Company/<NUMBER>?VisitCompanyType=3&ServiceId=54";
        private List<Company> _companies;
        private UnitOfWork _uof = new UnitOfWork();
        private CancellationTokenSource _cancellationTokenSource;
        private CancellationToken _token;

        private bool IsWrite => !checkIsWrite.Checked;
        private string Language => cmbLanguage.Text;        
        private int CountTask
        {
            get
            {
                if (int.TryParse(txtCountTask.Text, out int result))
                {
                    return result;
                }
                
                return 1;
            }
        }
                
        public delegate void UpdateEventHandler(bool isUpdate);
        public event UpdateEventHandler UpdateEvent;

        public HtmlParserForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
        }

        private async void HtmlParserForm_Load(object sender, EventArgs e)
        {            
            _companies = await CompanyController.GetCompaniesAsync(_uof);
        }

        private void AddTextToMemoEdit(string text, bool isWrite = true, bool isClear = false)
        {
            if (isWrite is false)
            {
                return;
            }
            
            if (!IsHandleCreated)
            {
                return;
            }

            if (isClear)
            {
                memoParserInfo.EditValue = null;
            }

            Invoke((Action)delegate
            {
                memoParserInfo.MaskBox.AppendText($"[{DateTime.Now}] => {text}{Environment.NewLine}");
                memoParserInfo.SelectionStart = Int32.MaxValue;
                memoParserInfo.ScrollToCaret();
            });
        }
        
        private async void btnGet_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _token = _cancellationTokenSource.Token;

            AddTextToMemoEdit(text: "Начался процесс получение данных...", isClear: true);

            var i = 1;
            var number = Objects.GetIntObject(txtStartNumber.EditValue);
            if (number != 0)
            {
                i = number;
            }
            
            AddTextToMemoEdit(text: $"Парсинг начнется с {i} элемента");

            var count = 0;
            var taskList = new List<Task>();
            while (true)
            {
                try
                {
                    if (_cancellationTokenSource.IsCancellationRequested)
                    {
                        break;
                    }
                    
                    taskList.Add(GetCompanies(i));
                    count++;

                    if (count >= CountTask)
                    {
                        await Task.WhenAll(taskList);
                        count = 0;
                        taskList?.Clear();
                        UpdateEvent?.Invoke(true);
                    }
                    i++;
                }
                catch (Exception ex)
                {
                    AddTextToMemoEdit(text: ex.ToString());
                    return;
                }
            }
            
            AddTextToMemoEdit(text: "Успешно завершен импорт");
            DevXtraMessageBox.ShowXtraMessageBox("Успешно завершен импорт");
        }

        private async Task<bool> GetCompanies(int number)
        {
            try
            {
                var url = _url.Replace("<LANGUAGE>", Language).Replace("<NUMBER>", $"{number}");
                AddTextToMemoEdit(text: $"Получение страницы по ссылке: {url}");
                var htmlDocument = await HtmlParserController.GetHtmlDocumentAsync(url);

                AddTextToMemoEdit(text: $"Получение наименования компании", isWrite: IsWrite);
                var companyName = HtmlParserController.GetHtmlNode(htmlDocument, "//div[@id='CompanyNameBox']")?.InnerText?.Trim();
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    return true;
                }
                
                AddTextToMemoEdit(text: $"Получение последней даты обновления...", isWrite: IsWrite);
                var lastUpdateDate = HtmlParserController.GetHtmlNode(htmlDocument, "//div[@id='LastUpdateDate']/span")?.InnerText?.Trim();

                AddTextToMemoEdit(text: $"Получение адреса...", isWrite: IsWrite);
                var contactBox = HtmlParserController.GetHtmlNode(htmlDocument, "//*[@id='ContactsBox']/table/tbody/tr[1]/td[2]/span")?.InnerText?.Trim();

                AddTextToMemoEdit(text: $"Получение рейтинга...", isWrite: IsWrite);
                var companyFillingStars = HtmlParserController.GetHtmlNode(htmlDocument, "//div[@id='CompanyFillingStars']")
                    ?.Attributes
                    ?.FirstOrDefault(f => f.Name != null && f.Name.Equals("data-title"))
                    ?.Value;

                AddTextToMemoEdit(text: $"Получение телефона...", isWrite: IsWrite);
                var phone = HtmlParserController.GetHtmlNode(htmlDocument, "//*[@id='ContactsBox']/table/tbody/tr[2]/td[2]")?.InnerText?.Trim()?.Replace("\r\n,\t\t\t\t\t\t\t\t\t\t", "; ");

                AddTextToMemoEdit(text: $"Получение брендов...", isWrite: IsWrite);
                var brands = HtmlParserController.GetHtmlNode(htmlDocument, "//*[@id='tpAboutCompany']/table/tbody/tr[1]/td[2]/span[2]")?.InnerText?.Trim();
                
                var legalForm = HtmlParserController.GetHtmlNode(htmlDocument, "//table/tbody/tr[2]/td[1]/span[2]")?.InnerText?.Trim();
                var vatNumber = HtmlParserController.GetHtmlNode(htmlDocument, "//table/tbody/tr[2]/td[2]/span[2]")?.InnerText?.Trim();
                var registrationNumber = HtmlParserController.GetHtmlNode(htmlDocument, "//table/tbody/tr[3]/td[1]/span[2]")?.InnerText?.Trim();
                var registrationDate = HtmlParserController.GetHtmlNode(htmlDocument, "//table/tbody/tr[3]/td[2]/span[2]")?.InnerText?.Trim();
                var registrationAuthority = HtmlParserController.GetHtmlNode(htmlDocument, "//table/tbody/tr[4]/td[1]/span[2]")?.InnerText?.Trim();
                var legalAddress = HtmlParserController.GetHtmlNode(htmlDocument, "//table/tbody/tr[4]/td[2]/span[2]")?.InnerText?.Trim();
                var status = HtmlParserController.GetHtmlNode(htmlDocument, "//table/tbody/tr[5]/td[1]/span[2]")?.InnerText?.Trim();
                var workingHours = HtmlParserController.GetHtmlNode(htmlDocument, "//table/tbody/tr[5]/td[2]/ul")?.InnerText?.Trim()?.Replace("\r\n\t\t\t\t\t", "; ");
                var products = HtmlParserController.GetHtmlNode(htmlDocument, "//ul/li[2]/ul")?.InnerText?.Trim()?.Replace("\r\n\t\t\t\t\t", "; ");
                var serviceCategories = HtmlParserController.GetHtmlNode(htmlDocument, "//ul/li[4]/ul")?.InnerText?.Trim()?.Replace("\r\n\t\t\t\t\t\t", "; ");
                var businessActivity = HtmlParserController.GetHtmlNode(htmlDocument, "//*[@id='ServicesListBox']/ul")?.InnerText?.Trim()?.Replace("\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t", "; ");
                var naceClassification2004 = HtmlParserController.GetHtmlNode(htmlDocument, "//ul/li[8]/ul")?.InnerText?.Trim()?.Replace("\r\n\t\t\t\t\t", "; ");
                var naceClassification2016 = HtmlParserController.GetHtmlNode(htmlDocument, "///ul/li[10]/ul")?.InnerText?.Trim()?.Replace("\r\n\t\t\t\t\t", "; ");

                using (var uof = new UnitOfWork())
                {
                    var _lastUpdateDate = default(DateTime?);
                    if (DateTime.TryParse(lastUpdateDate, out DateTime resultLastUpdateDate))
                    {
                        _lastUpdateDate = resultLastUpdateDate;
                    }

                    var _registrationDate = default(DateTime?);
                    if (DateTime.TryParse(lastUpdateDate, out DateTime resultRegistrationDate))
                    {
                        _registrationDate = resultRegistrationDate;
                    }

                    var _сompany = CompanyController.Create(url, number, companyName);
                    if (_сompany != null)
                    {
                        AddTextToMemoEdit(text: $"Сформирована новая компания: {_сompany}", isWrite: IsWrite);
                    }

                    var currentCompany = _companies.FirstOrDefault(f => f != null && f.Equals(_сompany));
                    if (currentCompany is null)
                    {
                        var company = CompanyController.Create(uof, _сompany);
                        company.Save();

                        _companies.Add(company);
                        currentCompany = company;
                        AddTextToMemoEdit(text: $"Добавлена новая запись в базу данных: {company}");
                    }
               
                    currentCompany.SetCompanyFillingStars(companyFillingStars);
                    currentCompany.LastUpdateDate = _lastUpdateDate;
                    currentCompany.ContactBox = contactBox;
                    currentCompany.Address = contactBox;
                    currentCompany.Phone = phone;
                    currentCompany.Brands = brands;

                    currentCompany.LegalForm = legalForm;
                    currentCompany.VatNumber = vatNumber;
                    currentCompany.RegistrationNumber = registrationNumber;
                    currentCompany.RegistrationDate = _registrationDate;
                    currentCompany.RegistrationAuthority = registrationAuthority;
                    currentCompany.LegalAddress = legalAddress;
                    currentCompany.Status = status;
                    currentCompany.WorkingHours = workingHours;
                    currentCompany.Products = products;
                    currentCompany.ServiceCategories = serviceCategories;
                    currentCompany.BusinessActivity = businessActivity;
                    currentCompany.NaceClassification2004 = naceClassification2004;
                    currentCompany.NaceClassification2016 = naceClassification2016;

                    await uof.CommitChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }
    }
}