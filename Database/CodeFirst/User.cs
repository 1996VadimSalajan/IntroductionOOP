using System;
using System.Collections.Generic;

namespace CodeFirst
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordUser { get; set; }
        public long IDNP { get; set; }
        public string Photo { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }  
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}