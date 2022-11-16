using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
    class ActionsListClass
    {
        //public Dictionary<String, int[]> actions;
        public Dictionary<String, Dictionary<int, int>> actions; // <Назва дії : <id частини мозку : часова затримка>>
        public ActionsListClass()
        {
            // Усі дії треба зчитуати з файлу і записувати у Dictionary

            //actions = new Dictionary<string, int[]>();
            //actions.Add("Ходьба", new int[5] { 101, 202, 110, 120, 102 }); // 101, 202 ... це id частин мозку
            //actions.Add("Задача зі стереометрії", new int[5] { 202, 101, 120, 110, 102 });
            actions = new Dictionary<string, Dictionary<int, int>>();
            actions.Add("Ходьба", new Dictionary<int, int>{ 
                { 101, 1000 },
                { 202, 2000 },
                { 110, 2000 },
                { 120, 1000 },
                { 102, 1000 } });
            actions.Add("Задача зі стереометрії", new Dictionary<int, int>{
                { 202, 2000 },
                { 101, 1000 },
                { 120, 3000 },
                { 110, 1000 },
                { 102, 1000 } });
        }
    }

}
