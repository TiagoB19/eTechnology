using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Entities
{
    public abstract class Entity 
    {
        private List<string> messages;
        private List<string> validatedMessages;
        public List<string> Messages { get => messages; set => messages = value; }
        public List<string> ValidatedMessages { get => messages ?? (messages = new List<string>());}

        public abstract void Validate();
        
        protected bool isValidate
        {
            get { return !validatedMessages.Any();}
        }

        protected void cleanMessages()
        {
            validatedMessages.Clear();
        }
    }
}
