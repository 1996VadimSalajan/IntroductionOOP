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
        public static IServiceProvider IServiceProvider { get; set; }

        static void Main(string[] args)
        {     
            var a = new ServiceCollection();
            a.AddTransient<IBook,Book>();
            a.AddTransient<IPerson,Person>();
            a.AddTransient<IRepository<Book>, Repository<Book>>();
            a.AddTransient<IRepository<Person>, Repository<Person>>();
            a.AddTransient<Controller>();
            Program.IServiceProvider = a.BuildServiceProvider();
            var controller =IServiceProvider.GetService<Controller>();  
            Console.ReadKey();
        }
    }
}
