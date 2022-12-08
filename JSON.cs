using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class JSON
    {
        string filenameSerialize;
        string filenameDeserialize;
        public JSON(string Serialize, string Deserialize)
        {
            filenameSerialize = Serialize;
            filenameDeserialize = Deserialize;
        }
        public void Serialize(string filenameSerialize, Brain brain) { } // функція для запису в файл
        public void Deserialize(string filenameDeserialize, Brain brain) { } // функція для зчитування з файлу
    }
}
