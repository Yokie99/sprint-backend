using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lvl3Week3Day2_BlogBackend.Models
{
    public class BoardItemModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string? Name { get; set; }
        public string? InviteCode {get; set; }
        public bool? IsPublished { get; set; }
        public bool? IsDeleted { get; set; }


        public BoardItemModel()
        {
            
        }
    }
}