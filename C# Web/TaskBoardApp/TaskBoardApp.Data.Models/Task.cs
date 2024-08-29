using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TaskBoardApp.Common;

namespace TaskBoardApp.Data.Models;

public class Task
{
    public Task()
    {
        this.Id = Guid.NewGuid();
    }
    
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(EntityValidationConstants.Task.TitleMaxLength)]
    public string Title { get; set; } = null!;
    
    [Required]
    [MaxLength(EntityValidationConstants.Task.DescriptionMaxLength)]
    public string Description { get; set; } = null!;
    
    public DateTime CreatedOn { get; set; }
    
    [ForeignKey(nameof(Board))]
    public int BoardId { get; set; }
    
    public virtual Board Board { get; set; }

    [ForeignKey(nameof(Owner))]
    [Required] public string OwnerId { get; set; } = null!;
    
    public virtual IdentityUser Owner { get; set; }

}