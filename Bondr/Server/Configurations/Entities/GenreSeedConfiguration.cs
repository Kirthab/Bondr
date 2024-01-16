using Bondr.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bondr.Server.Configurations.Entities
{
    public class GenreSeedConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Gaming",
                    Description = "For Gamers. By Gamers."

                },
                new Genre
                {
                    Id = 2,
                    Name = "Cooking",
                    Description = "For Chefs. By Chefs."

                }
            );
        }
    }
}