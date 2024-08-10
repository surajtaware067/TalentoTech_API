using Microsoft.AspNetCore.Mvc;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Services;

namespace TalentToTrack_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {
    

        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;

        public AccountController(ILogger<AccountController> logger,IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpPost(Name = "Login")] 
        public async Task<LoginResponse> Login([FromBody] LoginRequest request)
        {
            //var response= new LoginResponse();
            //if (request.UserName == "admin" && request.Password == "123")
            //{
            //    response.Success = true;
            //}
            //else
            //{ 
            //    response.Success= false;
            //    response.ErrorMessage = "invalid credential";
            //}
           var response=await _accountService.VerifyLoginDetailes(request);

            return response;
        }
    }
}
