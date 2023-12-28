using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolice.Reference
{
    internal class Organization : FileHelper//Таблица организаций
    {
        private uint _id;
        private string _name;
        private string _district;
        private string _adress;
        private string _director;
        public uint Id { get => _id; set => _id = value; }//Номер организации для себя
        public string Name { get => _name; set => _name = value; }
        public string District { get => _district; set => _district = value; }
        public string Address { get => _adress; set => _adress = value; }
        public string Director { get => _director; set => _director = value; }

        public Organization() {}
        public Organization(uint id, string name, string district, string adress, string director)
        {
            Id = id;
            Name = name;
            District = district;
            Address = adress;
            Director = director;
        }

        public static void Edit()//редактирование таблицы организаций
        {
            List<Organization> fileList = new List<Organization>();
            ReadFileToList(pReferenceOrganization, fileList);
            Console.Write("Введите номер организации: ");
            uint id = uint.Parse(Console.ReadLine());
            bool success = false;
            foreach (Organization org in fileList)//поиск по номеру
            {
                if (id == org.Id)
                {
                    Console.WriteLine("Что отредактировать? Введите слово после знака <+>");
                    Console.WriteLine("\t+Название : " + org.Name);
                    Console.WriteLine("\t+Район : " + org.District);
                    Console.WriteLine("\t+Адрес : " + org.Address);
                    Console.WriteLine("\t+Руководитель : " + org.Director);
                    Console.WriteLine("\t+Ничего");

                    bool flag = Switch(Console.ReadLine(), org);
                    while (!flag)//Если введены неверные данные
                    {
                        Console.Write("Неверное слово, попробуйте снова: ");
                        flag = Switch(Console.ReadLine(), org);
                    }
                    //Console.WriteLine("Не найден номер организации...");
                    success = true;
                    break;
                }
            }
            if (success)
                WriteListToFile(pReferenceOrganization, false, fileList);
            else
                Console.WriteLine("Редактирование таблицы организаций - Что-то пошло не так. Возможно файл пуст.");
        }
        private static bool Switch(string answer, Organization org)
        {
            bool flag = true;
            answer.ToLower();
            string operation;
            switch (answer)
            {
                case "название":
                    Console.Write("Введите новое название: ");
                    operation = Console.ReadLine();
                    org.Name = operation;
                    break;
                case "адрес":
                    Console.Write("Введите новый район: ");
                    operation = Console.ReadLine();
                    org.District = operation;
                    break;
                case "район":
                    Console.Write("Введите новый район: ");
                    operation = Console.ReadLine();
                    org.District = operation;
                    break;
                case "руководитель":
                    Console.Write("Введите новый район: ");
                    operation = Console.ReadLine();
                    org.District = operation;
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

        protected override bool TextToObject(string[] parts)
        {
            if (parts.Length == 5 && uint.TryParse(parts[0], out _id))//Количество нужных полей экземпляра класса
            {
                _name = parts[1];
                _district = parts[2];
                _adress = parts[3];
                _director = parts[4];
                return true;
            }
            return false;
        }

        public override StringBuilder StringBuild()
        {
            return new StringBuilder().
                Append(Id).Append(' ').
                Append(Name).Append(' ').
                Append(District).Append(' ').
                Append(Address).Append(' ').
                Append(Director);
        }
    }
}
