using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolice.Reference
{
    internal class Incident
    {
        public int IncidentId { get; set; }//Связать с таблицей TrafficPolice.Incident
        public string Description { get; set; }

        public Incident() { }
        public static void Edit(Incident incident)//редактирование таблицы характеристик происшествий(отредактировать описание)
        {
            Console.WriteLine("Описание происшествия:");
            Console.WriteLine($"\t{incident.Description}");
            Console.WriteLine("Введите новое описание:");
            incident.Description = Console.ReadLine();
            //...FileWorker
        }
    }
}
