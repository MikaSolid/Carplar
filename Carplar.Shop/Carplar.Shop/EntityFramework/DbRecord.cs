using System;

namespace Carplar.Shop.EntityFramework
{
    public class DbRecord
    {
        public DateTime Created { get; set; }

        public DateTime? Deleted { get; set; }
    }
}