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
        IEnumerable<User> Read(string path)
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
            }
            return Users;

        }

        static void Reader(IParser parser, IValidation validator)
        {
            IEnumerable<User> Users = Read(string path);
            foreach (var item in Users)
            {
                if (validator(item))
                {
                    parser(item);
                }

            }

        }
    }
}

