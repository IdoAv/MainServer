using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainServerBL.Models;
namespace MainServer.Controllers
{
    [Route("MainAPI")]
    [ApiController]
    public class MainController : ControllerBase
    {
        #region Add connection to the db context using dependency injection
        MainDBContext context;
        public MainController(MainDBContext context)
        {
            this.context = context;
        }
        #endregion
    }
}
