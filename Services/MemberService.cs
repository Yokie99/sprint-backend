using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Lvl3Week3Day2_BlogBackend.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lvl3Week3Day2_BlogBackend.Services
{
    public class MemberService : ControllerBase
    {
        private readonly DataContext _context;
        public MemberService(DataContext context)
        {
            _context = context;
        }

        // Get Boards by User ID
        public IActionResult GetUserBoards(int userId)
        {
            var boardIds = _context.MemberInfo
                .Where(uc => uc.UserId == userId)
                .Select(uc => uc.BoardId)
                .ToList();

            return Ok(boardIds);
        }

        // Get Members by Board Id
        public IActionResult GetBoardMembers(int boardId)
        {
            var memberIds = _context.MemberInfo
                .Where(board => board.BoardId == boardId)
                .Select(boardM => boardM.UserId)
                .ToList();

            return Ok(memberIds);
        }


        public async Task<IActionResult> AddBoardMember(int userId, int boardId)
        {
            try
            {
                var existingUser = await _context.MemberInfo.FirstOrDefaultAsync(board => board.UserId == userId && board.BoardId == boardId);

                if (existingUser != null)
                {
                    return Conflict("User already joined this board");
                }

                var userBoard = new MemberModel
                {
                    UserId = userId,
                    BoardId = boardId
                };

                _context.MemberInfo.Add(userBoard);
                await _context.SaveChangesAsync();

                return Ok("User successfully joined the board!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error adding member: {ex.Message}");
            }
        }

        public async Task<IActionResult> RemoveBoardMember(int userId, int boardId)
        {
            try
            {
                var userBoard = await _context.MemberInfo.FirstOrDefaultAsync(board => board.UserId == userId && board.BoardId == boardId);

                if (userBoard == null)
                {
                    return NotFound("User is not a member of the board.");
                }

                _context.MemberInfo.Remove(userBoard);
                await _context.SaveChangesAsync();

                return Ok("User removed from board successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error removing member from board: {ex.Message}");
            }
        }

        public async Task<IActionResult> RemoveBoardFromUser(int userId, int boardId)
        {
            try
            {
                var userBoards = await _context.MemberInfo.Where(board => board.UserId == userId && board.BoardId == boardId).ToListAsync();

                if (userBoards == null || !userBoards.Any())
                {
                    return NotFound("User is not associated with the board.");
                }

                _context.MemberInfo.RemoveRange(userBoards);
                await _context.SaveChangesAsync();

                return Ok("Board removed from user successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error removing board from user: {ex.Message}");
            }
        }

    }
}