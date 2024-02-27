using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;

namespace ToDo_Business.IRepositoryDal
{
    public interface IToItem
    {
        Task<List<ToDoModel>> getList();
    }
}
