using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Lvl3Week3Day2_BlogBackend.Models.DTO;
using Lvl3Week3Day2_BlogBackend.Services.Context;

namespace Lvl3Week3Day2_BlogBackend.Services
{
    public class TaskService
    {
        private readonly DataContext _context;

        public TaskService(DataContext context)
        {
            _context = context;
        }

        public bool AddTaskItem(AddTaskDTO newTaskItem)
        {
            _context.Add(newTaskItem);
            return _context.SaveChanges() != 0;
        }

        
    }
}