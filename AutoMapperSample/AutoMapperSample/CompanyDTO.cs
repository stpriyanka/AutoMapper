using System;
// ReSharper disable InconsistentNaming

namespace AutoMapperSample
{
	public class CompanyDTO
	{

		public string CompanyName { get; set; }

		public string ContactPersonName { get; set; }

		public string ContactPersonEmail { get; set; }

		public string VAT { get; set; }

		public string CompanyAddress { get; set; }

		public bool HasMultipleBranch { get; set; }

		public DateTime CompanyCreatedAt { get; set; }

		public string CompanyWebsite { get; set; }

	}
}