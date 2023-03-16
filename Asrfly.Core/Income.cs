using System;
using System.Collections.Generic;
using System.Text;

namespace Asrfly.Core
{
   public class Income
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public DateTime IncomeDate { get; set; }
        public string RecNo { get; set; }
        public double Amount { get; set; }
        public string Details { get; set; }

        // Navigations
        public int CategroyId { get; set; }
        public Categories Categories { get; set; }

        public int SupplierId { get; set; }
        public Suppliers Suppliers { get; set; }

        public int ProjectId { get; set; }
        public Projects Projects { get; set; }
    }
}
