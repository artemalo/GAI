using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolice.LicensePlates
{
    //Номера, выданные в организации
    //:код организации, серия, диапазон номеров
    internal class IssuedOrganization
    {
        private int _id;
        private string _serial;
        private string[] _range;
    }
}
