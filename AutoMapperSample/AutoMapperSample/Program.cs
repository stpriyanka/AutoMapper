using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperSample
{
	class Program
	{
		private static CompanyDTO dto;

		static void Main(string[] args)
		{
			var dataContainer = TestIfMappingWorks(dto);
			var logic = new BusinessLogic(dataContainer);

			//create desired entity object that should contain data after mapping
			CompanyDM output = logic.MapData();

			//Checking if data has been mapped properly
			Console.WriteLine(output.CompanyName);

		}


		public static CompanyDTO TestIfMappingWorks(CompanyDTO companyDto)
		{
			companyDto = new CompanyDTO()
			{
				CompanyAddress = "Stockholm,Sweden",
				CompanyCreatedAt = DateTime.UtcNow.Date,
				CompanyName = "Test Company",
				CompanyWebsite = "www.testcompany.com",
				ContactPersonEmail = "contactperson@testcompany.com",
				ContactPersonName = "Company Contact Name",
				HasMultipleBranch = false,
				VAT = "12345678",
			};

			return companyDto;
		}
	}
}
