using System;
using System.Collections.Generic;
using System.Text;

namespace Asrfly.Core
{
   public class UsersRoles
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public bool Value { get; set; }

        // Navigations
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
