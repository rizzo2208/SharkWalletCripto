﻿using API.Uses.Cases.UOWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using API.Core.Wallet.Entities;

namespace SharkWalletCripto.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUOWork _context;

        public UserController(IUOWork context)
        {
            _context = context;
        }

        //GET
        //-----------------------------------------------------------
        /// <summary>
        /// Api para seleccionar todos los clientes de la base de datos.
        /// </summary>
        /// <param name="User">Estructura</param>
        /// <response code="200">Se creo correctamente</response>
        /// <response code="404">Usuario no encontrado</response>
        /// <response code="500">Oops! No se pudo buscar el User</response>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var entidad = _context.UserRepo.GetAll();//llama a todos los registros activos
            return Ok(entidad);
        }

        //POST
        //-----------------------------------------------------------
        /// <summary>
        /// cargo un regitro en a tabla clientes
        /// </summary>
        /// <param name="User">Estructura</param>
        /// <response code="200">Se creo correctamente</response>
        /// <response code="404">Usuario no encontrado</response>
        /// <response code="500">Oops! No se pudo buscar el User</response>
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            _context.UserRepo.Insert(user);//agrega un registro
            _context.Save();
            return Ok();
        }

        //PUT
        //-----------------------------------------------------------
        /// <summary>
        /// modifica el registro que necesitamos
        /// </summary>
        /// <response code="200">Se creo correctamente</response>
        /// <response code="404">Usuario no encontrado</response>
        /// <response code="500">Oops! No se pudo buscar el User</response>

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] User user, int id)
        {
            if (id != user.UserID)
            {
                return BadRequest();//NO se encontro id del registro
            }
            else
            {
                _context.UserRepo.Update(user);//modifica registro
                _context.Save();
                return Ok();
            }

        }

        //DELETE
        //-----------------------------------------------------------
        /// <summary>
        ///  borra registro de la base de datos.
        /// </summary>
        /// <param name="id" example="123">UserID</param>
        /// 
        /// <response code="200">Se creo correctamente</response>
        /// <response code="404">Usuario no encontrado</response>
        /// <response code="500">Oops! No se pudo buscar el User</response>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var entity = _context.UserRepo.GetById(id);

            if (entity == null)
            {
                return NotFound("No Se Encontro El Regisro Solicitado");
            }
            else
            {
                _context.UserRepo.Delete(id);//borra el registro
                _context.Save();
            }


            return Ok();


        }
    }
}