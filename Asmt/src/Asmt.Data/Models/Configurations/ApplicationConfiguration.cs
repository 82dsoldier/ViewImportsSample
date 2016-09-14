using System.Data.Entity.ModelConfiguration;

namespace Asmt.Data.Models.Configurations {

	public class ApplicationConfiguration : EntityTypeConfiguration<Application> {

		public ApplicationConfiguration() {
			HasKey(x => x.Id);

			Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
			Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(512);
			Property(x => x.Description).HasColumnName(@"Description").IsOptional().HasColumnType("nvarchar").HasMaxLength(2048);
			Property(x => x.Comments).HasColumnName(@"Comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(2048);
			Property(x => x.DateCreated).HasColumnName(@"DateCreated").IsRequired().HasColumnType("datetime");
			Property(x => x.VendorId).HasColumnName(@"VendorId").IsOptional().HasColumnType("int");
			Property(x => x.StatusId).HasColumnName(@"StatusId").IsOptional().HasColumnType("int");
			Property(x => x.AppSourceId).HasColumnName(@"AppSourceId").IsOptional().HasColumnType("int");
			Property(x => x.CreatedById).HasColumnName(@"CreatedById").IsRequired().HasColumnType("nvarchar").HasMaxLength(128);
			Property(x => x.OrganizationId).HasColumnName(@"OrganizationId").IsOptional().HasColumnType("int");
			Property(x => x.GroupId).HasColumnName(@"GroupId").IsOptional().HasColumnType("int");
			Property(x => x.DepartmentId).HasColumnName(@"DepartmentId").IsOptional().HasColumnType("int");
			Property(x => x.IsMonitored).HasColumnName(@"IsMonitored").IsRequired().HasColumnType("bit");
			Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").IsRequired().HasColumnType("bit");

			// Foreign keys
			//HasOptional(a => a.AppSource).WithMany(b => b.Applications).HasForeignKey(c => c.AppSourceId).WillCascadeOnDelete(false); // FK_Applications_AppSources
			//HasOptional(a => a.Department).WithMany(b => b.Applications).HasForeignKey(c => c.DepartmentId).WillCascadeOnDelete(false); // FK_Applications_Departments
			//HasOptional(a => a.Group).WithMany(b => b.Applications).HasForeignKey(c => c.GroupId).WillCascadeOnDelete(false); // FK_Applications_Groups
			//HasOptional(a => a.Organization).WithMany(b => b.Applications).HasForeignKey(c => c.OrganizationId).WillCascadeOnDelete(false); // FK_Applications_Organizations
			//HasOptional(a => a.Status).WithMany(b => b.Applications).HasForeignKey(c => c.StatusId).WillCascadeOnDelete(false); // FK_Applications_Statuses
			//HasOptional(a => a.Vendor).WithMany(b => b.Applications).HasForeignKey(c => c.VendorId).WillCascadeOnDelete(false); // FK_Applications_Vendors
			//HasRequired(a => a.Sme).WithMany(b => b.Applications).HasForeignKey(c => c.CreatedById).WillCascadeOnDelete(false); // FK_Applications_Smes
			//HasMany(t => t.AppDependencies).WithMany(t => t.Applications).Map(m =>
			//{
			//    m.ToTable("AppDependencyLookups", "dbo");
			//    m.MapLeftKey("ApplicationId");
			//    m.MapRightKey("DependencyId");
			//});
			//HasMany(t => t.Dependency).WithMany(t => t.ApplicationId).Map(m =>
			//{
			//    m.ToTable("AppAppDependencyLookups", "dbo");
			//    m.MapLeftKey("ApplicationId");
			//    m.MapRightKey("DependencyId");
			//});
			//HasMany(t => t.AppUsers).WithMany(t => t.Applications).Map(m =>
			//{
			//    m.ToTable("AppUserLookups", "dbo");
			//    m.MapLeftKey("ApplicationId");
			//    m.MapRightKey("UserId");
			//});
		}
	}
}

// </auto-generated>