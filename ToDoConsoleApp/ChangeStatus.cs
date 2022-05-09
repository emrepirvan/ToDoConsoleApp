using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsoleApp
{
    public static class ChangeStatus
    {
        public static void changing()
        {
            Console.WriteLine(" Öncelikle Taşımak istediğiniz kartı seçmeniz gerekiyor.\n" +
                      "Lütfen kart başlığını yazınız:  \n" );
            string data = Console.ReadLine();
            bool check = false;
            foreach (var item in ToDoList._cards)
            {
                if (item.Baslik.ToLower() == data.ToLower())
                {
                    Console.WriteLine($"Başlık      :{item.Baslik}\nİçerik      :{item.Icerik}\nAtanan Kişi :{item.AtananKisi}\nBüyüklük    :{item.Buyukluk}\nLİNE    :{item.BulunduguLine}\n");
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: " +
                        "\n(1) TODO\n" +
                        "(2) IN PROGRESS\n" +
                        "(3) DONE");
                    string secim = Console.ReadLine();
                    if (secim != null)
                    {
                        if (secim == "1") { 
                            item.BulunduguLine = "TODO";
                            check = true;
                            break;
                        }
                        else if (secim == "2") { 
                            item.BulunduguLine = "IN PROGRESS";
                            check = true;
                            break;
                        }
                        else if (secim == "3") { 
                            item.BulunduguLine = "DONE";
                            check = true;
                            break;
                        }
                        else { 
                            Console.WriteLine("HATALI SECİM YAPTINIZ");
                        break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("HATALI SECİM YAPTINIZ");
                        break;
                    }
                }
            }
            if (check)
            {
                BoardListelemek.Goster();
            }
            if (!check)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                 " * İşlemi sonlandırmak için : (Her Hangi bir tuşa basabilirsiniz)\n" +
                 " * Yeniden denemek için: (2)");
                var select = Console.ReadLine();
                if (select == "2")
                {
                    changing();

                }
            }
        }
    }
}
