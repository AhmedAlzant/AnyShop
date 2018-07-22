using System.Collections.Generic;
using System.Threading.Tasks;
using Any_Shop.Models;
using Any_Shop.Presistance;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Controllers.Resources;

namespace Any_Shop.Controllers {
    public class MakesController : Controller {
        private readonly ShopDbContext context;
        private readonly IMapper mapper;

        public MakesController (ShopDbContext context,IMapper mapper) {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet ("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes () {
            var makes= await context.Makes.Include(m=>m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}