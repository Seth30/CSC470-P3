using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;

namespace P3_Code
{
    public class FakeAppUserRepository : IAppUser
    {
        private static Dictionary<string, AppUser> AppUsers;

        public FakeAppUserRepository()
        {
            if (AppUsers == null)
            {
                AppUsers = new Dictionary<string, AppUser>();
                AppUsers.Add("UserName", new AppUser
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

        private string GetUserName()
        {
            throw new NotImplementedException();
        }
        public List<AppUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public AppUser GetByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public bool Login(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            throw new NotImplementedException();
        }
    }
}