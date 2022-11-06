using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Brain
{
    public class XML
    {
        public string filenameLoad;
        public string filenameUpload;
        public XML(string Load, string Upload)
        {
            filenameLoad = Load;
            filenameUpload = Upload;
        }
        public void ForLoad(string filenameLoad, Brain.parts[] brain) { } // функція для запису в файл
        public void ForUpload(string filenameUpload, Brain.parts[] brain) { } // функція для зчитування з файлу 
    }
}
