using invetario_api.Modules.users.dto;
using invetario_api.Modules.users.entity;

namespace invetario_api.Modules.users
{
    public interface IUserService
    {
        public Task<User?> createUser(UserDto userDto);

        public Task<List<User>> getUsers();
    }
}
