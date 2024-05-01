using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lvl3Week3Day2_BlogBackend.Models
{
    public class TaskItemModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BoardID {get; set; }
        public string? DateCreated { get; set; }
        public string? Title { get; set; }
        public string? Description {get; set; }
        public int? Status { get; set; }
        public int? Priority { get; set; }


        public TaskItemModel()
        {
            
        }
    }
}