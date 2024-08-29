using System.ComponentModel.DataAnnotations;
using TaskBoardApp.Common;

namespace TaskBoardApp.Data.Models;

public class Board
{
    public Board()
    {
        this.Tasks = new HashSet<Task>();
    }
    
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(EntityValidationConstants.Board.NameMaxLength)]
    public string Name { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = null!;
}