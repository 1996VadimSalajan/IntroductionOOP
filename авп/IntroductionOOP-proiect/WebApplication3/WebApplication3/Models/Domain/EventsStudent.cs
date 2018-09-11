using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
   public  class EventsStudent
    {  [Key, Column(Order = 0)]
       public int EventId { get; set; }
       [Key, Column(Order = 1)]
       public int StudentId { get; set; }
       public virtual Student Student { get; set; }
       public virtual Event Event { get; set; }
    }
}
