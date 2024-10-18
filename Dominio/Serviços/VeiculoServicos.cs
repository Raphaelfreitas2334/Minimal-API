using Microsoft.EntityFrameworkCore;
using Minimal.api.Dominio.DTOs;
using Minimal.api.Dominio.Entidades;
using Minimal.api.Dominio.Interfaces;
using Minimal.api.Infraestruturas.DB;

namespace Minimal.api.Dominio.Serviços
{
    public class VeiculoServicos : IVeiculoServicos
    {
        private readonly DBContexto _dBContexto;

        public VeiculoServicos(DBContexto dBContexto)
        {
            _dBContexto = dBContexto;
        }

        public void Apagar(Veiculo veiculo)
        {
            _dBContexto.Veiculos.Remove(veiculo);
            _dBContexto.SaveChanges();
        }

        public void Atualizar(Veiculo veiculo)
        {
            _dBContexto.Veiculos.Update(veiculo);
            _dBContexto.SaveChanges();
        }

        public Veiculo? BuscaPorId(int id)
        {
            return _dBContexto.Veiculos.Where(V => V.Id == id).FirstOrDefault();
        }

        public void Incluir(Veiculo veiculo)
        {
            _dBContexto.Veiculos.Add(veiculo);
            _dBContexto.SaveChanges();
        }

        public List<Veiculo> Todos(int? Pagina = 1, string? nome = null, string? marca = null)
        {
            var quary = _dBContexto.Veiculos.AsQueryable();
            if (!string.IsNullOrEmpty(nome))
            {
                quary = quary.Where(V => EF.Functions.Like(V.Nome.ToLower(), $"%{nome}%"));
            }

            int itensPorPaginas = 10;

            if (Pagina != null)
            {
                quary = quary.Skip(((int)Pagina - 1) * itensPorPaginas).Take(itensPorPaginas);
            }
            return quary.ToList(); 
        }
    }
}
