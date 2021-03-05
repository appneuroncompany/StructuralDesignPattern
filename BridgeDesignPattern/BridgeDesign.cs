using BridgeDesignPattern.Concrete;
using System;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Bridge tasarım deseni implementasyonları abstractlardan ayırabilmek için kullanılır.
    /// İmplementasyonları clienttan tamamen ayırmak istiyorsanız…
    /// İmplementasyonları direkt olarak clientla iletişime geçen abstractiona bağlamak istemiyorsanız…
    ///   Abstraction classını rebuild dahi etmeden implementasyonlar içerisinde değişiklik yapmak istiyorsanız… kullanabilirsiniz.
    /// </summary>
    public class BridgeDesign
    {
        public static void TestBridgeDesign()
        {
            HumanoidController humanoidController = new HumanoidController(new Humanoidchar());
            humanoidController.RunChar();

            SpiderController spiderController = new SpiderController(new SpiderChar());
            spiderController.RunChar();
        }
    }
}
