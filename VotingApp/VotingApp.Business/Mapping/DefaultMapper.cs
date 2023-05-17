using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.Entities;
using VotingApp.Entities.ComplexTypes;

namespace VotingApp.Business.Mapping
{
    public class DefaultMapper : Profile
    {
        public DefaultMapper()
        {
            CreateMap<Vote, CreateVoteRequest>().ReverseMap();
            CreateMap<Vote, UpdateVoteRequest>().ReverseMap();
            CreateMap<Vote, VoteResponse>().ReverseMap();

            CreateMap<User, UserResponse>().ReverseMap();

            CreateMap<Poll, PollResponse>().ReverseMap();
            CreateMap<PollDetail,PollDetailResponse>()
                .ForMember(p=>p.Id,q=>q.MapFrom(p=>p.Poll.Id))
                .ForMember(p=>p.Title,q=>q.MapFrom(p=>p.Poll.Title))
                .ForMember(p=>p.Description,q=>q.MapFrom(p=>p.Poll.Description))
                .ForMember(p=>p.CreatedAt,q=>q.MapFrom(p=>p.Poll.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss")))
                .ReverseMap();

            CreateMap<Poll, ActivePollResponse>();
            CreateMap<Option, ActivePollOption>();
        }
    }
}
