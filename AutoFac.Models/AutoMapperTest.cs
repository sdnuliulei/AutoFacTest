using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

namespace AutoFac.Models
{
    public static class AutoMapperTest
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Configure()
        {
            Mapper.Initialize(i => i.AddProfile<MapperProfile>());
            Mapper.AssertConfigurationIsValid();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static BookDto ToBookDto()
        {
            Address address = new Address { Province="山东", City="济南", County="历下区" };
            dynamic book = new { Title = "巨流河", Address = address };
            return Mapper.DynamicMap<BookDto>(book);
        }
    }
}
