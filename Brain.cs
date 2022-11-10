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
            public override string ToString()
            {
                return cr + " " + cer + " " + fr + " " + occ + " " + tmp ;
            }
        }
        public parts brain; // масив структури для впорядкування даних
        public List<parts> brains;
        public Brain()
        {

            //this.brain.cr.crown_part = "";
            this.brain.cr = new Crown();
            this.brain.cer = new Cerebellum();
            this.brain.fr = new Forehead();
            this.brain.occ = new Occiput();
            this.brain.tmp = new Temporal();
            brains = new List<parts>();
            brains.Add(brain);

        }
        public override string ToString()
        {
            return string.Format("This is brain {0}", brain.ToString());
        }
    }
}
