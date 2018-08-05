using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Animal
    { }

    public class Dog : Animal
    {
        
      
    }

    public interface IEnumerables<out T>
    {
        
    }

    public class MyEnumerables<T> : IEnumerables<T>
    {
        
    }




    public interface IEnumerator<in T>
    {
        int Current { get; }
        bool MoveNext();
    }
}
