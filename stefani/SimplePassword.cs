using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_cSharp.stefani
{
    public class SimplePassword : IPassword
    {
        private readonly string _password;

        public SimplePassword(string password)
        {
            _password = password;
        }
        public string GetPassword() => _password;
    }
}
