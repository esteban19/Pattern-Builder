using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Character : ICharacterPlan
    {
        private string characterHead;
        private string characterChest;
        private string characterArms;
        private string characterLegs;

        public string getCharacterHead() { return this.characterHead; }
        public string getCharacterChest() { return this.characterChest; }
        public string getCharacterArms() { return this.characterArms; }
        public string getCharacterLegs() { return this.characterLegs; }

        public void setCharacterHead(string head)
        {
            characterHead = head;
        }

        public void setCharacterChest(string chest)
        {
            characterChest = chest;
        }

        public void setCharacterArms(string arms)
        {
            characterArms = arms;
        }

        public void setCharacterLegs(string legs)
        {
            characterLegs = legs;
        }
    }
}
