using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Data
{
    public interface IDataHelper<Table>
    {
        // Read
        List<Table> GetAllData();
        List<Table> Search(string SearchItem);
        Table Find(int Id);

        // Write
        int Add(Table table);
        int Edit(Table table);
        int Delete(int Id);

        // Read Async
        Task<List<Table>> GetAllDataAsync();
        Task<List<Table>> SearchAsync(string SearchItem);
        Task<Table> FindAsync(int Id);

        // Write Async
        Task<int> AddAsync(Table table);
        Task<int> EditAsync(Table table);
        Task<int> DeleteAsync(int Id);
    }
}
