using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Cerebellum:Part, IPrint
    {
        public const int id = 101;
        public string cerebellum_name; // зберігається загальна інформація про мозечок (та що одразу після заголовку)
        public Cerebellum()
        {
            //id=101;
            cerebellum_name = "crb_part";
            structure = "crb_struct";
            latin = "crb_lat";
            functions = "crb_func";
            clinical_significance = "crb_clinic";
        }
        public void Print(string str) { }
        public void Print_all_information() { }

        public override string ToString()
        {
            return $"{id}; Name: {this.cerebellum_name}; Latin: {this.latin}; Functions: {this.functions}";
        }
    }
}
