﻿using API.Core.Wallet.Autentication.Request;
using API.Core.Wallet.Autentication.Response;

namespace API.Uses.Cases.Services
{
    public interface IUserservices
    {
        UserResponse Registrar(UserRequest usuario, string password);
        UserResponse Login(string usuario, string password);
        string GetToken(UserResponse usuario);
    }
}
