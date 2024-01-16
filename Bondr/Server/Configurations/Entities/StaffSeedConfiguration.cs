using Bondr.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bondr.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    Name = "Anita Max Wynn",
                    Gender = "Female",
                    Email = "anitamaxwynn@hotmail.com",
                    Password = "champagnepapi21",
                    Salary = 5500.00,
                    Position = "CEO" 

                },
                new Staff
                {
                    Id = 2,
                    Name = "Aethelheimarl Hilmard",
                    Gender = "Male",
                    Email = "aethelh@hotmail.com",
                    Password = "meadowviking16",
                    Salary = 4500.00,
                    Position = "Back-End Engineer"
                }
            );
        }
    }
}