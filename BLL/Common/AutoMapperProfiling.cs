using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Client.Models;
using Udemy.Areas.Client.Models;

namespace BLL.Client.Models
{
    public class AutoMapperProfiling : Profile
    {
        public AutoMapperProfiling()
        {
            CreateMap<Sample, SampleDTO>().ReverseMap();
        }
    }
}