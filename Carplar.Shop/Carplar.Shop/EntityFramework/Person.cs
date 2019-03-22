using System;

namespace Carplar.Shop.EntityFramework
{
    public class Person : DbRecord
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int PartyId { get; set; }

        public virtual Party Party { get; set; }        
    }
}
