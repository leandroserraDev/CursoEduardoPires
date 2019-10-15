using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Context.Maps
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("Produto");
            HasKey(x => x.ProdutoId);


            Property(x => x.Nome)
                .HasMaxLength(120)
                .HasColumnType("varchar")
                .IsRequired();


            Property(x => x.Valor)
                .HasColumnType("money")
                .IsRequired();

            HasRequired(x => x.cliente)
                .WithMany()
                .HasForeignKey(x => x.ClienteId);

        }
    }
}
