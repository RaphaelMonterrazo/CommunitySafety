
using CommunitySafety.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommunitySafety.Infrastructure.EntitiesConfiguration;

public class CategoryConfiguration: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
        builder.HasData(
            new Category(1, "Agressão"),
            new Category(2, "Ameaça"),
            new Category(3, "Espancamento"),
            new Category(4, "Furto"), 
            new Category(5, "Intimidação"),
            new Category(6, "Outros"),
            new Category(7, "Perseguição"),
            new Category(8, "Roubo")
            );
    }
}
