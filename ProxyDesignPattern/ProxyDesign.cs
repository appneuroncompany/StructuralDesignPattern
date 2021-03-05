using ProxyDesignPattern.Concrete;
using System;

namespace ProxyDesignPattern
{
    /// <summary>
    /// Proxy D.P. Client tarafından erişilecek nesneye vekalet eden bir tasarım desenidir.
    /// Burada vekaletten kasıt ilgili nesneyi kontrol edecek bir Proxy nesnesinin kullanılmasıdır.
    /// Remote(Uzak) Proxy: Uzaktaki nesneye local bir temsilci sağlar ve gerekli kontrolleri yapmamıza olanak tanır.
    /// Virtual Proxy: Üretimi yahut kullanımı maliyetli nesnelerin oluşturulması veya kullanılması için tercih edilir. 
    /// Buna örnek olarak genelde herkesin dillendirdiği resim yükleme işlevini verebiliriz.
    /// Protection Proxy: Yetkilendirme yahut login durumlarında kullanılabilir.
    /// Proxy bir tane gerçek nesneye veya servise erişirken oluşacak problemleri giderirken, Facade daha çok servisin olduğu ve bu servislerden farklı farklı method çağırımlarını soyutlayarak istemcinin işlerini kolaylaştırdığını görebilirsiniz.
    /// </summary>
    public class ProxyDesign
    {
        public static void TestProxyDesign()
        {
            ProxyBank proxyBank = new ProxyBank("burak", "12345");
            proxyBank.Pay(35);
        }
    }
}
