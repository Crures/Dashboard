using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace dashboard.context.Model
{
    public partial class DashboardContext : DbContext
    {
        public DashboardContext()
        {
        }

        public DashboardContext(DbContextOptions<DashboardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TestView> TestViews { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCalendarEvent> UserCalendarEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:projectdashboard.database.windows.net,1433;Database=project_dashboard; Persist Security Info=False;User ID=Projectroot;Password=R00t1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CalendarEvent>(entity =>
            {
                entity.Property(e => e.Couleur).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Permissions).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<TestView>(entity =>
            {
                entity.ToView("testView");

                entity.Property(e => e.Couleur).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Dashboard).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
