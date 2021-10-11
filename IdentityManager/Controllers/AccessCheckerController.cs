using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Controllers
{
    [Authorize]
    public class AccessCheckerController : Controller
    {
        [AllowAnonymous]
        public IActionResult AllAccess()
        {
            return View();
        }

        [Authorize]
        public IActionResult AuthorizedAccess()
        {
            return View();
        }
        [Authorize(Roles ="User")]
        public IActionResult UserAccess()
        {
            return View();
        }
        [Authorize(Roles = "User,Admin")]
        public IActionResult UserOrAdminAccess()
        {
            return View();
        }

        [Authorize(Policy = "UserAndAdmin")]
        public IActionResult UserAndAdminAccess()
        {
            return View();
        }
        [Authorize(Policy = "Admin")]
        public IActionResult AdminAccess()
        {
            return View();
        }
        [Authorize(Policy = "Admin_CreateAccess")]
        public IActionResult Admin_CreateAccess()
        {
            return View();
        }
        [Authorize(Policy = "Admin_Create_Edit_DeleteAccess")]

        public IActionResult Admin_Create_Edit_DeleteAccess()
        {
            return View();
        }
        [Authorize(Policy = "Admin_Create_Edit_DeleteAccess_SuperAdmin")]

        public IActionResult Admin_Create_Edit_DeleteAccess_SuperAdmin()
        {
            return View();
        }
        [Authorize(Policy = "AdminWithMoreThan1000Days")]
        public IActionResult OnlyMuro()
        {
            return View();
        }

        [Authorize(Policy = "FirstNameAuth")]
        public IActionResult FirstNameAuth()
        {
            return View();
        }
    }
}
