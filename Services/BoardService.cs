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

        public IEnumerable<BoardItemModel> GetBoardsByUserID(int userId)
        {
            return _context.BoardInfo.Where(item => item.UserID == userId);
        }

        public bool CreateBoard(BoardItemModel newBoardItem)
        {
            _context.Add(newBoardItem);
            return _context.SaveChanges() != 0;
        }

        public bool UpdateBoard(BoardItemModel boardUpdate)
        {
            _context.Update<BoardItemModel>(boardUpdate);
            return _context.SaveChanges() != 0;
        }
    }
}