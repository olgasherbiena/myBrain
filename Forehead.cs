using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Forehead:Part, IPrint
    {
        public const int id = 120;
        public information inf_frh;
        public string forehead_part; // зберігається загальна інформація про лобову частину (та що одразу після заголовку)
        public Forehead()
        {
            //id=120;
            forehead_part = "frh_part";
            inf_frh.structure = "frh_struct";
            inf_frh.latin = "frh_lat";
            inf_frh.functions = "frh_func";
            inf_frh.clinical_significance = "frh_clinic";
        }
        public void Print(string str) { }
        public void Print_all_information() { }

        public override string ToString()
        {
            return $"{id}; Name: {this.forehead_part}; Latin: {this.inf_frh.latin}; Functions: {this.inf_frh.functions}";
        }
    }
}
