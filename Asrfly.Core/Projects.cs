using System;
using System.Collections.Generic;
using System.Text;

namespace Asrfly.Core
{
   public class Projects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Details { get; set; }
        public double Income { get; set; }
        public double Outcome { get; set; }
        public double Revenue { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
