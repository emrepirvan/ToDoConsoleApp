using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsoleApp
{
    public class DeleteCard
    {
        public static void Deleting()
        {

            Console.Write(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n" +
                "Lütfen kart başlığını yazınız: ");
            string data = Console.ReadLine();
            bool check = false;
            foreach (var item in ToDoList._cards)
            {
                if (item.Baslik.ToLower() == data.ToLower() )
                {
                    Console.Write($"{item.Baslik} isimli Card silinmek üzere, onaylıyor musunuz ?(y/n) ");
                    char yn = char.Parse(Console.ReadLine().ToLower());
                    if (yn == 'y')
                    {
                        ToDoList._cards.Remove(item);
                        Console.WriteLine("Başarıyla silindi.\n");
                        check = true;
                        break;
                        
                    }
                    else if (yn == 'n')
                    {
                        check = true;
                        break;
                    }

                }
            }
            if (!check)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                 " * Silmeyi sonlandırmak için: (Her Hangi bir tuşa basabilirsiniz)\n" +
                 " * Yeniden denemek için: (2)");
                var select = Console.ReadLine();
                if (select == "2")
                {
                    Deleting();

                }
            }
        }
    }
}
