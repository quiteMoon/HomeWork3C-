using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3C_
{
    internal class Journal
    {
        private string title;
        private int yearOfEstablishment;
        private string description;
        private string contactPhone;
        private string email;

        public Journal(string title, int yearOfEstablishment, string description, string contactPhone, string email)
        {
            this.title = title;
            this.yearOfEstablishment = yearOfEstablishment;
            this.description = description;
            this.contactPhone = contactPhone;
            this.email = email;
        }
        public void DisplayInformation()
        {
            Console.WriteLine("Назва журналу: " + title);
            Console.WriteLine("Рік заснування: " + yearOfEstablishment);
            Console.WriteLine("Опис: " + description);
            Console.WriteLine("Контактний телефон: " + contactPhone);
            Console.WriteLine("Email: " + email);
        }

        public void SetTitle(string title) => this.title = title;
        public void SetYearOfEstablishment(int yearOfEstablishment) => this.yearOfEstablishment = yearOfEstablishment;
        public void SetDescription(string description) => this.description = description;
        public void SetContactPhone(string contactPhone) => this.contactPhone = contactPhone;
        public void SetEmail(string email) => this.email = email;

        public string GetTitle() => title;
        public int GetYearOfEstablishment() => yearOfEstablishment;
        public string GetDescription() => description;
        public string GetContactPhone() => contactPhone;
        public string GetEmail() => email;
    }
}
