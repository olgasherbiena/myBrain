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
        public void Serialize(string filenameSerialize, Occiput occ, Temporal tmp, Forehead forh, Cerebellum cer, Crown cr) { } // функція для запису в файл
        public void Deserialize(string filenameDeserialize, Occiput occ, Temporal tmp, Forehead forh, Cerebellum cer, Crown cr) { } // функція для зчитування з файлу
    }
}