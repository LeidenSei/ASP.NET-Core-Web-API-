using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();

        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentMedel);
        Task<Comment?> UpdateAsync(int id, Comment commentMedel);
        Task<Comment?> DeleteAsync(int id);
    }

}