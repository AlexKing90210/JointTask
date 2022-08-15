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

        public Reader(IParser Parser, IValidator Validator)
        {
            parser = Parser;
            validator = Validator;  
        }

        IEnumerable<User> IReader.Read(string path)
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
                foreach (string s in readText)
                {
                    Users.Append(s);
                }

                foreach (var item in Users)
                {
                    if (validator(item))
                    {
                        parser(item);
                    }

                }
            }
            return Users;

        }

        
    }
}

