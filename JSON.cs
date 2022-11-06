using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Brain
{
    public class JSON
    {
        public string filenameSerialize;
        public string filenameDeserialize;
        public JSON(string Serialize, string Deserialize)
        {
            filenameSerialize = Serialize;
            filenameDeserialize = Deserialize;
        }
        public void Serialize(string filenameSerialize, Brain.parts[] brain) { } // функція для запису в файл
        public void Deserialize(string filenameDeserialize, Brain.parts[] brain) { } // функція для зчитування з файлу
    }
}
