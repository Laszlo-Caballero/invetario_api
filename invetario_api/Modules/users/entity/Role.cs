using System.Text;

namespace invetario_api.Modules.users.entity
{
    public class RoleString
    {
        public const string Admin = "ADMIN";
        public const string Store = "STORE"; // ALMACEN
        public const string Buy = "BUY"; // VENTAS
        public const string Audience = "AUDIENCE"; //Auditor

        public static string SetRole(List<string> roles)
        {
            // Empezamos con Admin
            var allRoles = new List<string> { RoleString.Admin.ToString() };

            if (roles != null && roles.Count > 0)
            {
                allRoles.AddRange(roles.Select(r => r.ToString()));
            }

            return string.Join(",", allRoles);
        }
    }
}
