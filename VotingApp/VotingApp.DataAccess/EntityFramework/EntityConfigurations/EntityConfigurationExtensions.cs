using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.EntityConfigurations;
public static class EntityConfigurationExtensions {
    public static EntityTypeBuilder<TEntity> SetId<TEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : Entity {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Id).IsUnique();

        builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired(true);
        return builder;
    }

    public static EntityTypeBuilder<TEntity> SetColumn<TEntity>(this EntityTypeBuilder<TEntity> builder,
                                                                Expression<Func<TEntity, string>> propertyExpression,
                                                                String columnType) where TEntity : Entity {

        builder.Property(propertyExpression)
            .HasColumnName(propertyExpression.Name)
            .HasColumnType(columnType);

        return builder;
    }
}