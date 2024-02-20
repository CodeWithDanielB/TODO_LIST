using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_Business.IService.Interfaces;

namespace ToDo_Business.IService.Implementation
{
    public class ToDoService : ITodoService<ToDoModel>
    {
        public void deleteTod(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ToDoModel> getAllToDoList()
        {
            throw new NotImplementedException();
        }

        public ToDoModel getById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ToDoModel> saveUpdateToDo(ToDoModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
