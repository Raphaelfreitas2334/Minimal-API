using Minimal.api.Dominio.DTOs;
using Minimal.api.Dominio.Entidades;

namespace Minimal.api.Dominio.Interfaces
{
    public interface IAdministradorServicos
    {
        Adiministrador? Login (LoginDTO loginDTO);
        Adiministrador? Incluir (Adiministrador administrador);
        Adiministrador? BuscaPorId(int id);
        List<Adiministrador> Todos (int? pagina);

    }
}
