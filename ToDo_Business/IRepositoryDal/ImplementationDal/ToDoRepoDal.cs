using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;
using ToDo_Business.Context;

namespace ToDo_Business.IRepositoryDal.ImplementationDal
{
    public class ToDoRepoDal : IToItem
    {
        private readonly DapperContext _context;

        public ToDoRepoDal(DapperContext context)
        {
            _context = context;
        }

        public async Task<List<ToDoModel>> getList()
        {
            try
            {
                string query = @"Select * from TODOLIST";
                using(var con = _context.CreateConnection())
                {
                    
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
