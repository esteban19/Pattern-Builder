using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CharacterDirector
    {
        //DEFINING THE CHARACTER FACTORY AREA
        private ICharacterBuilder characterBuilder;

        public CharacterDirector(ICharacterBuilder newCharacterBuilder)
        {
            this.characterBuilder = newCharacterBuilder;
        }

        public Character getCharacter()
        {
            return this.characterBuilder.GetCharacter();
        }

        //execute the methods specific to the characterBuilder.
        public void makeCharacter()
        {
            this.characterBuilder.buildCharacterHead();
            this.characterBuilder.buildCharacterChest();
            this.characterBuilder.buildCharacterArms();
            this.characterBuilder.buildCharacterLegs();
        }
    }
}
