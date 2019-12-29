using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class itemProduct : Entity
    {
        private int id;
        private int productId;
        private int quantity;

        public int ProductId { get => productId; set => productId = value; }
        public int Id { get => id; set => id = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public override void Validate()
        {
            cleanMessages();
            if (productId == 0) ValidatedMessages.Add("The product was not identified");
            if (quantity == 0) ValidatedMessages.Add("The quantity was not defined");
        }
    }
}
