using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    interface IPrint // інтерфейс, реалізацію якого пропишемо у класах
    {
        void Print(string str);
        void Print_all_information();
    }
    public abstract class Part
    {
       public string structure;
       public string latin;
       public string functions;
       public string clinical_significance;
    }
    public class Brain : Part
    {
        private Crown cr;
        private Cerebellum cer;
        private Forehead fr;
        private Occiput occ;
        private Temporal tmp;
        private List<Part> brains;
        public Brain()
        {
            cer = new Cerebellum();
            cr = new Crown();
            fr = new Forehead();
            occ = new Occiput();
            tmp = new Temporal();
            brains = new List<Part>();
            {
                brains.Add(cer);
                brains.Add(cr);
                brains.Add(fr);
                brains.Add(occ);
                brains.Add(tmp);
            }
        }
        public List<Part> Brains { set { } get { return brains; } }
        public Crown Cr { set { } get { return cr; } }
        public Cerebellum Cer { set { } get { return cer; } }
        public Forehead Fr { set { } get { return fr; } }
        public Occiput Occ { set { } get { return occ; } }
        public Temporal Tmp { set { } get { return tmp; } }
    public override string ToString()
        {
            return string.Format("This is brain {0}", brains.ToString());
        }
    }
}
