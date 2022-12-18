using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ProductApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }

        public async Task<IActionResult> AddRoleToUsers(string id)
        {
            var user = await _userManager.FindByNameAsync(id);
            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.RoleList = roles;
            ViewBag.Roles = new SelectList(roles, "Id", "Name");
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddRoleToUsers(string userName, string role)
        {
            var selectedRole = await _roleManager.FindByIdAsync(role);
            var selectedUser = await _userManager.FindByNameAsync(userName);

            var flag = await _userManager.IsInRoleAsync(selectedUser, selectedRole.Name);

            if(flag)
            {
                var flasg = await _userManager.RemoveFromRoleAsync(selectedUser, selectedRole.Name);
                return RedirectToAction("Index");
            }

            if (selectedRole is not null && selectedUser is not null)
            {
                
                var result = await _userManager.AddToRoleAsync(selectedUser, selectedRole.Name);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return RedirectToAction("Index");
        }
    }
}
