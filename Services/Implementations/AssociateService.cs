using Microsoft.EntityFrameworkCore;
using Proauto.Data;
using Proauto.Models;
using Proauto.Services.Interfaces;
using Proauto.ViewModels;

namespace Proauto.Services.Implementations
{
    public class AssociateService : IAssociateService
    {
        private readonly AppDbContext _context;

        public AssociateService(AppDbContext context)
        {
            _context = context;
        }

        public Associate? Login(string cpf, string plate)
        {
            var associate = _context.Associates
                .FirstOrDefault(a => a.CPF == cpf);

            if (associate == null)
                return null;

            var vehicle = _context.Vehicles
                .FirstOrDefault(v =>
                    v.AssociateId == associate.Id &&
                    v.Plate == plate);

            if (vehicle == null)
                return null;

            return associate;
        }

        public Associate? GetById(int id)
        {
            return _context.Associates
                .Include(a => a.Vehicle)
                .Include(a => a.Address)
                .FirstOrDefault(a => a.Id == id);
        }

        public bool UpdateAddress(int associateId, AssociateViewModel vm)
        {
            var address = _context.Addresses
                .FirstOrDefault(a => a.AssociateId == associateId);

            if (address == null)
                return false;

            address.Street = vm.Street;
            address.Number = vm.Number;
            address.City = vm.City;
            address.State = vm.State;
            address.ZipCode = vm.ZipCode;

            _context.SaveChanges();

            return true;
        }
    }
}