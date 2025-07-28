using System.Runtime.CompilerServices;
using NetFirebase.Api.Dtos.UsuarioRegister;
using NetFirebase.Api.Dtos.Login;

namespace NetFirebase.Api.Services.Authentication;

public interface IAuthenticationService
{
   Task<string> RegisterAsync(UsuarioRegisterRequestDto request);

   //Login
   Task<string> LoginAsync(LoginRequestDto request);
}