﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Repositories;
using TalentoTrack.Common.Services;

namespace TalentoTrack.Service
{
    public class AccountService:IAccountService
    {
        public readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<LoginResponse> VerifyLoginDetailes(LoginRequest request)
        { 
            LoginResponse response=new LoginResponse();
            try
            {
               var dbUser= await _accountRepository.GetLoginDetailes(request.UserName!, request.Password!);
                if (dbUser == null)
                {
                    response.Success = false;
                    response.ErrorMessage = "Invalid Credential";
                }
                else
                {
                    response.Success = true;
                }
                return response;

            }
            catch (Exception ex)
            {
                // Todo log error
                throw;
            
            }

        
        }
    }
}
