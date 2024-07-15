using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "title must be 5 character")]
        [MaxLength(280, ErrorMessage = "title cannot be over 28 characters")]
        public String Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "content must be 5 character")]
        [MaxLength(280, ErrorMessage = "content cannot be over 28 characters")]
        public String Content {get; set;} = string.Empty;

    }
}