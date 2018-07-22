using Any_Shop.Models;
using AutoMapper;
using Shop.Controllers.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Mapping
{
    public class MappingProfile:Profile
    {
    public MappingProfile()
    {
        CreateMap<Make, MakeResource>();
        CreateMap<Model, ModelResource>();

    }
    }
}
