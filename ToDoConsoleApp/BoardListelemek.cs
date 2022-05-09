using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsoleApp
{
    public static class BoardListelemek
    {
        public static void Goster()
        {
            DisplayCards.ToDo();
            DisplayCards.InProgress();
            DisplayCards.Done();
        }
    }
}
