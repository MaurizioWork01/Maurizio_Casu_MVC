using AcademyTest.Week8.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTest.Week8.RepositoryEF.Configuration
{
    internal class PiattoConfiguration : IEntityTypeConfiguration<Piatto>
    {
        public void Configure(EntityTypeBuilder<Piatto> builder)
        {
            builder.ToTable("Piatti");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Descrizione).IsRequired();
            builder.Property(p => p.Tipologia).IsRequired();



            //relazione 1 a n con menu
            builder.HasOne(p => p.Menu).WithMany(p => p.Piatti).HasForeignKey(p => p.CodiceMenu);
        }


    }
}
