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
            ConfigrationObjectManager.Register("SystemRecords", new SystemRecordsEntity());
            ConfigrationObjectManager.Register("Customers", new CustomersEntity ());
            ConfigrationObjectManager.Register("Suppliers", new SuppliersEntity ());
            ConfigrationObjectManager.Register("Projects", new ProjectsEntity ());
            ConfigrationObjectManager.Register("Outcome", new OutcomeEntity ());
            ConfigrationObjectManager.Register("Income", new IncomeEntity ());
        }
    }
}
