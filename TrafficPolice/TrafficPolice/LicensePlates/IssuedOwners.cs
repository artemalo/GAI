using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolice.LicensePlates
{
    //Номера, выданные частным владельцам
    //:серия, номер, ФИО, район, адрес, марка автомобиля, дата выпуска автомобиля и т.д.
    internal class IssuedOwners
    {
        private string _serial;
        private string _number;
        private string _fullName;
        private string _district;
        private string _address;
        private string _carMake;
        private DateTime _releaseCar;
    }
}
