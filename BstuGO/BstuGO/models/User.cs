﻿using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BstuGO.models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}