using Microsoft.AspNetCore.Mvc;
using Proauto.Services.Interfaces;
using Proauto.ViewModels;

namespace Proauto.Controllers
{
    public class AssociateController : Controller
    {
        private readonly IAssociateService _service;

        public AssociateController(IAssociateService service)
        {
            _service = service;
        }

        // 📄 EXIBIR DADOS
        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Index", "Login");

            var associate = _service.GetById(userId.Value);

            if (associate == null)
                return NotFound();

            var vm = new AssociateViewModel
            {
                Id = associate.Id,
                Name = associate.Name,
                CPF = associate.CPF,
                Phone = associate.Phone,
                Plate = associate.Vehicle?.Plate,
                Street = associate.Address?.Street,
                Number = associate.Address?.Number,
                City = associate.Address?.City,
                State = associate.Address?.State,
                ZipCode = associate.Address?.ZipCode
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult UpdateAddress(AssociateViewModel vm)
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Index", "Login");

            var success = _service.UpdateAddress(userId.Value, vm);

            if (success)
                TempData["Success"] = "Endereço atualizado com sucesso!";
            else
                TempData["Error"] = "Erro ao atualizar endereço.";

            return RedirectToAction("Index");
        }
    }
}