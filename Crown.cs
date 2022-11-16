using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Crown:Part,IPrint
    {
        public const int id = 110;
        public string crown_name; // зберігається загальна інформація про тім'яну частину (та що одразу після заголовку)
        public string lateral_intraparietal_area;
        public string ventral_intraparietal_area;
        public string medial_intraparietal_area;
        public string front_intraparietal_area;
        public Crown()
        {
            //id;
            crown_name = "crw_part";
            structure = "crw_struct";
            latin = "crw_lat";
            functions = "crw_func";
            clinical_significance = "crw_clinic";
            lateral_intraparietal_area = "crw_1";
            ventral_intraparietal_area = "crw_2";
            medial_intraparietal_area = "crw_3";
            front_intraparietal_area = "crw_4";
        }
        public void Print(string str) { }
        public void Print_all_information() { }

        

        public override string ToString()
        {
            return $"{id}; Name: {this.crown_name}; Latin: {this.latin}; Functions: {this.functions}";
        }
    }
}
