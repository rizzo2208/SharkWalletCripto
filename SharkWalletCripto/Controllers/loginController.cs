using API.Core.Wallet.Autentication.Request;
using API.Core.Wallet.Autentication.Response;
using API.Uses.Cases.Services;
using API.Uses.Cases.UOWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SharkWalletCripto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserservices _usuarioService;
        private readonly IUOWork _uow;


        public LoginController(IUserservices usuarioService, IUOWork uow)
        {
            _usuarioService = usuarioService;
            _uow = uow;
        }
        [HttpPost]
        public ActionResult Login([FromBody] UserRequest req)
        {
            var response = _usuarioService.Login(req.Email, req.Password);

            if (response == null)
            {

                return Unauthorized();
            }
            var token = _usuarioService.GetToken(response);
            return Ok(new
            {
                token = token,
                usuario = response
            });
        }
        [HttpPost("Registro")]
        public ActionResult RegistrarUsuario([FromBody] UserRequest user)
        {
            if (_uow.UserRepo.ExisteUsuario(user.Email.ToLower()))
            {
                return BadRequest("Ya existe un cuenta asociada a ese Email");
            }
            UserResponse res = _usuarioService.Registrar(user, user.Password);
            return Ok(res);
        }
    }
}
