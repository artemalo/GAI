using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TrafficPolice
{
	public abstract class FileHelper
	{
        #region Paths
        public static readonly string pAvailableNumbers = @"D:\GitHub\GAI\TrafficPolice\TrafficPolice\LicensePlates\СвободныеНомера.txt";
        public static readonly string pIssuedOrganization = @"D:\GitHub\GAI\TrafficPolice\TrafficPolice\LicensePlates\ВыданныеОрганизацией.txt";
        public static readonly string pIssuedOwners = @"D:\GitHub\GAI\TrafficPolice\TrafficPolice\LicensePlates\Владельцы.txt";

        public static readonly string pIncident = @"D:\GitHub\GAI\TrafficPolice\TrafficPolice\Происшествия.txt";

        public static readonly string pReferenceOrganization = @"D:\GitHub\GAI\TrafficPolice\TrafficPolice\Reference\Организации.txt";
        public static readonly string pReferenceIncident = @"D:\GitHub\GAI\TrafficPolice\TrafficPolice\Reference\Происшествия.txt";
        #endregion
        public static void ReadFileToList<T>(string path, List<T> list) where T : FileHelper, new()
        {
            if (File.Exists(path))
                using (StreamReader file = new StreamReader(path, Encoding.GetEncoding(1251)))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        
                        T newObj = new T();
                        if (newObj.TextToObject(parts))
                            list.Add(newObj);
                        else
                            Console.WriteLine($"Неправильные данные в строке:\n\t<{line}>, <{path}>");
                    }
                }
            else
                throw new Exception("Неверный файл " + path);
        }
        public static void WriteListToFile<T>(string path, bool append, List<T> items) where T : FileHelper
        {
            if (File.Exists(path))
            {
                //bool isNewLine = IsNewLine(path);
                using (StreamWriter file = new StreamWriter(path, append, Encoding.GetEncoding(1251)))
                {
                    /*if (!isNewLine && append)
                        file.WriteLine();*/
                    for (int i = 0; i < items.Count; ++i)
                        file.WriteLine(items[i].StringBuild().ToString());
                }
                if (append)
                    Console.WriteLine($"+ Список был добавлен в <{path}>");
                else
                    Console.WriteLine($"+ Список был перезаписан в <{path}>");
            }
            else
                throw new Exception("Не найден путь " + path);
        }

        protected abstract bool TextToObject(string[] parts);
        public abstract StringBuilder StringBuild();
    }
}