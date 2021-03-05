using FacadeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.Concrete
{
    public class RestSharpDataSender : IDataSender
    {
        public bool CheckInternetConnection()
        {
            Console.WriteLine("internet bağlantısı başarılı");
            return true;
        }

        public void SendMessageWithRestClient(string messege)
        {
            Console.WriteLine("Gönderilen mesaj: \n" + messege);
        }
    }
}
