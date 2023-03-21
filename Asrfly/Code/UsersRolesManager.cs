using System;
using System.Collections.Generic;
using System.Text;

namespace Asrfly.Code
{
   public static class UsersRolesManager
    {
        private static Dictionary<string, bool> RolesList = new Dictionary<string, bool>();

        public static void Register(string RoleKey,bool RoleValue)
        {
            RolesList.Add(RoleKey, RoleValue);
        }

        public static bool GetRole(string RoleKey)
        {
            return RolesList[RoleKey];
        }
    }
}
