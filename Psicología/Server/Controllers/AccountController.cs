﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Psicología.Server.Authentication;
using Psicología.Shared.Model;

namespace Psicología.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserAccountService _userAccountService;
        public AccountController(UserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            var jwtAuthenticationManager = new JwtAuthenticationManager(_userAccountService);
            var userSession = jwtAuthenticationManager.GenerateJwtToken(loginRequest.UserName, loginRequest.Password);
            if(userSession is null)
            {
                return Unauthorized();
            }
            else
            {
                return userSession;
            }
        }
    }
}
