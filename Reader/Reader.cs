using Core;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IOUtilities
{
    public class Reader : IReader
    {
        public IParser parser;
        public IValidator validator;

        public Reader(IParser _parser, IValidator _validator)
        {
            parser = _parser;
            validator = _validator;  
        }

        public static IEnumerable<User> IReader.Read(string path)
        {
            IEnumerable<User> Users;
            // Блок нужен для того, чтобы код не падал, если вдруг такого файла найти не удалось
            if (!File.Exists(path))
            {
                // Вывод сообщения об ошибке
                string createText = "Произошла ошибка! " + "Проверьте входной файл.";
            }
            else
            {
                // Построчное считывание файла
                string[] readText = File.ReadAllLines(path);
                foreach(string s in readText)
                {
                    //Считывание и обработка файла
                    // Не знаю как сделать
                }    
                /*{
                    if (IValidator.Parse(s)
                    {
                        yield return IParser.Parse(s);
                    }
                };*/

            }
        }

        
    }
}

