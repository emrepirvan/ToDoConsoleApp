using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsoleApp
{
    public static class HomePage
    {
        public static void Select()
        {
            Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz :) " +
                                "\n * ******************************************" +
                                "\n(1) Board Listelemek" +
                                "\n(2) Board'a Kart Eklemek" +
                                "\n(3) Board'dan Kart Silmek" +
                                "\n(4) Kart Taşımak");
            var secim = Console.ReadLine();
            while (secim.ToLower() != "cikis")
            {
                switch (secim)
                {
                    case "1":
                        BoardListelemek.Goster();
                        break;
                    case "2":
                        Console.WriteLine("(2) Board'a Kart Eklemek");
                        break;
                    case "3":
                        Console.WriteLine("(3) Board'dan Kart Silmek");
                        break;
                    case "4":
                        Console.WriteLine("(4) Kart Taşımak");
                        break;
                    default:
                        Console.WriteLine("Lütfen Geçerli bir Seçim yapınız");
                        break;
                }
                Console.WriteLine("Başka bir işlem yapabilir  veya 'cikis' yapabilirsiniz");
                secim = Console.ReadLine();

            };
        }
       
    }
}
