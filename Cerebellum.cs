using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Cerebellum:Part, IPrint
    {
        public int id;
        public information inf_crb;
        public string cerebellum; // зберігається загальна інформація про мозечок (та що одразу після заголовку)
        public Cerebellum()
        {
            id=101;
            cerebellum = "";
            inf_crb.structure = "";
            inf_crb.latin = "";
            inf_crb.functions = "";
            inf_crb.clinical_significance = "";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
