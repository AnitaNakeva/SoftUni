using System.ComponentModel.DataAnnotations;
using static ForumApp.Common.EntityValidations.Post;

namespace ForumApp.Data.Models;

public class PostForm
{
    [Required]
    [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
    public string Title { get; set; } = null!;

    [Required]
    [StringLength(ContentMaxLength, MinimumLength = ContextMinLength)]
    public string Content { get; set; } = null!;

}