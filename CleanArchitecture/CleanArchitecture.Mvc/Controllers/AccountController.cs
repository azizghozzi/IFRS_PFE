using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Mvc.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Index()
        {
            accountViewModel model = _accountService.Getaccounts();
            return View(model);
        }
    }
}
