using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class CSGuideContext : DbContext
    {
        public CSGuideContext(DbContextOptions<CSGuideContext> options) : base(options)
        {
        }

        public DbSet<Arma> Armas { get; set; }
        public DbSet<Mapa> Mapas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arma>(entity =>
            {
                entity.ToTable("tbl_armas");

                entity.HasKey(a => a.Id_arma)
                      .HasName("pk_arma");

                entity.Property(a => a.Id_arma)
                      .HasColumnName("id_arma");

                entity.Property(a => a.Nome_arma)
                      .HasColumnName("nome_arma")
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(a => a.Tipo)
                      .HasColumnName("tipo")
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(a => a.Dano)
                      .HasColumnName("dano")
                      .IsRequired();

                entity.Property(a => a.Precisao)
                        .HasColumnName("precisao")
                        .IsRequired();

                entity.Property(a => a.Cadencia)
                        .HasColumnName("cadencia")
                        .IsRequired();

                entity.Property(a => a.Preco)
                      .HasColumnName("preco")
                      .IsRequired();

                entity.Property(a => a.Descricao)
                      .HasColumnName("descricao")
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(a => a.Imagem_arma)
                      .HasColumnName("imagem_arma")
                      .HasMaxLength(200)
                      .IsRequired();
            });

            modelBuilder.Entity<Mapa>(entity =>
            {
                entity.ToTable("tbl_mapas");

                entity.HasKey(m => m.Id_mapa)
                      .HasName("pk_mapa");

                entity.Property(m => m.Id_mapa)
                      .HasColumnName("id_mapa");

                entity.Property(m => m.Nome_mapa)
                      .HasColumnName("nome_mapa")
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(m => m.Localizacao)
                      .HasColumnName("localizacao")
                      .HasMaxLength(15)
                      .IsRequired();

                entity.Property(m => m.Tamanho)
                        .HasColumnName("tamanho")
                        .HasMaxLength(10)
                        .IsRequired();

                entity.Property(m => m.Layout)
                        .HasColumnName("layout")
                        .HasMaxLength(15)
                        .IsRequired();

                entity.Property(m => m.Lado_favorito)
                        .HasColumnName("lado_favorito")
                        .HasMaxLength(15)
                        .IsRequired();

                entity.Property(m => m.Descricao)
                      .HasColumnName("descricao")
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(m => m.Imagem_mapa)
                      .HasColumnName("imagem_mapa")
                      .HasMaxLength(200)
                      .IsRequired();
            });
        }
    }
}
