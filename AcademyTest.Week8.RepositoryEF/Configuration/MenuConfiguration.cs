
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
    internal class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        

        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");
            builder.HasKey(m => m.CodiceMenu);
            builder.Property(m => m.NomeMenu).IsRequired();



            //relazione 1 a n con studente
            builder.HasMany(m => m.Piatti).WithOne(m => m.Menu).HasForeignKey(p => p.CodiceMenu);
        }
    }

   

}
