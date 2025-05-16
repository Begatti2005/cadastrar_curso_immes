using ImmesAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImmesAPI.Data.Configurations
{
    public class CursoConfiguration :
        IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            //FluentAPI - Recurso utilizado para aplicar as
            //configurações na base de dados

            builder.HasKey(p => p.Id);  //Primary Key

            builder.Property(p => p.Nome)
                .HasMaxLength(30)  //varchar(30)
                .IsRequired();     //Obrigatório
                //.IsRequired(false);   //Não Obrigatório

            builder.Property(p => p.Periodo)
                .IsRequired();

            builder.ToTable("TAB_Curso");
        }
    }
}
