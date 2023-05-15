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
    public IActionResult Login(LoginDto login)
    {
        if (ModelState.IsValid)
        {
            return LocalRedirect(login.ReturnUrl);
        }

        return View(login);
    }
}
