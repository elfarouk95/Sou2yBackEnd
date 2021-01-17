using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entitis.Models;
using Microsoft.AspNetCore.Mvc;
using Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Souqe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {

        private IRepositoryManger repositoryBase;

        public HomeController (IRepositoryManger _repositoryBase)
        {
            repositoryBase = _repositoryBase;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var x = repositoryBase.Customer().GetAllCustomers(false);

            var myUser = x

        .FirstOrDefault(u => u.Phone == "222"
                     && u.Password == "test");

            if (myUser != null)    //User was found
            {
                return Ok("ok");
            }
            else    //User was not found
            {
                return Ok("no OK");
            }


          

          
        }
    }
}
