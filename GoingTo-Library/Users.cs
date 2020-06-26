using System;

namespace GoingTo_Library
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserProfiles UserProfiles { get; set; }
        
    }
}
