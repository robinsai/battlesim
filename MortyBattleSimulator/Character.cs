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
        public string Name;
        public  CharacterMoves[] moves;

        Dictionary<string, Func<string, int>> Accounts = new Dictionary<string, Func<string, int>>();
        // Accounts.Add("Cry", Attacks);

        public Character(string characterName, Image playerImage, CharacterMoves[] moves, int healthPoints = 100)
        {
            
            this.Name = characterName;
            this.playerImage = playerImage;
            this.healthPoints = healthPoints;
            this.moves = moves;
           


        }
        public string nameOfMoves(int i)
        {
            string name = moves[i].nameOfAttack;
            return name;
        }
        public int valueOfMove(int i)
        {
            return moves[i].value;
        }
        public void DoesMove()
        {


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
