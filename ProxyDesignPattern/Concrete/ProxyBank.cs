using ProxyDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDesignPattern.Concrete
{
    public class ProxyBank : IBank
    {
        AbcBank abcBank;

        string username;
        string password;

        public ProxyBank(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        bool Login(string userName, string password)
        {
            abcBank = new AbcBank();
            Console.WriteLine("Giriş yapıldı");
            return true;

        }

        public bool Pay(int price)
        {
            bool isLogedIn = Login(username, password);
            if (!isLogedIn)
            {
                Console.WriteLine("Giriş başarılı değil. Ödeme tamamlanamadı...");
                return false;
            }
            bool isPaid = abcBank.Pay(price);
            if (!isPaid)
            {
                Console.WriteLine("Ödeme başarısız oldu!");
                return false;
            }
            Console.WriteLine("Ödeme başarılı bir şekilde yapıldı");
            return true;

        }
    }
}
