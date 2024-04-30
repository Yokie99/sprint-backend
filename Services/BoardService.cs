using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Lvl3Week3Day2_BlogBackend.Services.Context;

namespace Lvl3Week3Day2_BlogBackend.Services
{
    public class BoardService
    {
        private readonly DataContext _context;

        public BoardService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<BoardItemModel> GetAllBoards()
        {
            return _context.BoardInfo;
        }

        public bool CreateBoard(BoardItemModel newBoardItem)
        {
            _context.Add(newBoardItem);
            return _context.SaveChanges() != 0;
        }
    }
}