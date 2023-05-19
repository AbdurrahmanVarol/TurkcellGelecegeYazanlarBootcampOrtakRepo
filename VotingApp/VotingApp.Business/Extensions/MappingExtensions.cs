using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Business.Extensions
{
    public static class MappingExtensions
    {
        public static TResponse MapTo<TResource, TResponse>(this TResource value, IMapper mapper)
            where TResource : IMappable
            where TResponse : IMappable
        {
            try
            {
                var result = mapper.Map<TResponse>(value);
                return result;
            }
            catch (AutoMapperMappingException exception)
            {
                throw new ArgumentException(nameof(value),exception);
            }            
        }
    }
}