using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatiangApp.Data;
using DatiangApp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatiangApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _Context;
        public UsersController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task< ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _Context.Users.ToListAsync();
           
        }

        [HttpGet("{id}")]
        public async Task< ActionResult<AppUser>> GetUser(int id)
        {
          return await _Context.Users.FindAsync(id);
            
        }

    }
}
