using DemoUserAPI.Data;
using DemoUserAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoUserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly DemoUserAPIDbContext dbContext;

        public UserController(DemoUserAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Api GET end-point for featching all user's data
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await dbContext.Users.ToListAsync());
        }


        // Api POST end-point for submitting new user data
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUser addUser)
        {
            var uModel = new User()
            {
                Id = Guid.NewGuid(),
                Name = addUser.Name,
                Email = addUser.Email,
                Phone = addUser.Phone,
                Address = addUser.Address
            };

            await dbContext.Users.AddAsync(uModel);
            await dbContext.SaveChangesAsync();

            return Ok(uModel);
        }
    }
}
