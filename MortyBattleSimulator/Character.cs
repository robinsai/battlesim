using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortyBattleSimulator
{
    public class Character
    {

        public Image playerImage;
        int healthPoints;
        string characterName;
        CharacterMoves[] moves;

        Dictionary<string, Func<string, int>> Accounts = new Dictionary<string, Func<string, int>>();
        // Accounts.Add("Cry", Attacks);

        public Character(string characterName, Image playerImage, CharacterMoves[] moves, int healthPoints = 100)
        {
            this.moves = moves;
            this.characterName = characterName;
            this.playerImage = playerImage;
            this.healthPoints = healthPoints;

            for (int i = 0; i < moves.Length; i++)
            {
                Moves.Add(moves[i].nameOfAttack, moves[i]);
            }



        }

  //public void DoSomeAttack(string name, Character enemy)
        //{
        //    CharacterMoves chosenMove = Attacks[name];
        //    if(chosenMove.attackDebuffOrBuff == Enums.moves.attack)
        //    {
        //       // enemy.healthPoints -= chosenMove.
        //    }
        //}


    }
}
