using Asrfly.Core;
using Asrfly.Data;
using Asrfly.Data.SqlServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asrfly.Tests
{
    [TestClass]
    public class CategoriesEntityTests
    {
        IDataHelper<Categories> dataHelper;
        public CategoriesEntityTests()
        {
            dataHelper = new CategoriesEntity();
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange ( Set )
            Categories categories = new Categories
            {
                Name = "تحليل المشروع",
                Details = "الصنف الخاص في عملية تحليل المشروع",
                Type = "صرف",
                Balance = 1000,
                AddedDate = DateTime.Now,
            };
            // Act and expt ( Get )

            int act = dataHelper.Add(categories);
            int expt = 1;
            // Assert (Test)
            Assert.AreEqual(expt, act);
        }

        [TestMethod]
        public void EditTest()
        {
            // Arrange ( Set )
            Categories categories = new Categories
            {
                Id = 1,
                Name = "تصميم المشروع",
                Details = "الصنف الخاص في عملية تصميم المشروع",
                Type = "صرف",
                Balance = 2000,
                AddedDate = DateTime.Now,
            };
            // Act and expt ( Get )

            int act = dataHelper.Edit(categories);
            int expt = 1;
            // Assert (Test)
            Assert.AreEqual(expt, act);
        }

        [TestMethod]
        public void GetAllDataTest()
        {
            // Arrange ( Set )

            // Act and expt ( Get )

            var act = dataHelper.GetAllData();
            // Assert (Test)
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void SearchTest()
        {
            // Arrange ( Set )
            var searchitem = "صرف";
            // Act and expt ( Get )

            var act = dataHelper.Search(searchitem);
            // Assert (Test)
            Assert.IsNotNull(act);
        }

        [TestMethod]

        public void FindTest()
        {
            // Arrange ( Set )
            var Id = 1;
            // Act and expt ( Get )

            var act = dataHelper.Find(1);
            // Assert (Test)
            Assert.IsNotNull(act);
        }
        [TestMethod]

        public void DeleteTest()
        {
            // Arrange ( Set )
            var Id = 1;
            // Act and expt ( Get )

            var act = dataHelper.Delete(1);
            // Assert (Test)
            Assert.AreEqual(1, act);
        }
    }
}
