using System.Diagnostics;
using LanchesMac.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LanchesMac.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _singnInManager;

    public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> singnInManager)
    {
        _userManager = userManager;
        _singnInManager = singnInManager;
    }

    public IActionResult Login(string returnUrl)
    {
        return View(new LoginViewModel
        {
            ReturnUrl = returnUrl
        });
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel loginVM)
    {
        if (!ModelState.IsValid)
            return View(loginVM);
        var user = await _userManager.FindByNameAsync(loginVM.UserName);
        if (user != null)
        {
            var result = await _singnInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

            if (result.Succeeded)
            {
                if (string.IsNullOrEmpty(loginVM.ReturnUrl))
                {
                    return RedirectToAction("Index", "Home");
                }
                return Redirect(loginVM.ReturnUrl);
            }
        }
        ModelState.AddModelError("", "Falha ao realizar o login!!!");
        return View(loginVM);
    }
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(LoginViewModel registerVM)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser{ UserName = registerVM.UserName };
            var result = await _userManager.CreateAsync(user, registerVM.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ModelState.AddModelError("", "Falha ao realizar o login!!!");
            }
        }
        return View(registerVM);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        HttpContext.Session.Clear();
        HttpContext.User = null;
        await _singnInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
}
