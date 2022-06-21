using API.Uses.Cases.Services;
using API.Uses.Cases.UOWork;
using Microsoft.AspNetCore.Mvc;

namespace SharkWalletCripto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private readonly IUserServices _usuarioService;
        private readonly IUOWork _uow;


    }
}
