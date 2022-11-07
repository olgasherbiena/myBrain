using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Forehead:IPrint
    {
        public int id;
        public information frh_inf;
        public string forehead_part; // зберігається загальна інформація про лобову частину (та що одразу після заголовку)
        public Forehead()
        {
            id=120;
            forehead_part = "";
            frh_inf.structure = "";
            frh_inf.latin = "";
            frh_inf.functions = "";
            frh_inf.clinical_significance = "";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
