using System;
using System.IO;

namespace Myclass
{
    public class FileProcess
    {
        public bool FileExists(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new
                    ArgumentException("fileName");
                
            }
            return File.Exists(filename);
        }
    }
}
