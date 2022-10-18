using AutoMapper;
using FeedBackForm.Dto;
using FeedBackForm.Models;

namespace FeedBackForm.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<Feedback, FeedBackDto>();
            CreateMap<FeedBackDto, Feedback>();
        ;
        }
    }
}
