using Greata.Express.Model.DB;
using Greata.Express.WebAPI.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Greata.Express.WebAPI.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login(LoginInfo info)
        {
            var validated = System.Web.Security.Membership.ValidateUser(info.UserName, info.Password);

            if (validated)
            {
                var repo = Repository.Factory.Repository.Create<AccessToken>("BusinessDB");
                var token = new AccessToken
                {
                    Token = Guid.NewGuid().ToString().Replace("-", String.Empty),
                    UserName = info.UserName,
                    LastAccess = DateTime.Now,
                    Created = DateTime.Now
                };
                repo.Create(token);
                return Ok(token);
            }
            else
            {
                return Ok(new Models.Error
                {
                    Code = 001,
                    Message = "用户名或密码不正确。"
                });
            }
        }
    }
}
