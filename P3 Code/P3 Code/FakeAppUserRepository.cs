using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Code
{
    public class FakeAppUserRepository : IAppUser
    {
        private static Dictionary<int, AppUser> AppUsers;

        public FakeAppUserRepository()
        {
            if (AppUsers == null)
            {
                AppUsers = new Dictionary<int, AppUser>();
                AppUsers.Add(1, new AppUser
                {
                    UserName = "DaveBish",
                    Password = "iLoveSoftware",
                    FirstName = "David",
                    LastName = "Bishop",
                    EmailAddress = "Dave.Bishop@dsu.edu",
                    IsAuthenticated = true
                }) ;
            }
        }
    }
}
