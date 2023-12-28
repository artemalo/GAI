using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolice.LicensePlates
{
    //Свободные номера
    //:серия, диапазон номеров
    internal class AvailableNumbers
    {
        private string _serial;
        private string[] _rangeNumber;

        public static short LengthSerial { get => 3; }
        public static short LengthNumber { get => 3; }

        AvailableNumbers() {}
        AvailableNumbers(string serial, string[] rangeNumber)
        {
            if (serial.Length == LengthNumber)
            {
                _serial = serial;
                _rangeNumber = rangeNumber;
            }
            else
                Console.WriteLine($"Данные [{serial}, {rangeNumber[0]}...] для свободных номеров не записаны");
        }
    }
}
