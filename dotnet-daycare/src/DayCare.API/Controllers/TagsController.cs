using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DayCare.Db;
using DayCare.Models;
using DayCare.Models.Security;

namespace DayCare.API.Controllers
{
    [Route("api/[controller]")]
     public class TagsController : BaseController {
        public TagsController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager):base(applicationDbContext, userManager) {
        }

        [HttpGet("{tagId:int}", Name = "GetTagsbyId")]
        public async Task<IActionResult> GetTagsbyId(Int32 tagId)
        {
            var model = await ApplicationDbContext.Tags.FirstOrDefaultAsync(t => t.Id == tagId);
            if (model == null)
            {
                var msg = String.Format("Failed to get tags from the API");
                return NotFound(msg);
            }
            return new OkObjectResult(model);
        }
    }
}
