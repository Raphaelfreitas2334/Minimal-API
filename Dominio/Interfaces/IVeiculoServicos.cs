using Minimal.api.Dominio.DTOs;
using Minimal.api.Dominio.Entidades;

namespace Minimal.api.Dominio.Interfaces
{
    public interface IVeiculoServicos
    {
        List<Veiculo> Todos (int? Pagina = 1, string? nome = null, string? marca = null);
        Veiculo BuscaPorId (int id);
        void Incluir (Veiculo veiculo);
        void Atualizar (Veiculo veiculo);
        void Apagar (Veiculo veiculo);
    }
}
