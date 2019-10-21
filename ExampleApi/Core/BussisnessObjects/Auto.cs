using Core.BussisnessObjects.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BussisnessObjects
{
    public class Auto : MyXPObject
    {
        private string _plateNumber, _make, _model;

        public string PlateNumber 
        { 
            get => _plateNumber;
            set => SetPropertyValue("PlateNumber", ref _plateNumber, value);
        }
        public string Make 
        {
            get => _make;
            set => SetPropertyValue("Make", ref _make, value);
        }
        public string Model 
        {
            get => _model;
            set => SetPropertyValue("Model", ref _model, value);
        }

        public Auto(Session session) : base(session)
        {
        }

       
    }
}
