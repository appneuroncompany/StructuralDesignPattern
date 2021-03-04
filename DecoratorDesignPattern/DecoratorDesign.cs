using DecoratorDesignPattern.NetworkDataTransmission.Concrete;
using System;

namespace DecoratorDesignPattern
{
    /// <summary>
    /// Yazılım mimarilerinde temel esas, mümkün mertebe birbirlerinden soyutlanmış yapıların gevşek bağlılığı(loose coupling) sağlayarak ortaya koyduğu geliştirmeye dayanmaktadır.
    /// Bu geliştirme sürecinde var olan sınıflarımızdaki bir metodun niteliğini değiştirme ihtiyacı hissedildiği zaman bu ihtiyacı kodu bozmaksızın, dinamik bir şekilde giderebilmemiz gerekmektedir. 
    /// İşte böyle bir durumda, kurulmuş düzeni bozmadan, mimarisel yapılanmanın temellerini oynatmadan bir metodun niteliğini genişletmek için Decorator tasarım deseninden faydalanabiliriz.
    /// Decorator pattern’inin genellikle bir class’a yeni bir özellik/member/metot vs. eklemeye yaradığı düşünülmektedir. 
    /// Halbuki Decorator pattern, hali hazırda var olan bir sınıfın mevcudiyetteki metodunun işlevini genişletmek için vardır.
    /// </summary>
    public class DecoratorDesign
    {
        public static void TestDecoratorDesign()
        {
            AppDatagram appDatagram = new AppDatagram();
            appDatagram.SendData();

            TcpDatagram tcpDatagram = new TcpDatagram(appDatagram);
            tcpDatagram.SendData();

            UdpDatagram udpDatagram = new UdpDatagram(appDatagram);
            udpDatagram.SendData();
        }
    }
}
