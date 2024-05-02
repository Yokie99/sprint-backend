using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lvl3Week3Day2_BlogBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly MemberService _data;


        // GET BOARDS BY USER ID
        [HttpGet]
        [Route("GetUsersBoard/{userId}")]
        public IActionResult GetUserBoards(int userId){
            return _data.GetUserBoards(userId);
        }

        // GET MEMBERS BY BOARD ID
        [HttpGet]
        [Route("GetBoardMembers/{boardId}")]
        public IActionResult GetBoardMembers(int boardId){
            return _data.GetBoardMembers(boardId);
        }

        // ADD USER TO BOARD MEMBERS
        [HttpPost]
        [Route("AddBoardMember/{userId}/{boardId}")]
        public async Task<IActionResult> AddBoardMember(int userId, int boardId){
            return await _data.AddBoardMember(userId, boardId);
        }
      
        // DELETE USER IN BOARD MEMBERS
        [HttpDelete]
        [Route("RemoveMemberFromBoard")]
        public async Task<IActionResult> RemoveBoardMember(int userId, int boardId){
            return await _data.RemoveBoardMember(userId, boardId);
        }
    
    }
}