using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace DAL.Configurations
{
    public class Album_CFG : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.Property(x=>x.AlbumAdi).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x=>x.AlbumunSanatcisi_Grubu).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x=>x.AlbumCikisTarihi).HasColumnType("datetime2").IsRequired();
            builder.Property(x=>x.AlbumFiyati).HasColumnType("money").IsRequired();
            builder.Property(x=>x.IndirimOrani).HasColumnType("decimal").IsRequired();
            builder.Property(x=>x.SatisDevamEdiyorMu).IsRequired();
            builder.Property(x=>x.EklenmeTarihi).HasColumnType("datetime2").IsRequired();
        }
    }
}
