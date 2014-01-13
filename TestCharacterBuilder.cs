using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class TestCharacterBuilder
    {
        public static void Main(string[] args)
        {
                                             //class blueprint
            ICharacterBuilder oldSoldier = new OldCharacterBuilder();

                                 //blueprint passed to be engineered
            CharacterDirector characterDirector = new CharacterDirector(oldSoldier);

                    //create 
            characterDirector.makeCharacter();

            //Builder Pattern: creating the object from other objects
            Character soldier_1 = characterDirector.getCharacter();

            Console.WriteLine("Character Built");
            Console.WriteLine("Character Head Type: " + soldier_1.getCharacterHead());
            Console.WriteLine("Character Chest Type: " + soldier_1.getCharacterChest());
            Console.WriteLine("Character Arms Type: " + soldier_1.getCharacterArms());
            Console.WriteLine("Character Legs Type: " + soldier_1.getCharacterLegs());
        }
    }
}
