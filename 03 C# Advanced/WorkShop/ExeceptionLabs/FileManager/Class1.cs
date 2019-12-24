using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class FileManager
    {
        public void Process()
        {
            var fileinfo = new FileInfo(@"c:\Temp\folder\path.txt");
            var fileStream = fileinfo.Open(FileMode.Open);
            var steamReader = new StreamReader(fileStream);
            try
            {
                while (!steamReader.EndOfStream)
                {
                    Console.WriteLine(steamReader.ReadLine());
                }
                throw new Exception("error");
            }
            catch (Exception e)
            {
                //throw;
                //throw e;
                throw new Exception("error",e);
            }
            finally
            {
                fileStream.Dispose();
                steamReader.Dispose();
            }
        }
    }
}
