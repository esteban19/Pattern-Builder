using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ICharacterPlan
    {
        void setCharacterHead(string head);
        void setCharacterChest(string chest);
        void setCharacterArms(string arms);
        void setCharacterLegs(string legs);
    }
}
