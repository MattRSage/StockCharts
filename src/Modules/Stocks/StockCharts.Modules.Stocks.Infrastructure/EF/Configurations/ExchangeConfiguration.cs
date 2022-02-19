using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockCharts.Modules.Stocks.Core.Exchanges.Entities;
using StockCharts.Modules.Stocks.Core.Exchanges.Types;

namespace StockCharts.Modules.Stocks.Infrastructure.EF.Configurations;

internal class ExchangeConfiguration : IEntityTypeConfiguration<Exchange>
{
    public void Configure(EntityTypeBuilder<Exchange> builder)
    {
        // builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, x => new ExchangeId(x));

        builder.HasIndex(x => x.Symbol).IsUnique();
        builder.Property(x => x.Symbol).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Name).IsRequired();
    }
}