using DevExpress.Xpo;

namespace Core.Models
{
    public class BaseDictionary : Base
    {
        public BaseDictionary() { }
        public BaseDictionary(Session session) : base(session) { }

        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
