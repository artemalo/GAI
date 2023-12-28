using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolice
{
    internal class Incidents//Происшествия
    {
        public int IncidentId { get; set; }//Уникольный номер происшествия
        public DateTime Date { get; set; }//дата
        public string IncidentType { get; set; }//тип происшествия
        public string Location { get; set; }//место происшествия
        public string CarMake { get; set; }//марка автомобиля
        public string Series { get; set; }//серия
        public string Number { get; set; }//номер
        public string VehicleType { get; set; }//тип машины
        public string Summary { get; set; }//краткое содержание
        public int CountCasualties { get; set; }//число пострадавших
        public decimal DamageAmount { get; set; }//сумма ущерба
        public string MovementType { get; set; }//характеристика по способу движения
        public string LocationType { get; set; }//характеристика по месту совершения
        public string IncidentCause { get; set; }//причина происшествия
        public string RoadConditions { get; set; }//дорожные условия
        public string IncidentCategory { get; set; }//вид происшествия
        public string District { get; set; }//район
        public int DrivingExperience { get; set; }//стаж эксплуатации
        public TimeSpan DrivingDuration { get; set; }//продолжительность работы за рулем
    }
}
