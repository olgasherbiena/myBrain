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
        public string occiput_name; // зберігається загальна інформація про потиличну частину (та що одразу після заголовку)
        public string first_functional_area;
        public string ventral_flow;
        public string dorsomedial_flow;
        public Occiput()
        {
            //id=102;
            occiput_name = "occ_part";
            structure = "occ_struct";
            latin = "occ_lat";
            functions = "occ_func";
            clinical_significance = "occ_4";
            first_functional_area = "occ_1";
            ventral_flow = "occ_2";
            dorsomedial_flow = "occ_3";

        }
        public void Print(string str) { }
        public void Print_all_information() { }

        public override string ToString()
        {
            return $"{id}; Name: {this.occiput_name}; Latin: {this.latin}; Functions: {this.functions}";
        }
    }
}
