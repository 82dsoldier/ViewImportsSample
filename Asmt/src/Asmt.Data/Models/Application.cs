using QuickFrame.Data.Models;
using System;

namespace Asmt.Data.Models {

	public class Application : DataModel {
		public string Name { get; set; } // Name (length: 512)
		public string Description { get; set; } // Description (length: 2048)
		public string Comments { get; set; } // Comments (length: 2048)
		public DateTime DateCreated { get; set; } // DateCreated
		public int? VendorId { get; set; } // VendorId
		public int? StatusId { get; set; } // StatusId
		public int? AppSourceId { get; set; } // AppSourceId
		public string CreatedById { get; set; } // CreatedById (length: 128)
		public int? OrganizationId { get; set; } // OrganizationId
		public int? GroupId { get; set; } // GroupId
		public int? DepartmentId { get; set; } // DepartmentId
		public bool IsMonitored { get; set; } // IsMonitored

		// Reverse navigation
		//public virtual ICollection<AppAttachmentLookup> AppAttachmentLookups { get; set; } // Many to many mapping

		//public virtual ICollection<AppCheckLog> AppCheckLogs { get; set; } // AppCheckLogs.FK_AppCheckLogs_Applications
		//public virtual ICollection<AppControlledDocLookup> AppControlledDocLookups { get; set; } // Many to many mapping
		//public virtual ICollection<AppDependency> AppDependencies { get; set; } // Many to many mapping
		//public virtual ICollection<Application> ApplicationId { get; set; } // Many to many mapping
		//public virtual ICollection<Application> Dependency { get; set; } // Many to many mapping
		//public virtual ICollection<AppOwnerLookup> AppOwnerLookups { get; set; } // Many to many mapping
		//public virtual ICollection<AppSmeLookup> AppSmeLookups { get; set; } // Many to many mapping
		//public virtual ICollection<AppUser> AppUsers { get; set; } // Many to many mapping
		//public virtual ICollection<AppVersion> AppVersions { get; set; } // AppVersions.FK_AppVersions_Applications
		//public virtual ICollection<Install> Installs { get; set; } // Installs.FK_Installs_Applications
		//public virtual ICollection<License> Licenses { get; set; } // Licenses.FK_Licenses_Applications
		//public virtual ICollection<MaintenancePlan> MaintenancePlans { get; set; } // MaintenancePlans.FK_MaintenancePlans_Applications
		//public virtual ICollection<SqaFormData> SqaFormDatas { get; set; } // SqaFormData.FK_SqaFormData_APplications

		//// Foreign keys
		//public virtual AppSource AppSource { get; set; } // FK_Applications_AppSources

		//public virtual Department Department { get; set; } // FK_Applications_Departments
		//public virtual Group Group { get; set; } // FK_Applications_Groups
		//public virtual Organization Organization { get; set; } // FK_Applications_Organizations
		//public virtual Sme Sme { get; set; } // FK_Applications_Smes
		//public virtual Status Status { get; set; } // FK_Applications_Statuses
		//public virtual Vendor Vendor { get; set; } // FK_Applications_Vendors
	}
}

// </auto-generated>