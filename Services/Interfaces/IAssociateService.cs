using Proauto.Models;
using Proauto.ViewModels;

namespace Proauto.Services.Interfaces
{
    public interface IAssociateService
    {
        Associate? GetById(int id);

        Associate? Login(string cpf, string plate);

        bool UpdateAddress(int associateId, AssociateViewModel vm);
    }
}