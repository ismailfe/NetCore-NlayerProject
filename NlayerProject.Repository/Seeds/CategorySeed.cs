using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NlayerProject.Core.Models.ModuleCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerProject.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
                builder.HasData(
                new Category { Id = 1, Name = "Kalemlers" },
                new Category { Id = 2, Name = "Kitaplar" },
                new Category { Id = 3, Name = "Defter" });
        }
    }
}
