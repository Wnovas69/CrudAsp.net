using CrudAsp.Data.Entities;

namespace CrudAsp.Data.Interfaces
{
    public interface IUsuarios
    {

        void Agregar(Usuarios usuarios);

        void Modiificar(Usuarios usuarios);

        List<Usuarios> List();

        Usuarios ObtenerPorId(int id);
        void Remover(int UsuarioId);
    }
}
