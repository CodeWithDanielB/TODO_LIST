using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Business.IService.Interfaces
{
    public interface ITodoService<T> where T : class
    {
        Task<T> getAllToDoList();
        T getById(int id);
        Task<T> saveUpdateToDo(T obj);
        void deleteTod(int id);
    }
}
