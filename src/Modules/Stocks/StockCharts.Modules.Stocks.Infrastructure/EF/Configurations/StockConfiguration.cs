using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockCharts.Modules.Stocks.Core.Stocks.Entities;

namespace StockCharts.Modules.Stocks.Infrastructure.EF.Configurations;

internal class StockConfiguration : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        builder.HasIndex(x => x.Symbol).IsUnique();
        builder.Property(x => x.Symbol).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Name).IsRequired();
    }
}