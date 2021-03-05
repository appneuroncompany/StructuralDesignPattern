using FlyweightDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern.Concrete
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> _characters =
                  new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            Character character = null;

            if (_characters.ContainsKey(key))
            {
                Console.WriteLine("Ramdan kopya kullanıldı...");
                character = _characters[key];

            }

            else
            {
                Console.WriteLine("Ram'e yeni obje oluşturuldu");

                switch (key)
                {
                    case 'A': character = new CharA(); break;
                    case 'B': character = new CharB(); break;
                    case 'C': character = new CharC(); break;
                }

                _characters.Add(key, character);
            }

            return character;
        }
    }
}
