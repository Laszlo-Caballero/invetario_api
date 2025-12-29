using invetario_api.Modules.users.entity;

namespace invetario_api.Modules.auth.response
{
    public class LoginResponse
    {
        public string token { get; set; }

        public User user { get; set; }


    }
}
