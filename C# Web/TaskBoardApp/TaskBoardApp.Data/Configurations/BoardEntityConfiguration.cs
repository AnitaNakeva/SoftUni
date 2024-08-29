using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskBoardApp.Data.Models;

namespace TaskBoardApp.Data.Configurations
{
    public class BoardEntityConfiguration : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.HasData(
                new Board { Id = 1, Name = "Open" },
                new Board { Id = 2, Name = "In Progress" },
                new Board { Id = 3, Name = "Done" }
            );
        }
    }
}