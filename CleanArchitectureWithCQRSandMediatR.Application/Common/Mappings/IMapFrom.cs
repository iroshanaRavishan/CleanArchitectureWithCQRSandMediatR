using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Common.Mappings
{
    public interface IMapFrom<T> // Generic interface
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType()); // creating mapping declaration
    }
}
