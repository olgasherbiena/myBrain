using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brain;
using System.Windows.Controls;

namespace Brain
{
    public class Find
    {
        public string find; // рядок по якому робтитимемо пошук
        public void Find_information(string search_request, ListBox listBox)
        {
            search_request = search_request.ToLower();
            int index = 0;

            // Якщо рядок пошуку пустий - обираємо елемент index(0 за замовченням) в списку
            if (search_request.Length == 0)
            {
                listBox.SelectedItem = listBox.Items.GetItemAt(index);
                //SetSelected(index, true);

                return;
            }

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                // Якщо підрядок міститься у елементу списку - шуканий елемент знайдено, запам'ятовуємо його індекс
                if (listBox.Items[i].ToString().ToLower().Contains(search_request))
                {
                    index = i;
                }
            }

            // Обираємо елемент за індексом списку
            listBox.SelectedItem = listBox.Items.GetItemAt(index);
            //listBox.SetSelected(index, true);
        }  
    }
}
