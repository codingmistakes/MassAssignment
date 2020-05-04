using MassAssignment.Models;
using MassAssignment.Utility;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MassAssignment.Filters
{
    public class InitializerFilterActionAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            User user = context.HttpContext.Session.Get<User>("user");

            if (user == null)
            {
                user = new User()
                {
                    ID = 1,
                    Username = "john",
                    FullName = "John Doe",
                    Bio = "A software security enthusiast, developer.",
                    IsAdmin = false,
                    Email = "john.doe@example.com",
                };
                user.Account.UserID = user.ID;

                context.HttpContext.Session.Set<User>("user", user);
            }
        }

    }
}
