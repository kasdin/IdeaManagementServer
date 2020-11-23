using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IdeaManagementServer
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Customers> tbl_customers { get; set; }
        public virtual DbSet<Ideas> tbl_ideas { get; set; }
        public virtual DbSet<UserAccounts> tbl_userAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .Property(e => e.fld_name)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.fld_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.fld_phoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.fld_url)
                .IsUnicode(false);

            modelBuilder.Entity<Ideas>()
                .Property(e => e.fld_title)
                .IsUnicode(false);

            modelBuilder.Entity<Ideas>()
                .Property(e => e.fld_description)
                .IsUnicode(false);

            modelBuilder.Entity<Ideas>()
                .Property(e => e.fld_fileURL)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccounts>()
                .Property(e => e.fld_username)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccounts>()
                .Property(e => e.fld_password)
                .IsUnicode(false);
        }
    }
}
