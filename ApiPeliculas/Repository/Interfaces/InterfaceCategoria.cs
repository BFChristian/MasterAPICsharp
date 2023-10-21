using ApiPeliculas.Models;

namespace ApiPeliculas.Repository.Interfaces
{
    public interface InterfaceCategoria
    {
        ICollection<Categoria> GetCategorias();
        Categoria GetCategoria(int categoriaId);
        bool existeCategoria(string nombre);
        bool existeCategoria(int id);
        bool CrearCategoria(Categoria categoria);
        bool ActualizarCategoria(Categoria categoria);
        bool BorrarCategoria(Categoria categoria);
        bool Guardar();
    }
}
