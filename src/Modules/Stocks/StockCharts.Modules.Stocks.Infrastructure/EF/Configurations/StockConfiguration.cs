using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockCharts.Modules.Stocks.Core.Exchanges.Entities;
using StockCharts.Modules.Stocks.Core.Exchanges.Types;
using StockCharts.Modules.Stocks.Core.Stocks.Entities;
using StockCharts.Modules.Stocks.Core.Stocks.Types;

namespace StockCharts.Modules.Stocks.Infrastructure.EF.Configurations;

internal class StockConfiguration : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, x => new StockId(x));
        
        builder.Property(x => x.Version).IsConcurrencyToken();
        builder.Ignore(x => x.Events);
        
        builder.HasOne<Exchange>().WithMany().HasForeignKey(x => x.ExchangeId);
        
        builder.Property(x => x.ExchangeId)
            .IsRequired()
            .HasConversion(x => x.Value, x => new ExchangeId(x));
        
        builder.HasIndex(x => x.Symbol).IsUnique();
        builder.Property(x => x.Symbol).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Name).IsRequired();
    }
}