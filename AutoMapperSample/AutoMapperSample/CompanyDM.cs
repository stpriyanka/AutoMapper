using System;
// ReSharper disable InconsistentNaming

namespace AutoMapperSample
{
	public class CompanyDM
	{
		public int ID { get; set; }

		public string CompanyName { get; set; }

		public string ContactPersonName { get; set; }

		public string ContactPersonEmail { get; set; }

		public string VAT { get; set; }

		public string CompanyAddress { get; set; }


		public bool HasMultipleBranch { get; set; }

		public bool PaidCustomer { get; set; }

		public DateTime CompanyCreatedAt { get; set; }

		public string URL { get; set; }

	}
}