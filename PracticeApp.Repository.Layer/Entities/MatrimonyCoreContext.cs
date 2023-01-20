using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PracticeApp.Entity.Layer.Infrastructure.Interface;

namespace PracticeApp.Entity.Layer.Entities;

public partial class MatrimonyCoreContext : DbContext
{
    public MatrimonyCoreContext()
    {
    }

    public MatrimonyCoreContext(DbContextOptions<MatrimonyCoreContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.ToTable("AdminUser");

            entity.Property(e => e.AdminUserId)
                .ValueGeneratedNever()
                .HasColumnName("AdminUser_Id");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MasGender>(entity =>
        {
            entity.HasKey(e => e.GenderId);

            entity.ToTable("MAS_Gender");

            entity.Property(e => e.GenderId)
                .ValueGeneratedNever()
                .HasColumnName("Gender_Id");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.MasGenderCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAS_Gender_AdminUser");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.MasGenderUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK_MAS_Gender_AdminUser1");
        });

        modelBuilder.Entity<UsrProfile>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("USR_Profile");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("User_Id");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.UsrProfileCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USR_Profile_AdminUser");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.UsrProfileUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK_USR_Profile_AdminUser1");
        });

        modelBuilder.Entity<UsrSalt>(entity =>
        {
            entity.HasKey(e => e.SaltId);

            entity.ToTable("USR_Salt");

            entity.Property(e => e.SaltId)
                .ValueGeneratedNever()
                .HasColumnName("Salt_Id");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SaltKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
