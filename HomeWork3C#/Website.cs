using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3C_
{
    internal class Website
    {
        private string name;
        private string url;
        private string description;
        private string ipAddress;

        public Website(string name, string url, string description, string ipAddress)
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ipAddress = ipAddress;
        }

        public void DisplayWebsiteDetails()
        {
            Console.WriteLine($"Назва сайту: {name}");
            Console.WriteLine($"URL сайту: {url}");
            Console.WriteLine($"Опис сайту: {description}");
            Console.WriteLine($"IP-адреса сайту: {ipAddress}");
        }

        public string GetName() => name;
        public string GetUrl() => url;
        public string GetDescription() => description;
        public string GetIpAddress() => ipAddress;

        public void SetName(string name) => this.name = name;
        public void SetUrl(string url) => this.url = url;
        public void SetDescription(string description) => this.description = description;
        public void SetIpAddress(string ipAddress) => this.ipAddress = ipAddress;
    }
}
