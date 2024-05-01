using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Lvl3Week3Day2_BlogBackend.Services.Context
{
    public class DataContext :DbContext
    {
        public DbSet<UserModel> UserInfo{get; set;}
        public DbSet<BoardItemModel> BoardInfo{get; set;}
        public DbSet<BoardItemModel> TaskInfo{get; set;}
        public DataContext (DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}