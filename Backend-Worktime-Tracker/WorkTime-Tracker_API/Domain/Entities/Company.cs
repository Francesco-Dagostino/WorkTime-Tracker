using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public Company() { }
    }
}
