using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace school_managenment_system.Models;

public partial class SchoolManagementDbContext : DbContext
{
    public SchoolManagementDbContext()
    {
    }

    public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AllocateClassroom> AllocateClassrooms { get; set; }

    public virtual DbSet<AllocateSubject> AllocateSubjects { get; set; }

    public virtual DbSet<Classroom> Classrooms { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AllocateClassroom>(entity =>
        {

            entity.ToTable("allocateClassrooms");

            entity.Property(e => e.AllocateClassroomId).HasColumnName("allocateClassroomID");
            entity.Property(e => e.ClassroomId).HasColumnName("classroomID");
            entity.Property(e => e.TeacherId).HasColumnName("teacherID");

        });

        modelBuilder.Entity<AllocateSubject>(entity =>
        {
            
            entity.ToTable("allocateSubjects");

            entity.Property(e => e.AllocateSubjectId).HasColumnName("allocateSubjectID");
            entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            entity.Property(e => e.TeacherId).HasColumnName("teacherId");

        
        });

        modelBuilder.Entity<Classroom>(entity =>
        {

            entity.ToTable("classroom");

            entity.Property(e => e.ClassroomId).HasColumnName("classroomID");
            entity.Property(e => e.ClassroomName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("classroomName");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__student__4D11D65CA67A2FC9");

            entity.ToTable("student");

            entity.Property(e => e.StudentId).HasColumnName("studentID");
            entity.Property(e => e.ClassroomId).HasColumnName("classroomID");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contactNo");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contactPerson");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("date")
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("emailAddress");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lastName");

        });

        modelBuilder.Entity<Subject>(entity =>
        {

            entity.ToTable("subject");

            entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subjectName");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
         

            entity.ToTable("teacher");

            entity.Property(e => e.TeacherId).HasColumnName("teacherID");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contactNo");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("emailAddress");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lastName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
