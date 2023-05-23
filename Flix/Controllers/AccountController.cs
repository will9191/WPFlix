using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Flix.DataTransferObjects;
using Flix.Models;
using Microsoft.AspNetCore.Identity;

namespace Flix.Controllers;

[Authorize(Roles = "Administrador")]

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly UserManager<AppUser> _userManager;

    public AccountController(
    ILogger<AccountController> logger,
    SignInManager<AppUser> signInManager,
    UserManager<AppUser> userManager)
    {
        _logger = logger;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login(string returnUrl)
    {
        LoginDto loginDto = new();
        loginDto.ReturnUrl = returnUrl ?? Url.Content("~/");
        return View(loginDto);
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginDto login)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(
                login.Email, login.Password, login.RememberMe, true
            //Nao é necessario colocar lockoutOnFailure, apenas true, por conta que ja é o ultimo parametro
            );

            if (result.Succeeded)
            {
                _logger.LogInformation($"User {login.Email} accessed the system ");
                return LocalRedirect(login.ReturnUrl);
            }

            if (result.IsLockedOut)
            {
                _logger.LogWarning($"User {login.Email} its blocked ");
                return RedirectToAction("Lockout");
            }
            ModelState.AddModelError("login", "User and/or Password invalids!!!");
        }
        return View(login);
    }
}
