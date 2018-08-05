using System;
using System.Collections;
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
            Animal animal = new Dog();

            //IEnumerables<Animal> aaa = new MyEnumerables<Animal>();

            //IEnumerables<Dog> enumerables = new MyEnumerables<Dog>();

            IEnumerables<Animal> enumerables3 = new MyEnumerables<Dog>();

            List<int> a = new List<int>(3);
            ArrayList b = new ArrayList(3);
            Dictionary<int,int> c = new Dictionary<int,int>();
            c.Add(1, 1);
            c.Add(2, 2);
          
            b.Add("2");
            b.Add(1);
            b.Remove("2");
            a.Add(5);
            a.Add(2);
            a.Add(5);
            a.Insert(2, 7);
            a.Remove(5);
           
            //a.Reverse();
            //a.Sort();
            foreach (var item in c)
                if(item.Key==2)
                Console.WriteLine(item);

          //  ProcessBook();
            Console.ReadKey();

        }
        public static void ProcessBook()
        {
            IRepository<Book> listhistory = new Repository<Book>();

            var a1 = new Book() { Id = 1, Name = "Alexandr Macedonski", Author = "Homer", AgeBook = 1456 };
            listhistory.Add(a1);
            IRepository<Book> listdetective = new Repository<Book>();
            var a2 = new Book() { Id = 2, Name = "Sherlock Holmes", Author = "Johanes Martin", AgeBook = 45 };
            listdetective.Add(a2);
            IRepository<Book> listromanian = new Repository<Book>();
            var a3 = new Book() { Id = 3, Name = "Rio", Author = "Homer", AgeBook = 1456 };
            listromanian.Add(a3);
            IRepository<Book> listdrama = new Repository<Book>();
            var a4 = new Book() { Id = 4, Name = "Doctor House", Author = "Bret Po", AgeBook = 23 };
            listdrama.Add(a4);
            Books value = Books.Romanian;
            switch (value)
            {
                case Books.History:
                    foreach (var item in listhistory.GetList)
                        Console.WriteLine(item.Name);
                    break;
                case Books.Detective:
                    foreach (var anotheritem in listdetective.GetList)
                        Console.WriteLine(anotheritem.Name);
                    break;
                case Books.Romanian:
                    foreach (var anotheritem in listromanian.GetList)
                        Console.WriteLine(anotheritem.Name);
                    break;
                case Books.Drama:
                    foreach (var anotheritem in listdrama.GetList)
                        Console.WriteLine(anotheritem.Name);
                    break;
            }
            IRepository<Book> listcompare = new Repository<Book>();
            listcompare.Add(a1);
            listcompare.Add(a2);
            listcompare.Add(a3);
            listcompare.Add(a4);
            var authorDifferents = listcompare.GetList.Distinct(new AuthorEqualityComparer());
            Console.WriteLine(authorDifferents.Count());
            ComparerAgeBook age = new ComparerAgeBook();
            var comparerAgeBook = age.Compare(a1, a2);
            Console.WriteLine(comparerAgeBook);
        }
        public static void ProcessPerson()
        {
            Dictionary<string, List<Person>> listd = new Dictionary<string,List<Person>>();
            List<Person> listp = new List<Person>();
            var p1 = new Person() { Name = "Cebotari Ion" };
            listp.Add(p1);
            listd.Add("Name:", listp);     
        }
        public enum Books
        {
            History,
            Detective,
            Romanian,
            Drama,
        };


    }
}
