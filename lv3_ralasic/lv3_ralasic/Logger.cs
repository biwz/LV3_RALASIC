using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv3_ralasic
{
    class Logger
    {
        private static Logger instance;
        private string filePath;

        Logger()
        {
            this.filePath = "DefaultLoggerFile.txt";
        }

        public void setFilePath(string path)
        {
            this.filePath = path;
        }

        public static Logger GetInstance()
        {
            {
                if (instance == null)
                {
                    instance = new Logger();

                }
            }
            return instance;
        }

        public void Log(string text)
        {
            using (System.IO.StreamWriter streamWriter = System.IO.File.CreateText(this.filePath))
            {
                streamWriter.WriteLine(text);

            }
        }



    }
}
