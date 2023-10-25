using CleanBookShelf.Domain.Entites.BookAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanBookShelf.Infrastructure.EFCore.configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Title).IsRequired();
        builder.Property(b => b.Author).IsRequired();
        // varsa diğer entity özellikleri ve ilişkileri burada konfigure edilebilir
    }
}
