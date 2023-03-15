using System;
using System.Collections.Generic;
using System.Text;

namespace Asrfly.Core
{
    public class Suppliers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }
        public double Balance { get; set; }
        public DateTime AddedDate { get; set; }

        // Navigations
        public virtual List<Outcome> Outcome { get; set; }
    }
}
