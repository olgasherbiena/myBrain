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
        public information inf_crb;
        public string cerebellum; // зберігається загальна інформація про мозечок (та що одразу після заголовку)
        public Cerebellum()
        {
            //id=101;
            cerebellum = "crb_part";
            inf_crb.structure = "crb_struct";
            inf_crb.latin = "crb_lat";
            inf_crb.functions = "crb_func";
            inf_crb.clinical_significance = "crb_clinic";
        }
        public void Print(string str) { }
        public void Print_all_information() { }

        public override string ToString()
        {
            return $"{id}; Name: {this.cerebellum}; Latin: {this.inf_crb.latin}; Functions: {this.inf_crb.functions}";
        }
    }
}
