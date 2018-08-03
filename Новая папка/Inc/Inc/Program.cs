using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inc
{
    class Program
    {
        public static IServiceProvider IServiceCollection { get; set; }

        static void Main(string[] args)
        {     
            IRepository<Book> book = new Repository<Book>();
            Book b1 = new Book() { NameBook = "Doctor House", AgeBook = 234 };
            book.Add(b1);
            var a = new ServiceCollection();
            a.AddTransient<IBook,Book>();
            a.AddTransient<IPerson,Person>();
            a.AddTransient<IRepository<Book>, Repository<Book>>();
            a.AddTransient<IRepository<Person>, Repository<Person>>();
            a.AddTransient<Controller>();
            Program.IServiceCollection = a.BuildServiceProvider();
            var controller =IServiceCollection.GetService<Controller>();  
            Console.ReadKey();
        }
    }
}
