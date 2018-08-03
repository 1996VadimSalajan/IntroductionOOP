using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class AuthorEqualityComparer : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            bool result = x.Author == y.Author;
            return result;
        }

        public int GetHashCode(Book obj)
        {
            return obj.Author.GetHashCode();
        }
    }
