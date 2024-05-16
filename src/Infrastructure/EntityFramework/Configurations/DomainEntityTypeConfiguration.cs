namespace Infrastructure.EntityFramework.Configurations;

/// <summary>
///     Represents the entity type configuration for the <see cref="DomainEntity" /> class.
/// </summary>
public class DomainEntityTypeConfiguration : IEntityTypeConfiguration<DomainEntity>
{
    /// <summary>
    ///     Configures the entity type.
    /// </summary>
    /// <param name="builder">The entity type builder.</param>
    public void Configure(EntityTypeBuilder<DomainEntity> builder)
    {
        builder.Ignore(v => v.DomainEvents);
        builder.Property(v => v.Id).IsRequired();
        builder.Property(v => v.Created);
        builder.HasKey(v => v.Id);
        builder.ToTable("DomainEntity");

        builder.OwnsMany(
            p => p.Objects, a =>
            {
                a.WithOwner().HasForeignKey("OwnerId");
                a.Property<Guid>("Id");
                a.HasKey("Id");
            });
    }
}