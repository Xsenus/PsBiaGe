using DevExpress.Xpo;
using System;

namespace Core.Models
{
    public class Base : XPObject
    {
        public Base() : base() { }
        public Base(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Guid = Guid.NewGuid();
        }

        [Persistent]
        public Guid Guid { get; private set; }
    }
}