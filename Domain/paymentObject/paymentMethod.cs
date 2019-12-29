using Domain.Enumerates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.paymentObject
{
    public class paymentMethod  
    {
        private int id;
        private string name;
        private string description;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        public int PaymentReturn()
        {
            if (id == (int)(paymentEnum.notDefined)) return 0;
            else if (id == (int)paymentEnum.bankSlip) return 1;
            else if (id == (int)paymentEnum.creditCard) return 2;
            else return (int)paymentEnum.deposit;
        }
    }
}
