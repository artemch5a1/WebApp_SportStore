
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportStorage.DataAccess.Entites;
using SportStore.Core.Models;

namespace SportStorage.DataAccess.Configurations
{
    public class SportsItemConfiguration : IEntityTypeConfiguration<SportsItemEntity>
    {
        public void Configure(EntityTypeBuilder<SportsItemEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasMaxLength(SportsItem.MAX_TITLE_LENGTH)
                .IsRequired();

            builder.Property(x => x.Description)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();
        }
    }
}
