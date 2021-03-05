using FlyweightDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern.Concrete
{
    public class SevenZip : IZip
    {
        public void ZipDocument(string CharArray)
        {
            string document = CharArray;
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            foreach (char c in chars)
            {
                Character character = factory.GetCharacter(c);
                character.State();
            }
        }
    }
}
