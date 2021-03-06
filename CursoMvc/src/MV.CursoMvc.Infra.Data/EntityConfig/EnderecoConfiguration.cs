﻿using System.Data.Entity.ModelConfiguration;
using MV.CursoMvc.Domain.Entities;

namespace MV.CursoMvc.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(8);

            Property(e => e.Complemento)
                .HasMaxLength(100);

            HasRequired(e => e.Cliente) //hasOptional qdo não é obrigatorio
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.ClienteId); //relacionamento de 1 pra N

            ToTable("Enderecos");
        }
    }
}