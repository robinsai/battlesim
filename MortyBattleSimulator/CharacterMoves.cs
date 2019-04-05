using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MortyBattleSimulator.Enums;

namespace MortyBattleSimulator
{
    public struct CharacterMoves
    {  
        public string nameOfAttack;
        int value;
        public moves attackDebuffOrBuff;

        public CharacterMoves(moves move,string nameOfAttack, int value)
        {
            this.attackDebuffOrBuff = move;
            this.nameOfAttack = nameOfAttack;
            this.value = value;
        }
        

    }
}
