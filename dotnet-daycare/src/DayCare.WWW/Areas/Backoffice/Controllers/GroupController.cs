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

namespace  DayCare.WWW.Areas.Backoffice.Controllers 
{
    [Area("Backoffice")]
    public class GroupController : BaseController 
    {
        public GroupController(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
        }

        public async Task<IActionResult> Index() 
        {
            var model = await ApplicationDbContext.Groups.OrderBy(o => o.Name).ToListAsync();

            return View(model);
        }
    }
}