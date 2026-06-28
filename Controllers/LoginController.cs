using Microsoft.AspNetCore.Mvc;
using Proauto.Services.Interfaces;
using Proauto.ViewModels;

namespace Proauto.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAssociateService _service;

        public LoginController(IAssociateService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Auth(LoginViewModel model)
        {
            var associate = _service.Login(model.CPF, model.Plate);

            if (associate == null)
            {
                ModelState.AddModelError("", "Dados inválidos. Verifique CPF e placa.");
                return View("Index");
            }

            HttpContext.Session.SetInt32("UserId", associate.Id);

            return RedirectToAction("Index", "Associate");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}