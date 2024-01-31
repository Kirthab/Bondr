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
                    Salary = 20500.00,
                    Age = 58,
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
                    Age = 25,
                    Position = "Back-End Engineer"
                },
                new Staff
                {
                    Id = 3,
                    Name = "Illia Dyr",
                    Gender = "Female",
                    Email = "dyrmater@hotmail.com",
                    Password = "dyrmaterillia",
                    Salary = 2500.00,
                    Age = 20,
                    Position = "Media Manager"
                }
            );
        }
    }
}