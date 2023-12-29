using System;
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
        public string Group { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Course {  get; set; }
    }
}