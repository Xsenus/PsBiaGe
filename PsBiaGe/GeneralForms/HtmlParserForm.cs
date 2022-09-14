using Core.Controllers;
using Core.Models;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PulsLibrary.Extensions.DevForm;
using PulsLibrary.Extensions.DevXpo;
using PulsLibrary.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsChamp.GeneralForms
{
    public partial class HtmlParserForm : XtraForm
    {
        private string _url = "https://www.bia.ge/EN/Company/<NUMBER>?VisitCompanyType=3&ServiceId=54";
        private List<Company> _companies;
        private bool _isWrite => !checkIsWrite.Checked;        
        private UnitOfWork _uof = new UnitOfWork();
                
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
            AddTextToMemoEdit(text: "Начался процесс получение данных...", isClear: true);

            var i = 1;
            var number = Objects.GetIntObject(txtStartNumber.EditValue);
            if (number != 0)
            {
                i = number;
            }
            
            AddTextToMemoEdit(text: $"Парсинг начнется с {i} элемента");

            while (true)
            {
                if (await GetCompanies(i) is false)
                {
                    break;
                }

                UpdateEvent?.Invoke(true);
                i++;
            }            
            AddTextToMemoEdit(text: "Успешно завершен импорт");
            DevXtraMessageBox.ShowXtraMessageBox("Успешно завершен импорт");
        }

        private async Task<bool> GetCompanies(int number)
        {
            try
            {
                var url = _url.Replace("<NUMBER>", $"{number}");
                AddTextToMemoEdit(text: $"Получение страницы по ссылке: {url}");
                var htmlDocument = await HtmlParserController.GetHtmlDocumentAsync(url);

                AddTextToMemoEdit(text: $"Получение наименования компании", isWrite: _isWrite);
                var companyName = HtmlParserController.GetHtmlNode(htmlDocument, "//div[@id='CompanyNameBox']")?.InnerText;
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    return true;
                }
                
                AddTextToMemoEdit(text: $"Получение последней даты обновления", isWrite: _isWrite);
                var lastUpdateDate = HtmlParserController.GetHtmlNode(htmlDocument, "//div[@id='LastUpdateDate']/span")?.InnerText;

                AddTextToMemoEdit(text: $"Получение адреса", isWrite: _isWrite);
                var contactBox = HtmlParserController.GetHtmlNode(htmlDocument, "//table/tbody/tr[4]/td[2]/span[2]")?.InnerText;

                AddTextToMemoEdit(text: $"CompanyFillingStars", isWrite: _isWrite);
                var companyFillingStars = HtmlParserController.GetHtmlNode(htmlDocument, "//div[@id='CompanyFillingStars']")
                    ?.Attributes
                    ?.FirstOrDefault(f => f.Name != null && f.Name.Equals("data-title"))
                    ?.Value;

                using (var uof = new UnitOfWork())
                {
                    var _lastUpdateDate = default(DateTime?);
                    if (DateTime.TryParse(lastUpdateDate, out DateTime result))
                    {
                        _lastUpdateDate = result;
                    }
                    
                    var _сompany = CompanyController.Create(url, number, companyName, _lastUpdateDate, contactBox);
                    if (_сompany != null)
                    {
                        AddTextToMemoEdit(text: $"Сформирована новая компания: {_сompany}", isWrite: _isWrite);
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
                    else
                    {
                        currentCompany.LastUpdateDate = _lastUpdateDate;
                        currentCompany.ContactBox = contactBox;
                        currentCompany.Save();
                    }

                    currentCompany.SetCompanyFillingStars(companyFillingStars);

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
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}