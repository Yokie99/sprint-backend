using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lvl3Week3Day2_BlogBackend.Models
{
    public class MemberModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BoardId { get; set; }

        public MemberModel() { }
    }
}