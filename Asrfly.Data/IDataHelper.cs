using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Data
{
    public interface IDataHelper<Table>
    {
        // Read
        /// <summary>Gets all data.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        List<Table> GetAllData();
        /// <summary>Searches the specified search item.</summary>
        /// <param name="SearchItem">The search item.</param>
        /// <returns>Searched Data</returns>
        List<Table> Search(string SearchItem);
        /// <summary>Finds the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Row Table When Id ==Id</returns>
        Table Find(int Id);

        // Write
        /// <summary>Adds the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 when the task success, 0 when task failed</returns>
        int Add(Table table);
        /// <summary>Edits the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 when the task success, 0 when task failed</returns>
        int Edit(Table table);
        /// <summary>Deletes the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>1 when the task success, 0 when task failed</returns>
        int Delete(int Id);

        // Read Async
        /// <summary>Gets all data asynchronous.</summary>
        /// <returns>All Data Of Table</returns>
        Task<List<Table>> GetAllDataAsync();
        /// <summary>Searches the asynchronous.</summary>
        /// <param name="SearchItem">The search item.</param>
        /// <returns>Row Data</returns>
        Task<List<Table>> SearchAsync(string SearchItem);
        /// <summary>Finds the asynchronous.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Row Data</returns>
        Task<Table> FindAsync(int Id);

        // Write Async
        /// <summary>Adds the asynchronous.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 when the task success, 0 when task failed</returns>
        Task<int> AddAsync(Table table);
        /// <summary>Edits the asynchronous.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 when the task success, 0 when task failed</returns>
        Task<int> EditAsync(Table table);
        /// <summary>Deletes the asynchronous.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>1 when the task success, 0 when task failed</returns>
        Task<int> DeleteAsync(int Id);
    }
}
