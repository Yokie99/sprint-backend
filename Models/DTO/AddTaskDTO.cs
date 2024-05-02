using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lvl3Week3Day2_BlogBackend.Models.DTO
{
    public class AddTaskDTO
    {
        public int BoardID { get; set; }
        public int Status { get; set; }
        public string Category { get; set; }
        string DateCreated { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}