using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.Abstract
{
    public abstract class CharController
    {
        ICharacter character;
        public CharController(ICharacter character)
        {
            this.character = character;
        }

        public void RunChar()
        {
            character.run();
        }
        public void WalkChar()
        {
            character.walk();
        }
        public void figthChar()
        {
            character.fight();
        }
    }
}
