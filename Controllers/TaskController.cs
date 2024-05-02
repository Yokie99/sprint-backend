using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Lvl3Week3Day2_BlogBackend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lvl3Week3Day2_TaskBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _data;

        public TaskController(TaskService data)
        {
            _data = data;
        }

        [HttpPost]
        [Route("AddTaskItem")]
        public bool AddTaskItem(TaskItemModel task){
            return _data.AddTaskItem(task);
        }
    }
}