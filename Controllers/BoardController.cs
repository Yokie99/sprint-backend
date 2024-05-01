using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Lvl3Week3Day2_BlogBackend.Services;
using Microsoft.AspNetCore.Mvc;



namespace Lvl3Week3Day2_BlogBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoardController : ControllerBase
    {
         private readonly BoardService _data;

         public BoardController(BoardService data){
            _data = data;
        }

        [HttpGet]
        [Route("GetAllBoards")]
        public IEnumerable<BoardItemModel> GetAllBoards(){
            return _data.GetAllBoards();
        }

        [HttpGet]
        [Route("GetBoardsByUserID/{userID}")]
        public IEnumerable<BoardItemModel> GetBoardsByUserID(int userID){
            return _data.GetBoardsByUserID(userID);
        }

        [HttpPost]
        [Route("CreateBoard")]
        public bool CreateBoard(BoardItemModel newBoardItem){
            return _data.CreateBoard(newBoardItem);
        }

        [HttpPut]
        [Route("UpdateBoard")]
        public bool UpdateBoard(BoardItemModel boardUpdate){
            return _data.UpdateBoard(boardUpdate);
        }
    }


   
}