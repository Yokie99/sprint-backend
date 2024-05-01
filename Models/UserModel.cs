using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lvl3Week3Day2_BlogBackend.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string? Color { get; set; }

        public string? Username { get; set; }
        public string? Salt { get; set; }
        public string? Hash { get; set; }

        public UserModel()
        {
            
        }
    }
}