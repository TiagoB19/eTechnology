using System.Collections;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class User:Entity
    {
        
        private int id;
        private string name;  
        private string email;
        private string password;
        private ICollection<Purchase> purchases;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public ICollection<Purchase> Purchases { get => purchases; set => purchases = value; }

        public override void Validate()
        {
            cleanMessages();
            if (string.IsNullOrEmpty(name)) ValidatedMessages.Add("The name was not found!");
            if (string.IsNullOrEmpty(email)) ValidatedMessages.Add("The E-mail was not found!");
            if (string.IsNullOrEmpty(password)) ValidatedMessages.Add("You must set a password for your account!");
        }
    }
}
