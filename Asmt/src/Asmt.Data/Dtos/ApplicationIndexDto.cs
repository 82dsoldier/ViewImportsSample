using Asmt.Data.Models;
using ExpressMapper;
using QuickFrame.Data.Dtos;
using System;
using System.ComponentModel.DataAnnotations;

namespace Asmt.Data.Dtos {

	public class ApplicationIndexDto : DataTransferObject<Application, ApplicationIndexDto> {
		public string Name { get; set; }

		[Display(Name = "Version Number")]
		public string VersionNumber { get; set; }

		[Display(Name = "Primary Owner")]
		public string PrimaryOwner { get; set; }

		public string PrimaryOwnerId { get; set; }

		[Display(Name = "Primary SME")]
		public string PrimarySme { get; set; }

		public string PrimarySmeId { get; set; }
		public string Status { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Last Checked")]
		public DateTime LastCheckedDate { get; set; }

		public override void Register() {
			Mapper.Register<Application, ApplicationIndexDto>();
			//.Function(dest => dest.VersionNumber, src => {
			//	return src.AppVersions.OrderByDescending(app => app.InstallDate).FirstOrDefault()?.VersionNumber;
			//})
			//.Function(dest => dest.PrimaryOwner, src => {
			//	return src.AppOwnerLookups.FirstOrDefault(l => l.Priority == 1)?.AppOwner.DisplayName;
			//})
			//.Function(dest => dest.PrimaryOwnerId, src => {
			//	return src.AppOwnerLookups.FirstOrDefault(l => l.Priority == 1)?.AppOwner.UserId;
			//})
			//.Function(dest => dest.PrimarySme, src => {
			//	return src.AppSmeLookups.FirstOrDefault(l => l.Priority == 1)?.Sme.DisplayName;
			//})
			//.Function(dest => dest.PrimarySmeId, src => {
			//	return src.AppSmeLookups.FirstOrDefault(l => l.Priority == 1)?.Sme.UserId;
			//})
			//.Function(dest => dest.Status, src => {
			//	return src.Status.Name;
			//})
			//.Function(dest => dest.LastCheckedDate, src => {
			//	return src.AppCheckLogs.OrderByDescending(l => l.DateChecked).FirstOrDefault()?.DateChecked;
			//});
		}
	}
}