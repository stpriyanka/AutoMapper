using AutoMapper;

namespace AutoMapperSample
{
	public class BusinessLogic
	{
		public CompanyDTO CompanyDto { get; set; }
		//public CompanyDM CompanyDm { get; set; }

		public BusinessLogic(CompanyDTO dto)
		{
			CompanyDto = dto;
			//CompanyDm = dm;
		}


		public CompanyDM MapData()
		{
			//instead the codes commented below
			//CompanyDm.CompanyName = CompanyDto.CompanyName;
			//CompanyDm.CompanyAddress = CompanyDto.CompanyAddress;
			//CompanyDm.ContactPersonName = CompanyDto.ContactPersonName;
			//CompanyDm.ContactPersonEmail = CompanyDto.ContactPersonEmail;
			//CompanyDm.CompanyCreatedAt = CompanyDto.CompanyCreatedAt;
			//CompanyDm.HasMultipleBranch = CompanyDto.HasMultipleBranch;
			//CompanyDm.VAT = CompanyDto.VAT;

			//using automapper to map all the properties between sour and destination
			var config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<CompanyDTO, CompanyDM>()
				//Manual mapp one property as it is called differently 
				.ForMember(dst => dst.URL, opt => opt.MapFrom(src => src.CompanyWebsite));

			});
			var mapper = config.CreateMapper();
			CompanyDM dataContainer = mapper.Map<CompanyDM>(CompanyDto);


			return dataContainer;
		}

	}
}