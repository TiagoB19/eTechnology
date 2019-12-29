using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product : Entity
    {
        private int id;
        private string name;
        private string description;
        private string price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Price { get => price; set => price = value; }

        public override void Validate()
        {
            cleanMessages();
            if (string.IsNullOrEmpty(name)) ValidatedMessages.Add("The name must be defined");
            if (string.IsNullOrEmpty(description)) ValidatedMessages.Add("The description must be defined");
            if (string.IsNullOrEmpty(price)) ValidatedMessages.Add("The price must be defined");

        }
    }
}
