using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace CodeFirst
{
    public class User:IdentityUser
    {
        public byte[] Photo { get; set; }
       // public DateTime DateCreated { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }  
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}