using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Business.IService.Interfaces
{
    public interface ITodoService<T> where T : class
    {

        Task<T> GetByIdAsync(int id);
        Task<List<T>> getAllToDoAsync();
        Task<int> AddAsync(T obj);
        Task<int> UpdateTodoAsync(T obj);
        Task<int> DeleteAsync(int id);
    }

}
