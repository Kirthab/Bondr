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

                },
                new Genre
                {
                    Id = 3,
                    Name = "Fantasy",
                    Description = "Enter realms of magic and mythical creatures."
                },
                new Genre
                {
                    Id = 4,
                    Name = "Mystery",
                    Description = "Unravel intriguing puzzles and secrets."
                },
                new Genre
                {
                    Id = 5,
                    Name = "Adventure",
                    Description = "Embark on thrilling journeys and quests."
                },
                new Genre
                {
                    Id = 6,
                    Name = "Comedy",
                    Description = "Laugh out loud with humorous stories."
                },
                new Genre
                {
                    Id = 7,
                    Name = "Romance",
                    Description = "Experience tales of love and passion."
                },
                new Genre
                {
                    Id = 8,
                    Name = "Historical Fiction",
                    Description = "Travel through time with historically inspired stories."
                },
                new Genre
                {
                    Id = 9,
                    Name = "Horror",
                    Description = "Face your fears with spine-chilling narratives."
                },
                new Genre
                {
                    Id = 10,
                    Name = "Drama",
                    Description = "Explore complex human emotions and relationships."
                }
            );
        }
    }
}