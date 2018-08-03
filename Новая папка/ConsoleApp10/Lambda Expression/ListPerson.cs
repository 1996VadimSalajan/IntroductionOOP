using System.Collections.Generic;

namespace People
{
    public static class ListPerson
    {
        public static List<Person> GetAge(this List<Person> res)
        {
            List<Person> emp3 = res.FindAll(
         delegate (Person p)
         {
             return p.Age == 25;
         });
            return emp3;
        }
    }
}


