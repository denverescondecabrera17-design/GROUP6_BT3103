using System;
using System.Collections.Generic;
using CODEINN.Repository;  
using CODEINN.Model;

namespace CODEINN.Controller
{
    public class UserController
    {
        private UserRepository userRepo;

        public UserController()
        {
            userRepo = new UserRepository();
        }

        public User ValidateUser(string Username, string Password)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                throw new Exception("Password/Username cannot be empty.");

            var user = userRepo.ValidateUser(Username, Password);

            if (user != null)
            {
                Console.WriteLine("Login Successful");
                return user;
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
                return null;
            }
        }
    }
}
