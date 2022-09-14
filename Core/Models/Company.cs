using DevExpress.Xpo;
using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class Company : Base, IEquatable<Company>
    {
        public Company() { }
        public Company(Session session) : base(session) { }

        public int? Number { get; set; }
        public string Url { get; set; }
        public string NameCompany { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CompanyFillingStarsString
        {
            get
            {
                if (CompanyFillingStars != null)
                {
                    return $"{CompanyFillingStars}%"?.Replace(",", ".");
                }

                return default;
            }
        }        
        public decimal? CompanyFillingStars { get; set; }
        public string ContactBox { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Brands { get; set; }
        public string LegalForm { get; set; }
        public string VatNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string RegistrationAuthority { get; set; }
        public string LegalAddress { get; set; }
        public string Status { get; set; }
        [Size(2046)]
        public string WorkingHours { get; set; }
        [Size(2046)]
        public string Products { get; set; }
        [Size(2046)]
        public string ServiceCategories { get; set; }
        [Size(2046)]
        public string BusinessActivity { get; set; }
        [Size(2046)]
        public string NaceClassification2004 { get; set; }        
        [Size(2046)]
        public string NaceClassification2016 { get; set; }
        
        public override string ToString()
        {
            var result = default(string);
            if (Number != null)
            {
                result += $"[{Number}] ";
            }
            result += $"{NameCompany}";
            return result;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Company);
        }

        public bool Equals(Company other)
        {
            return other != null &&
                   Number == other.Number &&
                   Url == other.Url &&
                   NameCompany == other.NameCompany;
        }

        public override int GetHashCode()
        {
            int hashCode = -50344703;
            hashCode = hashCode * -1521134295 + Number.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Url);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NameCompany);
            return hashCode;
        }

        public void SetCompanyFillingStars(string companyFillingStars)
        {
            if (decimal.TryParse(companyFillingStars?.Replace("%", "")?.Replace(".", ","), out decimal result))
            {
                CompanyFillingStars = result;
            }
        }

        public static bool operator ==(Company left, Company right)
        {
            return EqualityComparer<Company>.Default.Equals(left, right);
        }

        public static bool operator !=(Company left, Company right)
        {
            return !(left == right);
        }
    }
}
