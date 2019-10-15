using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Context.Maps
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(x => x.ClienteId);

            Property(x => x.Nome)
                .HasMaxLength(120)
                .HasColumnType("varchar")
                .IsRequired();


            Property(x => x.Sobrenome)
                .HasMaxLength(120)
                .HasColumnType("varchar")
                .IsRequired();


            Property(x => x.Email)
                .HasMaxLength(120)
                .HasColumnType("varchar")
                .IsRequired();

        

        }
    }
}
