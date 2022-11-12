using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Occiput:Part, IPrint
    {
        public const int id = 102;
        public information inf_occ;
        public string occiput; // зберігається загальна інформація про потиличну частину (та що одразу після заголовку)
        public string first_functional_area;
        public string ventral_flow;
        public string dorsomedial_flow;
        public Occiput()
        {
            //id=102;
            occiput = "occ_part";
            inf_occ.structure = "occ_struct";
            inf_occ.latin = "occ_lat";
            inf_occ.functions = "occ_func";
            first_functional_area = "occ_1";
            ventral_flow = "occ_2";
            dorsomedial_flow = "occ_3";
            inf_occ.clinical_significance = "occ_4";

        }
        public void Print(string str) { }
        public void Print_all_information() { }

        public override string ToString()
        {
            return $"{id}; Name: {this.occiput}; Latin: {this.inf_occ.latin}; Functions: {this.inf_occ.functions}";
        }
    }
}
