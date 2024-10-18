using Minimal.api.Dominio.Enuns;

namespace Minimal.api.Dominio.DTOs.ModelViews
{
    public record AdministradorLogado
    {
        public string Email { get; set; }
        public string Perfil { get; set; } = default!;
        public string Token { get; set; } = default!;
    }
}
