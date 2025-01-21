using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.BadExample
{
    internal class Validator
    {
        public void Validate(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            // Trim whitespace
            request.ValidatedUsername = username.Trim();
            request.ValidatedPassword = password.Trim();
        }
    }
}
