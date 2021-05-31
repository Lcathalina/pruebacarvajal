using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.MODELS.Entities;

namespace WebApplication1.MODELS
{
    public interface IusersCrud
    {
        
        public UsersEntity nuevo(UsersEntity usersEntity);
        UsersEntity borrar(int id);
        List<UsersEntity> GetAllUsers();
        UsersEntity GetUsers(string cedula,string pass);
        UsersEntity modificarUser(UsersEntity usersEntity);
    }
}
