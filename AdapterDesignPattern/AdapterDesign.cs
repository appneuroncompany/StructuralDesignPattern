using AdapterDesignPattern.Model.Abstract;
using AdapterDesignPattern.Model.Concrete;
using System;

namespace AdapterDesignPattern
{
    /// <summary>
    /// Veri yapınızın ihtiyaçlarının veya formatının dışarıdan kullandığınız bir kütüphane, servis vb uyuşmaması durumunda kullanılacak patterndir.
    /// Sizin veri yapınız bu Interface(Arayüze) uymadığında mevcut sınıflarınızı değiştirmek yerine bu sınıfların çevresini kaplayacak(wrapping) adapter sınıflar oluşturulur. 
    /// Bu sayede mevcut çalışan yapıları bozmadan diğer kütüphaneler ile çalışabilecek hale gelmiş olursunuz.
    /// </summary>
    public class AdapterDesign
    {

        public static void TestAdapterDesign()
        {
            IElectricalAppliance fridge = new Fridge();
            PlugIn plugIn = new PlugIn();
            plugIn.PuluginElectricalAppliance(fridge);

            IElectricalAppliance telephon = new TelefonEEAAdapter(new Samsung());
            plugIn.PuluginElectricalAppliance(telephon);
        }

        


    }
}
