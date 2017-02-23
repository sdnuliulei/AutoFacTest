using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

namespace AutoFac.Models
{
    public class MapperProfile:Profile
    {
        public override string ProfileName
        {
            get
            {
                return GetType().Name;
            }
        }

        protected override void Configure()
        {
            //Mapper.CreateMap<dynamic, BookDto>().ForMember(dest => dest.Address, src => src.MapFrom(c=>c.Address));
        }
    }
}
