
namespace RM.API.Profile
{
    public class QuotationProfile : AutoMapper.Profile
    {

        public QuotationProfile()
        {
            CreateMap<Entities.Quotation, Models.QuotationDto>();
        }

    }
}
