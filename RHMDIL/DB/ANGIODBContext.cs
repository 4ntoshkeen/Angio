using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RHMDIL.DB
{
    public partial class ANGIODBContext : DbContext
    {
        internal object OperationRoom1;

        public ANGIODBContext()
        {
        }

        public ANGIODBContext(DbContextOptions<ANGIODBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anesthesiologist> Anesthesiologists { get; set; }
        public virtual DbSet<AnesthesiologistNurse> AnesthesiologistNurses { get; set; }
        public virtual DbSet<Cardiologist> Cardiologists { get; set; }
        public virtual DbSet<Cleaner> Cleaners { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Laboratorian> Laboratorians { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        public virtual DbSet<OperationRoom1> OperationRoom1s { get; set; }
        public virtual DbSet<Surgeon> Surgeons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB; Database=ANGIODB; trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Anesthesiologist>(entity =>
            {
                entity.ToTable("Anesthesiologist");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AnesthesiologistNurse>(entity =>
            {
                entity.ToTable("AnesthesiologistNurse");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Cardiologist>(entity =>
            {
                entity.ToTable("Cardiologist");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Cleaner>(entity =>
            {
                entity.ToTable("Cleaner");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Laboratorian>(entity =>
            {
                entity.ToTable("Laboratorian");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Nurse>(entity =>
            {
                entity.ToTable("Nurse");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.ToTable("Operation");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.OperationName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<OperationRoom1>(entity =>
            {
                entity.ToTable("OperationRoom1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AnesthesiologistId).HasColumnName("AnesthesiologistID");

                entity.Property(e => e.AnesthesiologistNurseId).HasColumnName("AnesthesiologistNurseID");

                entity.Property(e => e.AssistantId).HasColumnName("AssistantID");

                entity.Property(e => e.CardiologistId).HasColumnName("CardiologistID");

                entity.Property(e => e.CleanerId).HasColumnName("CleanerID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.FluoTime).HasColumnType("time(5)");

                entity.Property(e => e.LaboratorianId).HasColumnName("LaboratorianID");

                entity.Property(e => e.NurseId).HasColumnName("NurseID");

                entity.Property(e => e.OperationDate).HasColumnType("date");

                entity.Property(e => e.OperationTimeFinish).HasColumnType("time(5)");

                entity.Property(e => e.OperationTimeStart).HasColumnType("time(5)");

                entity.Property(e => e.OperationTypeId).HasColumnName("OperationTypeID");

                entity.Property(e => e.PatientBirthday).HasColumnType("date");

                entity.Property(e => e.PatientFirstName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PatientLastName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PatientMiddleName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SurgeonId).HasColumnName("SurgeonID");

                entity.Property(e => e.ToolingNameId).HasColumnName("ToolingNameID");

                entity.Property(e => e.ToolingSizeId).HasColumnName("ToolingSizeID");

                entity.HasOne(d => d.Anesthesiologist)
                    .WithMany(p => p.OperationRoom1s)
                    .HasForeignKey(d => d.AnesthesiologistId)
                    .HasConstraintName("FK_OperationRoom1_Anesthesiologist");

                entity.HasOne(d => d.AnesthesiologistNurse)
                    .WithMany(p => p.OperationRoom1s)
                    .HasForeignKey(d => d.AnesthesiologistNurseId)
                    .HasConstraintName("FK_OperationRoom1_AnesthesiologistNurse");

                entity.HasOne(d => d.Assistant)
                    .WithMany(p => p.OperationRoom1Assistants)
                    .HasForeignKey(d => d.AssistantId)
                    .HasConstraintName("FK_OperationRoom1_Surgeon1");

                entity.HasOne(d => d.Cardiologist)
                    .WithMany(p => p.OperationRoom1s)
                    .HasForeignKey(d => d.CardiologistId)
                    .HasConstraintName("FK_OperationRoom1_Cardiologist");

                entity.HasOne(d => d.Cleaner)
                    .WithMany(p => p.OperationRoom1s)
                    .HasForeignKey(d => d.CleanerId)
                    .HasConstraintName("FK_OperationRoom1_Cleaner");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.OperationRoom1s)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_OperationRoom1_Department");

                entity.HasOne(d => d.Laboratorian)
                    .WithMany(p => p.OperationRoom1s)
                    .HasForeignKey(d => d.LaboratorianId)
                    .HasConstraintName("FK_OperationRoom1_Laboratorian");

                entity.HasOne(d => d.Nurse)
                    .WithMany(p => p.OperationRoom1s)
                    .HasForeignKey(d => d.NurseId)
                    .HasConstraintName("FK_OperationRoom1_Nurse");

                entity.HasOne(d => d.OperationType)
                    .WithMany(p => p.OperationRoom1s)
                    .HasForeignKey(d => d.OperationTypeId)
                    .HasConstraintName("FK_OperationRoom1_Operation");

                entity.HasOne(d => d.Surgeon)
                    .WithMany(p => p.OperationRoom1Surgeons)
                    .HasForeignKey(d => d.SurgeonId)
                    .HasConstraintName("FK_OperationRoom1_Surgeon");
            });

            modelBuilder.Entity<Surgeon>(entity =>
            {
                entity.ToTable("Surgeon");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
