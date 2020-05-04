using MassAssignment.Models;
using Microsoft.AspNetCore.Http;

namespace MassAssignment.Utility
{
    public class UserRepository
    {
        public static void Store(User user, HttpContext context)
        {
            User existingUser = context.Session.Get<User>("user");
            user.Username = existingUser.Username;
            context.Session.Set<User>("user", user);
        }
    }
}
