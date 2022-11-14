using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    public class Temporal:Part, IPrint
    {
        public int id;
        public string temporal_name; // зберігається загальна інформація про скроневу частину (та що одразу після заголовку)
        public struct touch_input_processing // обробка сенсорного введення
        {
            public string otic;
            public string visual;
            public string speech_recognition;
        }
        public touch_input_processing function;
        public Temporal()
        {
            id=202;
            temporal_name = "";
            structure = "";
            latin = "";
            functions = "";
            function.otic = "";
            function.visual = "";
            function.speech_recognition = "";
            clinical_significance = "";
        }
        public void Print(string str) { }
        public void Print_all_information() { }
    }
}
