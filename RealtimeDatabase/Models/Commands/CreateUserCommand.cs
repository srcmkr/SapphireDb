﻿using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace RealtimeDatabase.Models.Commands
{
    public class CreateUserCommand : CommandBase
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string[] Roles { get; set; } = new string[0];

        public Dictionary<string, JValue> AdditionalData { get; set; } = new Dictionary<string, JValue>();
    }
}
