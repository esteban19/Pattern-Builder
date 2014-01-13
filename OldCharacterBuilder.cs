using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class OldCharacterBuilder : ICharacterBuilder
    {
        //DEFINING THE CHARACTER ITSELF
        //^^The most important component - keeps everyone blind
        //to the actual implementation^^;
        private Character character;//Composition
        // Where object's class fields
        // are new objects of the implemented interface.

        public OldCharacterBuilder()
        {
            this.character = new Character();
        }

        public void buildCharacterHead()
        {
            character.setCharacterHead("Soldier Helmet");
        }

        public void buildCharacterChest()
        {
            character.setCharacterChest("Soldier Armor");
        }

        public void buildCharacterArms()
        {
            character.setCharacterArms("Soldier Armguards");
        }

        public void buildCharacterLegs()
        {
            character.setCharacterLegs("Soldier Camos");
        }

        public Character GetCharacter()
        {
            return this.character;
        }
    }
}
