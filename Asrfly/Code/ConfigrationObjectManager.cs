using System;
using System.Collections.Generic;
using System.Text;

namespace Asrfly.Code
{
   public static class ConfigrationObjectManager
    {
        private static Dictionary<string, object> ObjectList = new Dictionary<string, object>();

        public static void Register(string ObjectName,object ObjectValue)
        {
            ObjectList.Add(ObjectName, ObjectValue);
        }

        public static object GetObject(string ObjectName)
        {
            return ObjectList[ObjectName];
        }
    }
}
