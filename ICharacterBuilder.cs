using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ICharacterBuilder
    {
        void buildCharacterHead();
        void buildCharacterChest();
        void buildCharacterArms();
        void buildCharacterLegs();

        Character GetCharacter();
    }
}
