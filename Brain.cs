using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public struct information // загальна структура даних
    {
        public string structure;
        public string latin;
        public string functions;
        public string clinical_significance;
    }
    interface IPrint // інтерфейс, реалізацію якого пропишемо у класах
    {
        void Print(string str);
        void Print_all_information();
    }
    public class Brain
    {
        public struct parts // структура частин мозку (об'єктів їх класів)
        {
            public Crown cr;
            public Cerebellum cer;
            public Forehead fr;
            public Occiput occ;
            public Temporal tmp;
        }
        public parts[] brain; // масив структури для впорядкування даних
        public Brain()
        {
        
        }
    }
}
