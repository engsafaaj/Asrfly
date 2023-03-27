using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Asrfly.Data.SqlServer
{
    public class BackUpRestoreHelper
    {
        private DBContext db;
        public BackUpRestoreHelper()
        {
            db = new DBContext();
        }

        public string BackUp(string Path)
        {
            try
            {
                db = new DBContext();
                db.Database.SetCommandTimeout(0);
                string dbName = db.Database.GetDbConnection().Database;
                string FileName = Path + dbName + DateTime.Now.ToString("yyyyMMddHHmm") + ".bak";
                string sqlquery = "BACKUP DATABASE ["+dbName+ "] TO  DISK = N'" + FileName + "' WITH NOFORMAT, NOINIT,  NAME = N'" + dbName + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                db.Database.ExecuteSqlRaw(sqlquery);
                return "1";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string Restore(string FileName)
        {
            try
            {
                db = new DBContext();
                db.Database.SetCommandTimeout(0);
                string dbName = db.Database.GetDbConnection().Database;

                string AlterDbSetSingle = "ALTER DATABASE [" + dbName + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                string AlterDbSetDouble = ";ALTER DATABASE [" + dbName + "] SET MULTI_USER";

                string sqlquery = AlterDbSetSingle+"USE [master];RESTORE DATABASE [" +dbName+ "] FROM  DISK = N'" + FileName + "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5"+ AlterDbSetDouble;

                db.Database.ExecuteSqlRaw(sqlquery);
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
