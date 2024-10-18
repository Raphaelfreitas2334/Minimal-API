using Microsoft.EntityFrameworkCore;
using Minimal.api.Dominio.DTOs;
using Minimal.api.Dominio.DTOs.ModelViews;
using Minimal.api.Dominio.Entidades;
using Minimal.api.Dominio.Interfaces;
using Minimal.api.Infraestruturas.DB;

namespace Minimal.api.Dominio.Serviços
{
    public class AdministradorServicos : IAdministradorServicos
    {
        private readonly DBContexto _dBContexto;

        public AdministradorServicos(DBContexto dBContexto)
        {
            _dBContexto = dBContexto;
        }

        public Adiministrador? Incluir(Adiministrador administrador)
        {
            _dBContexto.Adiministradores.Add(administrador);
            _dBContexto.SaveChanges();

            return administrador;
        }

        public List<Adiministrador> Todos(int? pagina)
        {
            var quary = _dBContexto.Adiministradores.AsQueryable();

            int itensPorPaginas = 10;

            if (pagina != null)
            {
                quary = quary.Skip(((int)pagina - 1) * itensPorPaginas).Take(itensPorPaginas);
            }
            return quary.ToList();
        }

        public Adiministrador? Login(LoginDTO loginDTO)
        {
            var adm = (_dBContexto.Adiministradores.Where(x => x.Email == loginDTO.Email
                                      && x.Senha == loginDTO.Senha).FirstOrDefault());
            return adm;
        }

        public Adiministrador? BuscaPorId(int id)
        {
            return _dBContexto.Adiministradores.Where(V => V.Id == id).FirstOrDefault();
        }
    }
}
