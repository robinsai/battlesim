using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortyBattleSimulator
{
    public struct CharacterAttack
    {
        string nameOfAttack;
        int attackValue;

        public CharacterAttack(string nameOfAttack, int attackValue)
        {
            this.nameOfAttack = nameOfAttack;
            this.attackValue = attackValue;
        }
    }
}
