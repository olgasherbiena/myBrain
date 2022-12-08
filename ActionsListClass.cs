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
                { 101, 3000 },
                { 120, 3000 } });
            actions.Add("Моторика рук", new Dictionary<int, int>{
                { 120, 3000 } });
            actions.Add("Зір", new Dictionary<int, int>{
                { 102, 3000 } });
            actions.Add("Пам'ять", new Dictionary<int, int>{
                { 120, 3000 },
                { 202, 3000 } });
            actions.Add("Мовлення", new Dictionary<int, int>{
                { 120, 3000 } });
            actions.Add("Слух", new Dictionary<int, int>{
                { 110, 3000 } });
            actions.Add("Смак", new Dictionary<int, int>{
                { 110, 3000 },
                { 120, 3000 } });
            actions.Add("Інтелект", new Dictionary<int, int>{
                { 110, 3000 } });
            actions.Add("Емоції", new Dictionary<int, int>{
                { 120, 3000 },
                { 202, 3000 } });
            actions.Add("Сон", new Dictionary<int, int>{
                { 120, 3000 } });
        }
    }

}
