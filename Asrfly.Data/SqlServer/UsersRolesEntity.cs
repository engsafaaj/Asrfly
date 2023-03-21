using Asrfly.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asrfly.Data.SqlServer
{
    public class UsersRolesRolesEntity : IDataHelper<UsersRoles>
    {

        // Variables
        private DBContext db;
        private UsersRoles table;
        // Constructors
        public UsersRolesRolesEntity()
        {
            db = new DBContext();
        }

        #region Methods
        public int Add(UsersRoles table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db.UsersRoles.Add(table);
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

        public async Task<int> AddAsync(UsersRoles table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    await db.UsersRoles.AddAsync(table);
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
                    db.UsersRoles.Remove(table);
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
                    await Task.Run(() => db.UsersRoles.Remove(table));
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

        public int Edit(UsersRoles table)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    db = new DBContext();
                    db.UsersRoles.Update(table);
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

        public async Task<int> EditAsync(UsersRoles table)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    db = new DBContext();
                    await Task.Run(() => db.UsersRoles.Update(table));
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

        public UsersRoles Find(int Id)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.UsersRoles.Where(x => x.Id == Id).First();
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

        public async Task<UsersRoles> FindAsync(int Id)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.UsersRoles.Where(x => x.Id == Id).First());
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

        public List<UsersRoles> GetAllData()
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.UsersRoles.ToList();
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

        public async Task<List<UsersRoles>> GetAllDataAsync()
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.UsersRoles.ToList());
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

        public List<UsersRoles> Search(string SearchItem)
        {
            try
            {
                if (db.Database.CanConnect())
                {
                    return db.UsersRoles.Where(x => x.Id.ToString() == SearchItem
                    || x.Key.Contains(SearchItem)
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

        public async Task<List<UsersRoles>> SearchAsync(string SearchItem)
        {
            try
            {
                if (await db.Database.CanConnectAsync())
                {
                    return await Task.Run(() => db.UsersRoles.Where(x => x.Id.ToString() == SearchItem
                    || x.Key.Contains(SearchItem)
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
