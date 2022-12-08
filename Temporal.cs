using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Temporal: Part, IPrint
    {
        public const int id = 202;
        private string temporal_name; // зберігається загальна інформація про скроневу частину (та що одразу після заголовку)
        private struct touch_input_processing // обробка сенсорного введення
        {
            public string otic;
            public string visual;
            public string speech_recognition;
        }
        private touch_input_processing function;
        public Temporal()
        {
            temporal_name = "tmp_part";
            structure = "tmp_struct";
            latin = "tmp_lat";
            functions = "tmp_func";
            function.otic = "tmp1";
            function.visual = "tmp2";
            function.speech_recognition = "tmp3";
            clinical_significance = "tmp4";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
        public string Temporal_name { set { temporal_name = value; } get { return temporal_name; } }
        public string Otic { set { function.otic = value; } get { return function.otic; } }
        public string Visual { set { function.visual = value; } get { return function.visual; } }
        public string Speech_recognition { set { function.speech_recognition = value; } get { return function.speech_recognition; } }
        public override string ToString()
        {
            return $"{id}; Name: {this.temporal_name}; Latin: {this.latin}; Functions: {this.functions}";
        }
    }
}
