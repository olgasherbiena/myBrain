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
        private string crown_name; // зберігається загальна інформація про тім'яну частину (та що одразу після заголовку)
        private string lateral_intraparietal_area;
        private string ventral_intraparietal_area;
        private string medial_intraparietal_area;
        private string front_intraparietal_area;
        public Crown()
        {
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
        public string Crown_name { set { crown_name = value; } get { return crown_name; } }
        public string Lateral_intraparietal_area { set { lateral_intraparietal_area = value; } get { return lateral_intraparietal_area; } }
        public string Ventral_intraparietal_area { set { ventral_intraparietal_area = value; }get { return ventral_intraparietal_area; } }
        public string Medial_intraparietal_area { set { medial_intraparietal_area = value; } get { return medial_intraparietal_area; } }
        public string Front_intraparietal_area { set { front_intraparietal_area = value; } get { return front_intraparietal_area; } }
        public override string ToString()
        {
            return $"{id}; Name: {this.crown_name}; Latin: {this.latin}; Functions: {this.functions}";
        }
    }
}
