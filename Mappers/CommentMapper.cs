using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModes){
            return new CommentDto{
                Id = commentModes.Id,
                Title = commentModes.Title,
                Content = commentModes.Content,
                CreatedOn = commentModes.CreatedOn,
                StockId = commentModes.StockId
        };
    }
        public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int stockId){
            return new Comment{
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId
        };
    }
        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto){
            return new Comment{
                Title = commentDto.Title,
                Content = commentDto.Content
        };
    }
}
}