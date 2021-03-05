using FacadeDesignPattern.Concrete;
using System;

namespace FacadeDesignPattern
{
    /// <summary>
    /// Structural Patterns bir örneği olan Facade örüntü bir çok bileşenden oluşup 
    /// dışarıya bir kütüphane şeklinde hizmet verdiğinde istemcinin arkaplanda olan karmaşıklığı bilmesine gerek yoktur.
    /// Burda yapılan soyutlamaya Facade örüntüsü denir.
    /// Sisteminizde bir çok bileşen bulunuyor. 
    /// İstemci olarak sizin bu bileşenlerin birçoğunu bilip bir işlem yapabilmek için 
    /// farklı farklı bileşenlerden farklı sıralarda metodlar çağırmanız gerektiği durumda 
    /// İstemci sınıfı bu karmaşadan ve bu iş mantıklarından soyutlamak için istemcilerin önüne yazılan bir soyutlama katmanıdır (sınıfıdır)
    /// </summary>
    public class FacadeDesign
    {
        public static void ManageData()
        {
            BinaryDataSaver binaryDataSaver = new BinaryDataSaver();
            RestSharpDataSender restSharpDataSender = new RestSharpDataSender();
            bool internetConnection = restSharpDataSender.CheckInternetConnection();
            if (internetConnection)
            {
                restSharpDataSender.SendMessageWithRestClient("smt message");
            }
            else
            {
                binaryDataSaver.SaveData("smt message", "../../smtfloder");
            }

        }
    }
}
