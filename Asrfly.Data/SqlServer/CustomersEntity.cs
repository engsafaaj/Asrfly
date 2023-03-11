using Asrfly.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asrfly.Data.SqlServer
{
    public class CustomersEntity : IDataHelper<Customers>
    {

        // Variables
        private DBContext db;
        private Customers table;
        // Constructors
        public CustomersEntity()
        {
            db = new DBContext();
        }

        #region Methods
        public int Add(Customers table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db.Customers.Add(table);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> AddAsync(Customers table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    await db.Customers.AddAsync(table);
                    await db.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int Delete(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    table = Find(Id);
                    db.Customers.Remove(table);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> DeleteAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    table = await FindAsync(Id);
                    await Task.Run(() => db.Customers.Remove(table));
                    await db.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int Edit(Customers table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db = new DBContext();
                    db.Customers.Update(table);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> EditAsync(Customers table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    db = new DBContext();
                    await Task.Run(() => db.Customers.Update(table));
                    await db.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public Customers Find(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Customers.Where(x => x.Id == Id).First();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<Customers> FindAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Customers.Where(x => x.Id == Id).First());
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<Customers> GetAllData()
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Customers.ToList();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Customers>> GetAllDataAsync()
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Customers.ToList());
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<Customers> Search(string SearchItem)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.Customers.Where(x => x.Id.ToString() == SearchItem
                    || x.Name.Contains(SearchItem)
                    || x.PhoneNumber.Contains(SearchItem)
                    || x.Address.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Balance.ToString().Contains(SearchItem)
                    || x.AddedDate.Date.ToString().Contains(SearchItem)
                    )
                        .ToList();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Customers>> SearchAsync(string SearchItem)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.Customers.Where(x => x.Id.ToString() == SearchItem
                      || x.Name.Contains(SearchItem)
                      || x.PhoneNumber.Contains(SearchItem)
                      || x.Address.Contains(SearchItem)
                      || x.Details.Contains(SearchItem)
                      || x.Balance.ToString().Contains(SearchItem)
                      || x.AddedDate.Date.ToString().Contains(SearchItem)
                    )
                        .ToList());
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
