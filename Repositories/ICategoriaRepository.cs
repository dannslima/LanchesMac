using LanchesMac.Models;

namespace LanchesMac
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
