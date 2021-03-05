using FacadeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.Concrete
{
    class BinaryDataSaver : IDataManager
    {
        public void CheckData(string filePath)
        {
            Console.WriteLine("Veri kontrol edildi. Veri : \n" + "Kaydedilen veri...");
        }

        public void DeleteData(string filePath)
        {
            Console.WriteLine("Veri silindi. Veri yolu: \n" + filePath);
        }

        public void SaveData(string data, string filePath)
        {
            Console.WriteLine("Veri kaydedildi. Veri yolu ve kaydedilen veri : \n" + filePath + "\n" + data);
        }
    }
}
