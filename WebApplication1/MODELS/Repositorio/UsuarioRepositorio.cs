using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.MODELS.Entities;


namespace WebApplication1.MODELS.Repositorio
{
    public class UsuarioRepositorio:IusersCrud
    {


        private readonly AppDbContext contexto;
        private List<UsersEntity> usersLista;
        public UsuarioRepositorio(AppDbContext contexto)
        {
            this.contexto = contexto;
        }
        public UsersEntity nuevo(UsersEntity usersEntity)
        {
            
                contexto.UsersEntity.Add(usersEntity);
                contexto.SaveChanges();
            return usersEntity;

        }

        

        public UsersEntity borrar(int id)
        {

            UsersEntity usersEntity = contexto.UsersEntity.Find(id);
            if (usersEntity != null)
            {
                contexto.UsersEntity.Remove(usersEntity);
                contexto.SaveChanges();
            }
            return usersEntity;

        }
        public List<UsersEntity> GetAllUsers()
        {
            usersLista = contexto.UsersEntity.ToList<UsersEntity>();
            return usersLista;
        }
        public UsersEntity GetUsers(string cedula, string pass)
        {
       return (UsersEntity)contexto.UsersEntity.Where(e => e.IDENTIFICACION == cedula && e.PASS == pass);
        }


        public UsersEntity modificarUser(UsersEntity usersEntity)
        {
            var usr = contexto.UsersEntity.Attach(usersEntity);
            usr.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
            return usersEntity;
        }
    }


}
