using Microsoft.VisualStudio.TestTools.UnitTesting;
using Greata.Express.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greata.Express.Model.DB;

namespace Greata.Express.WebAPI.Controllers.Tests
{
    [TestClass()]
    public class AuthControllerTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            AuthController auth = new AuthController();
            var result = auth.Login(new Models.Auth.LoginInfo
            {
                UserName = "paims",
                Password = "Paims2017@@SH"
            });
            var token = result as System.Web.Http.Results.OkNegotiatedContentResult<AccessToken>;
            Assert.IsNotNull(token);
        }
    }
}