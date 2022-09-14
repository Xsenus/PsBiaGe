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
