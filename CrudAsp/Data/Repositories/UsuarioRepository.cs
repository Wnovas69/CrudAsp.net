using CrudAsp.Context;
using CrudAsp.Data.Entities;
using CrudAsp.Data.Interfaces;

namespace CrudAsp.Data.Repositories
{
    public class UsuarioRepository : IUsuarios
    {
        private readonly CrudContext context;

        public UsuarioRepository(CrudContext context)
        {
            this.context = context;
        }
        public void Agregar(Usuarios usuarios)
        {
            this.context.Usuarios.Add(usuarios);
            this.context.SaveChanges();
        }

        public List<Usuarios> List()
        {
            return this.context.Usuarios.ToList();
        }

        public void Modiificar(Usuarios usuarios)
        {
            this.context.Usuarios.Update(usuarios);
            this.context.SaveChanges();
        }

        public Usuarios ObtenerPorId(int id)
        {
            return this.context.Usuarios.Find(id);

            
        }

        public void Remover(int UsuarioId)
        {
            var usuario = this.context.Usuarios.First(cd => cd.Id == UsuarioId);
            this.context.Usuarios.Remove(usuario);
            this.context.SaveChanges();
        }
    }
}
