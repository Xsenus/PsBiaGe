using Core.Models;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Controllers
{
    public static class CompanyController
    {
        public async static Task<List<Company>> GetCompaniesAsync(Session session)
        {
            return await new XPQuery<Company>(session)?.ToListAsync();
        }

        public static Company Create(string url, int number, string nameCompany, DateTime? lastUpdateDate, string contactBox)
        {
            return new Company()
            {
                Number = number,
                Url = url,
                NameCompany = nameCompany,
                LastUpdateDate = lastUpdateDate,
                ContactBox = contactBox
            };
        }

        public static Company Create(Session session, string url, int number, string nameCompany, DateTime? lastUpdateDate, string contactBox)
        {
            return new Company(session)
            {
                Number = number,
                Url = url,
                NameCompany = nameCompany,
                LastUpdateDate = lastUpdateDate,
                ContactBox = contactBox
            };
        }

        public static Company Create(Session session, Company company)
        {
            return new Company(session)
            {
                Number = company.Number,
                Url = company.Url,
                NameCompany = company.NameCompany,
                LastUpdateDate = company.LastUpdateDate,
                ContactBox = company.ContactBox
            };
        }

        public async static Task<Company> GetAsync(Session session, string url, int number, string nameCompany, DateTime? lastUpdateDate, string contactBox)
        {
            return await new XPQuery<Company>(session)
                .FirstOrDefaultAsync(f => f.Url == url                
                    && f.Number == number
                    && f.NameCompany == nameCompany
                    && f.LastUpdateDate == lastUpdateDate
                    && f.ContactBox == contactBox);
        }

        public async static Task<Company> GetAsync(Session session, Company company)
        {
            return await new XPQuery<Company>(session).FirstOrDefaultAsync(f => f.Equals(company));
        }

        public async static Task<Company> GetAsync(Session session, Guid guid)
        {
            return await new XPQuery<Company>(session).FirstOrDefaultAsync(f => f.Guid == guid);
        }
    }
}
