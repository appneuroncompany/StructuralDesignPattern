using CompositeDesignPattern.Concrete;
using System;

namespace CompositeDesignPattern
{
    public enum Rank
    {
        General,
        Colonel,
        LieutenantColonel,
        Major,
        Captain,
        Lieutenant
    }

    /// <summary>
    /// Ağaç veri yapısında olan kendi içerisinde kendi türünden çocuk sınıflar tutan ve belli ortak işlevleri getirebilen yapılar için kullanılan bir örüntüdür.
    /// Kullanım alanları: Menu yapıları (PopupMenu, Menus, TreeMenu vb..),  UI Component yapıları (JPanel, JTextfield vb..), Klasör ve Dosya yapıları
    /// </summary>
    public class CompositeDesign
    {

        
        public static void TestCompositeDesign()
        {
            SeniorMilitary generalBurak = new SeniorMilitary("Burak", Rank.General);

            SeniorMilitary colonelİbrahim = new SeniorMilitary("İbrahim", Rank.Colonel);
            colonelİbrahim.AddSoldier(new UnconditionalSoldier("Cem", Rank.Major));

            generalBurak.AddSoldier(new UnconditionalSoldier("Ahmet", Rank.Colonel));
            generalBurak.AddSoldier(colonelİbrahim);

            generalBurak.ExecuteOrder();


        }

    }
}
