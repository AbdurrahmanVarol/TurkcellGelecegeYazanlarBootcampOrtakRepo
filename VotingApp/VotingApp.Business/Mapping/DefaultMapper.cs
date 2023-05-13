using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.Entities;

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
        }
    }
}
