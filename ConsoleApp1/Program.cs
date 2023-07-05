
// Program.cs  Выполнено студентом Комаровым Ярославом Вячеславовичем 34ИС
using System;
using KomarovYaroslav.Library;

namespace KomarovYaroslav.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Name = "Yaroslav Store";
            store.Address = "Tihomirova Street";

            Product product1 = new Product { Name = "Produkt 1", Number = 5 };
            Product product2 = new Product { Name = "Produkt 2", Number = 3 };
            Product product3 = new Product { Name = "Produkt 3", Number = 7 };

            store.Products.Add(product1);
            store.Products.Add(product2);
            store.Products.Add(product3);

            store.ShowAll();

            Console.WriteLine("\nSortirovka po nomeru...");
            store.Products.Sort();
            store.ShowAll();

            Console.ReadLine();
        }
    }
}