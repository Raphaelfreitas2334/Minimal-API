using Minimal.api.Dominio.Enuns;

namespace Minimal.api.Dominio.DTOs.ModelViews
{
    public record AdministradorModelView
    {
        public int ID { get; set; }
        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
    }
}
