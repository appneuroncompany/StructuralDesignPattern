using FlyweightDesignPattern.Concrete;
using System;

namespace FlyweightDesignPattern
{

    /// <summary>
    /// Bu kalıbın amacı yapıca aynı nesneleri bellekte çokça oluşturmak yerine her bir nesnenin bir kopyasını oluşturmak ve oluşturulan nesneleri ortak bir noktada tutup paylaştırma işlemini yerine getirmektir.
    /// Yani tekrar eden aynı nesneleri gruplayarak hafızada çok fazla yer kaplamaması için ,hafıza kullanımını minumuma indirmektir.
    /// Mesela bir metin dosyası sıkıştırma olayı buna bir örnektir.
    /// Aynı metinlerin referansları tutularak yerden kazanç sağlanır.
    /// </summary>
    public class FlyweightDesign
    {
        public static void TestFlyweightDesign(string charArray)
        {
            SevenZip sevenZip = new SevenZip();
            sevenZip.ZipDocument(charArray);
        }
    }
}
