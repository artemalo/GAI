using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolice.Reference
{
    internal class Incidents//Характеристики происшествий
    {
        public int IncidentId { get; set; }//Связать с таблицей TrafficPolice.Incidents
        public string Description { get; set; }

        public Incidents() { }
        public static void Edit(Incidents incident)//редактирование таблицы характеристик происшествий(отредактировать описание)
        {
            Console.WriteLine("Описание происшествия:");
            Console.WriteLine($"\t{incident.Description}");
            Console.WriteLine("Введите новое описание:");
            incident.Description = Console.ReadLine();
            //...FileWorker
        }
    }
}
