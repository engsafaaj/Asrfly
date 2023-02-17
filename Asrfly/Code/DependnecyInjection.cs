using Asrfly.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asrfly.Code
{
   public static class DependnecyInjection
    {
        public static void AddDependencyValues()
        {
            ConfigrationObjectManager.Register("Categories", new CategoriesEntity());
        }
    }
}
