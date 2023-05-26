using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Flix.DataTransferObjects;
using Flix.Models;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;

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
            string userName = login.Email;
            if(IsValidEmail(login.Email))
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                if (user != null)
                    userName = user.UserName;
            }

            var result = await _signInManager.PasswordSignInAsync(
                userName, login.Password, login.RememberMe, true
            //Não é necessario colocar lockoutOnFailure, apenas true, por conta que ja é o ultimo parametro
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

    private bool IsValidEmail(string email)
    {
        try
        {
            MailAddress m = new(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}
