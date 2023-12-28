using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolice.Reference
{
    internal class Organization
    {
        public string Name { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Director { get; set; }

        public Organization() { }
        public static void Edit(Organization organization)//редактирование таблицы организаций
        {
            Console.WriteLine("Что отредактировать?");
            Console.WriteLine("\tНазвание: " + organization.Name);
            Console.WriteLine("\tРайон: " + organization.District);
            Console.WriteLine("\tАдрес: " + organization.Address);
            Console.WriteLine("\tРуководитель" + organization.Director);
            Console.WriteLine("\tничего");

            bool flag = Switch(Console.ReadLine(), organization);
            while (!flag)//Если введены неверные данные
            {
                flag = Switch(Console.ReadLine(), organization);
            }
            //...FileWorker
        }
        private static bool Switch(string answer, Organization organization)
        {
            bool flag = true;
            answer.ToLower();
            string operation;
            switch (answer)
            {
                case "назвние":
                    Console.WriteLine("Введите новое название: ");
                    operation = Console.ReadLine();
                    organization.Name = operation;
                    break;
                case "адрес":
                    Console.WriteLine("Введите новый район: ");
                    operation = Console.ReadLine();
                    organization.District = operation;
                    break;
                case "район":
                    Console.WriteLine("Введите новый район: ");
                    operation = Console.ReadLine();
                    organization.District = operation;
                    break;
                case "руководитель":
                    Console.WriteLine("Введите новый район: ");
                    operation = Console.ReadLine();
                    organization.District = operation;
                    break;
                case "ничего":
                    flag = true;
                    break;
                default:
                    flag = false;
                    break;
            }
            return flag;
        }
    }
}
