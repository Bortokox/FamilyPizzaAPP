using AutoMapper;
using PizzaAPI.DTOS;
using PizzaAPI.Models;

namespace PizzaAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PizzaModel, PizzaOverwiewDto>();
            CreateMap<PizzaModel, PizzaDescriptionDto>().ReverseMap();
            CreateMap<SuggestedPizzaModel, SuggestedPizzasDto>();
        }
    }
}