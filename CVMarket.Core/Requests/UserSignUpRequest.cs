﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CVMarket.Core.Requests
{
    public class UserSignUpRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}