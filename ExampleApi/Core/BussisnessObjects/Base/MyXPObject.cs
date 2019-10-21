using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BussisnessObjects.Base
{
    public class MyXPObject : XPCustomObject
    {
        public MyXPObject(Session session) : base(session) { }

        private Guid _fOid;
        [Key(AutoGenerate = true)]
        public Guid Oid
        {
            get { return _fOid; }
            set { SetPropertyValue<Guid>("Oid", ref _fOid, value); }
        }
    }
}
