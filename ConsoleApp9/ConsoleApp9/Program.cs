using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<Book> book = new BookRepository();
            List<Book> listhistory = new List<Book>();
            var a1 = new Book() { Id = 1, Name = "Alexandr Macedonski",Type="History" };
            List<Book> listdetective = new List<Book>();
            var a2 = new Book() { Id = 2, Name = "Sherlock Holmes" };
            List<Book> listromanian = new List<Book>();
            var a3 = new Book() { Id = 3, Name = "Rio" };
            List<Book> listdrama = new List<Book>();
            var a4 = new Book() { Id = 4, Name = "Doctor House" };
            IDictionary<string,List<Book>> dict = new Dictionary<string, List<Book>>()
                                            {
                                                {"History",listhistory},
                                                
                                            };
            Books value =Books.History;
            switch (value)
            {
                case Books.History:
                    foreach (KeyValuePair<string,List<Book>> item in dict)
                    {
                        Console.WriteLine("Key: {0}, Value: {1}", item.Key);
                        foreach()
                    }
                    break;
                case Books.Detective:
                    
                    break;
                case Books.Romanian:
                  
                    break;
                case Books.Drama:

                    break;
            }

            Console.ReadKey();

        }
       
       public   enum Books
        {
          History,
          Detective,
          Romanian,
          Drama,
        };
        
      
    }
}
