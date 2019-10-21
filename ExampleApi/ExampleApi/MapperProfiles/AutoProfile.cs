using AutoMapper;
using Core.BussisnessObjects;
using ExampleApi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleApi.MapperProfiles
{
    public class AutoProfile : Profile
    {
        public AutoProfile()
        {
            CreateMap<Auto, AutoViewModel>();
            CreateMap<AutoViewModel, Auto>();
        }
    }
}