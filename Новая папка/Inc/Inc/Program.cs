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
        public static ServiceProvider ServiceProvider { get; private set; }

        static void Main(string[] args)
        {     
            var a = new ServiceCollection();

            a.AddTransient<IRepository<Book>, Repository<Book>>();
            a.AddTransient<Repository<Book>>();
            a.AddTransient<IRepository<Person>, Repository<Person>>();
            a.AddScoped<Controller>();

            ServiceProvider = a.BuildServiceProvider();

            var controller = ServiceProvider.GetService<Controller>();

            Console.ReadKey();
        }
    }
}
