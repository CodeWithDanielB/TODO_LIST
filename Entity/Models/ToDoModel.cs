using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class ToDoModel
    {
        public int todo_id { get; set; }
        public string todo_name { get;set;}
        public DateTime completed_date { get; set; }
        public bool is_completed { get; set; }
        public DateTime to_createdate { get; set; }

    }
}
