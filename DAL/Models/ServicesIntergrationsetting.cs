using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesIntergrationsetting
    {
        public decimal Id { get; set; }
        public string Databasename { get; set; }
        public string Schemaname { get; set; }
        public string Integrationtype { get; set; }
        public string Currentdatabasename { get; set; }
        public string Dblinkname { get; set; }
    }
}
