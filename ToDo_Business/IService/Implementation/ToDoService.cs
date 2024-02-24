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
        private List<todo_id> _todoItems = new List<todo_id>();
        public void deleteTod(int id)
        {
            var taskToDelete = _todoItems.FirstOrDefault(t => t.id == id);
            if (taskToDelete != null)
            {
                _todoItems.Remove(taskToDelete);
            }
        }

        public Task<ToDoModel> getAllToDoList()
        {
            return Task.FromResult(_todoItems);
        }

        public ToDoModel getById(int id)
        {
            return _todoItems.FirstOrDefault(t => t.id == t);
        }

        public Task<ToDoModel> saveUpdateToDo(ToDoModel obj)
        {
            var existingTask = _todoItems.FirstOrDefault( t => t.id == obj.id);
            if (existingTask != null) 
            {
                existingTask = obj;
            }
            else
            {
                _todoItems.Add(obj);
            }
            return Task.FromResult(obj);
        }
    }
}
