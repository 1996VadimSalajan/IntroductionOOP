using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public static class LinqPginationExtension
    {
        public static IQueryable<T> Page<T>(this IQueryable<T> query,int pagenumber,int pagesize)
        {
            return query.Skip(pagenumber*pagesize).Take(pagesize);
        }
    }
}
