using System.Collections.Generic;

namespace ConsoleApp9
{
    class ComparerAgeBook : Comparer<Book>
    {
        public override int Compare(Book x, Book y)
        {
            if (x.AgeBook > y.AgeBook)
                return x.AgeBook;
            else return y.AgeBook;
        }
    }
}