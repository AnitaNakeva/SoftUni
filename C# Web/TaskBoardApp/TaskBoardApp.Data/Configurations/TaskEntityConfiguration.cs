using System.Collections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = TaskBoardApp.Data.Models.Task;
namespace TaskBoardApp.Data.Configurations;

public class TaskEntityConfiguration : IEntityTypeConfiguration<Task>
{
    public void Configure(EntityTypeBuilder<Task> builder)
    {
        builder
            .HasOne(t => t.Board)
            .WithMany(b => b.Tasks)
            .HasForeignKey(t => t.BoardId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasData(this.GenerateTasks());
    }

    private ICollection<Task> GenerateTasks()
    {
        ICollection<Task> tasks = new HashSet<Task>()
        {
            new Task()
            {
                Title = "Improve CSS styles",
                Description = "LJNDonfn fnerorn fren ffrr ntonto.",
                CreatedOn = DateTime.UtcNow.AddDays(-200),
                OwnerId = "a0fe5445-0c5a-4363-9ed6-55a38fe009f6",
                BoardId = 1
            },
            new Task()
            {
                Title = "Improve CSS styles 2",
                Description = "LJNDonfn fnerorn fren ffrr ntonto.",
                CreatedOn = DateTime.UtcNow.AddDays(-200),
                OwnerId = "b7488d11-9c04-4924-bd06-055dca1ad7cd",
                BoardId = 2
            },
            new Task()
            {
                Title = "Improve CSS styles 3",
                Description = "LJNDonfn fnerorn fren ffrr ntonto.",
                CreatedOn = DateTime.UtcNow.AddDays(-200),
                OwnerId = "d9f382f0-9670-49fd-ae1c-1bc074a28d93",
                BoardId = 3
            }
        };

        return tasks;
    }
}