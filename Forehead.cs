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
        private string forehead_name; // зберігається загальна інформація про лобову частину (та що одразу після заголовку)
        public Forehead()
        {
            forehead_name = "frh_part";
            structure = "frh_struct";
            latin = "frh_lat";
            functions = "frh_func";
            clinical_significance = "frh_clinic";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
        public string Forehead_name { set { forehead_name = value; } get { return forehead_name; } }
        public override string ToString()
        {
            return $"{id}; Name: {this.forehead_name}; Latin: {this.latin}; Functions: {this.functions}";
        }
    }
}
