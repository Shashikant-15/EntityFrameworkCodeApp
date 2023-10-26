using EntityFrameworkCodeApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCodeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext userContext;   // constructor

        public  UsersController(UserContext userContext)
        {
            this.userContext = userContext;
        }

        [HttpGet]
        [Route("GetUsers")] 
        public List<Users>  GetUsers()
        {
            return  userContext.Users.ToList();
        }

        [HttpGet]
        [Route("GetaUser")]
        public Users GetaUser(int id)
        {
            return userContext.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpPost]
        [Route("AddUser")]
        public string AddUser( Users users) 
        {
            string response = string.Empty;
            userContext.Users.Add(users);
            userContext.SaveChanges();
            return "New User Added !!!";
        }
        [HttpPut]
        [Route("UpdateUser")]
        public string UpdateUser( Users users)
        {
            userContext.Entry(users).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            userContext.SaveChanges();

            return "User successfully updated";
        }
        [HttpDelete]
        [Route("DeleteUser")]
        public string DeleteUser(int id)
        {
            Users users = userContext.Users.Where(x => x.Id == id).FirstOrDefault();

            if (users != null)
            {
                userContext.Users.Remove(users);
                userContext.SaveChanges();
                return "User Deleted !!";
            }
            else
            {
                return "No User Found";
            }
        }

       

    }
}
