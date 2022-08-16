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

        public FileInfo File { get; set; }


        public Reader(IParser _parser, IValidator _validator)
        {
            parser = _parser;
            validator = _validator;  
        }

        public IEnumerable<User> Read(string path)
        {
            File = new FileInfo(path);
            string[] readText;

            if (File.Exists)
            {
                throw new FileExistException(File.FullName);
            }
            try
            {
                // Построчное считывание файла

                using (StreamReader sr = File.OpenText())
                {
                    while (!sr.EndOfStream)
                    {
                        readText.Add(sr.ReadLine());
                    }

                }

                foreach(string s in readText)
                {
                    // Считывание и обработка файла
                    // Не знаю как сделать 
                    // Примерный вариант реализации
                   
                    if(validator.IsValid(s))
                    {
                        yield return parser.Parse(s);
                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}