using AutoMapper;
using PaycardEditor.Applications.Dtos;
using PaycardEditor.Domain.Entities;

namespace PaycardEditor.Applications.Configuration.Mappings;

public class PaycardMappingProfile : Profile
{
    public PaycardMappingProfile()
    {
        CreateMap<Paycard, PaycardDto>();
    }
}
