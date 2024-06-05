using System;
using System.Collections.Generic;
using MegaCasting.DBLib.Class.Old;
using Microsoft.EntityFrameworkCore;

namespace MegaCasting.DBLib.Class;

public partial class MegaCastingContext : DbContext
{
    public MegaCastingContext()
    {
    }

    public MegaCastingContext(DbContextOptions<MegaCastingContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Artiste> Artistes { get; set; }


    public virtual DbSet<Contrat> Contrats { get; set; }

    public virtual DbSet<Diffuseur> Diffuseurs { get; set; }

    public virtual DbSet<Metier> Metiers { get; set; }

    public virtual DbSet<Partenaire> Partenaires { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=megacastingv2;user=root;password=;");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Artiste>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Artiste__3213E83FB64C43B9");

            entity.ToTable("Artiste");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.MetierId).HasColumnName("metier_id");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prenom");

            entity.HasOne(d => d.Metier).WithMany(p => p.Artistes)
                .HasForeignKey(d => d.MetierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Artiste__metier___440B1D61");
        });



        modelBuilder.Entity<Contrat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contrat__3213E83FAF720625");

            entity.ToTable("Contrat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateDebut)
                .HasColumnType("date")
                .HasColumnName("date_debut");
            entity.Property(e => e.DateFin)
                .HasColumnType("date")
                .HasColumnName("date_fin");
            entity.Property(e => e.LibelleContrat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libelle_contrat");
            entity.Property(e => e.PartenaireId).HasColumnName("partenaire_id");

            entity.HasOne(d => d.Partenaire).WithMany(p => p.Contrats)
                .HasForeignKey(d => d.PartenaireId)
                .HasConstraintName("FK__Contrat__partena__6C190EBB");
        });

        modelBuilder.Entity<Diffuseur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Diffuseu__3213E83F9C2FE2CA");

            entity.ToTable("Diffuseur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LibelleDiffuseur)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libelle_diffuseur");

            // Ajout de la propriété NoteDeMontage

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NoteDeMontage)
                .HasMaxLength(255) // Par exemple, définissez la longueur maximale de la note
                .IsUnicode(false) // Assurez-vous que la colonne n'accepte que des caractères Unicode
                .HasColumnName("note_de_montage");
        });

        modelBuilder.Entity<Metier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Metier__3213E83FA251D1C8");

            entity.ToTable("Metier");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LibelleMetier)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libelle_metier");
        });

        modelBuilder.Entity<Partenaire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Partenai__3213E83F607DDF63");

            entity.ToTable("Partenaire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LibellePartenaire)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libelle_partenaire");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
