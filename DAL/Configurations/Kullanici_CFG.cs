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
    public class Kullanici_CFG : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.Property(x => x.KullaniciAdSoyad).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.KullaniciAdi).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Sifre).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            
        }
    }
}
