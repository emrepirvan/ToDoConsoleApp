using System;

namespace ToDoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ToDoList._cards.Add(new Card("TodoApp", "Patika.dev Todo App yapılacak", "Emre Pirvan", Card.buyukluk.XS));
            ToDoList._cards.Add(new Card("TodoApp", "Patika.dev Todo App yapılacak", "Emre Pirvan", Card.buyukluk.XS));
            ToDoList._cards.Add(new Card("Veri  tabanı", "Veritabanı kodlari düzenlenicek", "Drizzt DoUrden", Card.buyukluk.L , "IN PROGRESS"));
           // ToDoList._cards.Add(new Card("UI", "UI işlemleri tamamlanıp sunum yapılacak", "Tony Stark", Card.buyukluk.M,"DONE"));
            ToDoList._cards.Add(new Card("Patika", "Patika c# videoları bitecek", "Emre Pirvan", Card.buyukluk.M));

            HomePage.Select();
        }
    }
}
