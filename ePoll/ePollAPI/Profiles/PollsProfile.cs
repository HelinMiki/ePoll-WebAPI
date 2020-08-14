using AutoMapper;
using ePollAPI.DTOs;
using ePollAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePollAPI.Profiles
{
    public class PollsProfile : Profile
    {
        public PollsProfile()
        {
            CreateMap<Poll, PollDto>();
            CreateMap<Poll, PollDetailDto>();
            CreateMap<PollCreateDto, Poll>();
        }
    }
}
