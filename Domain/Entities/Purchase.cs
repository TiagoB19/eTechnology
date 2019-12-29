using Domain.paymentObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Entities
{
    public class Purchase : Entity
    {
        private int id;
        private DateTime date;
        private DateTime deliveryForecast;
        private int userID;
        private ICollection<itemProduct> products;
        private string cep;
        private string state;
        private string address;
        private string numberAddress;
        private int paymentId;
        private paymentMethod paymentMethod;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public int UserID { get => userID; set => userID = value; }
        public string Cep { get => cep; set => cep = value; }
        public string State { get => state; set => state = value; }
        public string Address { get => address; set => address = value; }
        public string NumberAddress { get => numberAddress; set => numberAddress = value; }
        public DateTime DeliveryForecast { get => deliveryForecast; set => deliveryForecast = value; }
        public int PaymentId { get => paymentId; set => paymentId = value; }
        internal ICollection<itemProduct> Products { get => products; set => products = value; }
        internal paymentMethod PaymentMethod { get => paymentMethod; set => paymentMethod = value; }

        public override void Validate()
        {
            cleanMessages();
            if (!products.Any()) ValidatedMessages.Add("Purchase doesn't have a product!");
            if (string.IsNullOrEmpty(cep)) ValidatedMessages.Add("Cep was not identified!");
            if (string.IsNullOrEmpty(State)) ValidatedMessages.Add("State was not identified!");
            if (string.IsNullOrEmpty(Address)) ValidatedMessages.Add("Address was not identified!");
        }
    }
}
