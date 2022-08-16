using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReader
{
    public class FileExistException : Exception
    {
        public FileExistException(string filePath) : base($"file with path: {filePath} already exist")
        { }
    }
}