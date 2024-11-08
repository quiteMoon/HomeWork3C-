using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3C_
{
    internal class Store
    {
        private string name;
        private string address;
        private string profileDescription;
        private string phone;
        private string email;

        public Store(string name, string address, string profileDescription, string phone, string email) 
        {
            this.name = name;
            this.address = address;
            this.profileDescription = profileDescription;
            this.phone = phone;
            this.email = email;
        }

        public void DisplayData()
        {
            Console.WriteLine("\nДані магазину:");
            Console.WriteLine($"Назва магазину: {name}");
            Console.WriteLine($"Адреса: {address}");
            Console.WriteLine($"Опис профілю: {profileDescription}");
            Console.WriteLine($"Контактний телефон: {phone}");
            Console.WriteLine($"Email: {email}");
        }

        public string GetName() => name;
        public string GetAddress() => address;
        public string GetProfileDescription() => profileDescription;
        public string GetPhone() => phone;
        public string GetEmail() => email;

        public void SetName(string name) => this.name = name;
        public void SetAddress(string address) => this.address = address;
        public void SetProfileDescription(string description) => profileDescription = description;
        public void SetPhone(string phone) => this.phone = phone;
        public void SetEmail(string email) => this.email = email;
    }
}
