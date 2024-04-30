using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Lvl3Week3Day2_BlogBackend.Models.DTO;
using Lvl3Week3Day2_BlogBackend.Services.Context;

namespace Lvl3Week3Day2_BlogBackend.Services
{
    public class UserService
    {

        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public bool DoesUserExist(string Username){
            return _context.UserInfo.SingleOrDefault(user => user.Username == Username) != null;
        }

        public bool AddUser(CreateAccountDTO UserToAdd)
        {
            bool result = false;

            if(!DoesUserExist(UserToAdd.Username)){
                UserModel newUser = new UserModel();
                result = true;
            }

            return result;
        }
    }
}