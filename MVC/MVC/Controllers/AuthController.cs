using dietapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dietapp.Controllers
{
    public class AuthController
    {
        private readonly UserModel _userModel;

        public AuthController()
        {
            _userModel = new UserModel();
        }

        public bool Login(string username, string password)
        {
            return _userModel.Authenticate(username, password);
        }
    }
}
