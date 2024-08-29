using System.ComponentModel.DataAnnotations;
using static ForumApp.Common.EntityValidations.Post;

namespace ForumApp.Data.Models;

public class Post
{
    public Post()
    {
        this.Id = new Guid();
    }
    
    [Key]
    public Guid Id { get; init; }
    
    [Required]
    [MaxLength(TitleMaxLength)]
    public string Title { get; set; } = null!;
    
    [Required]
    [MaxLength(ContentMaxLength)]
    public string Content { get; set; } = null!;
}