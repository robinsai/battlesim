using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortyBattleSimulator
{
    public partial class BattleForm : Form
    {
        PictureBox[] playerBoxes;
        Dictionary<string, CharacterMoves> player1CharacterMoves = new Dictionary<string, CharacterMoves>();
        Dictionary<string, CharacterMoves> compCharacterMoves = new Dictionary<string, CharacterMoves>();

        Character Player1;
        Character Player2;
        int buffPoints = 0;
        int deBuffPoints = 0;
        bool playerBuff = false;
        bool playerDebuff = false;
        bool Buff = false;
        bool Debuff = false;
        static Random ran = new Random();
        bool computersTurn = false;
        static string[] compAttackMoves = new string[4];
        static int chosenCompMove = 0;
        
        public BattleForm(PictureBox[] playerBoxesFromPreviousForm,Character player1, Character player2)
        {
            playerBoxes = playerBoxesFromPreviousForm;
            Player1 = player1;
            Player2 = player2;
            InitializeComponent();
        }
        void resetPoints()
        {
            buffPoints = 0;
            deBuffPoints = 0;
        }
        void executeMoves(bool whosTurnIsIt,Character player1, Character player2)
        {
            if(whosTurnIsIt)
            {
                chosenCompMove = ran.Next(compAttackMoves.Length);
                if(compCharacterMoves[compAttackMoves[chosenCompMove]].attackDebuffOrBuff == moves.attack)
                {
                   player2.
                }
            }
            else
            {

            }
        }
        private void BattleForm_Load(object sender, EventArgs e)
        {
            player1PicBox.Image = playerBoxes[0].Image;
            player2PicBox.Image = playerBoxes[1].Image;
            player2Label.Text = Player2.Name;
            player1Label.Text = Player1.Name;
            for (int i = 0; i < 4; i++)
            {
                if (!player1CharacterMoves.ContainsKey(Player1.nameOfMoves(i)))

                {
                    player1CharacterMoves.Add(Player1.nameOfMoves(i), Player1.moves[i]);
                  
                }
                if (!compCharacterMoves.ContainsKey(Player2.nameOfMoves(i)))
                {
                    compCharacterMoves.Add(Player2.nameOfMoves(i), Player2.moves[i]);
                    compAttackMoves[i] = Player2.nameOfMoves(i);
                }
               
               // listOfComputerAttackBox.Items.Add(Player2.nameOfMoves(i));
                listOfUserComboBox.Items.Add(Player1.nameOfMoves(i));
            }
          
        

            //attack["cry"]
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CharacterMoves selectedMove = player1CharacterMoves[listOfUserComboBox.SelectedText];
            if(selectedMove.attackDebuffOrBuff == moves.attack)
            {
                if(playerBuff)
                {
                    selectedMove.value += buffPoints;
                    buffPoints = 0;
                    playerBuff = false;

                }
                else if(playerDebuff)
                {

                }
                if (compHealthBar.Value < selectedMove.value)
                {
                    compHealthBar.Value -= 0;
                }
                else if (compHealthBar.Value > selectedMove.value)
                {
                    compHealthBar.Value -= selectedMove.value;
                }


            }
            if (selectedMove.attackDebuffOrBuff == moves.buff)
            {
                playerBuff = true;
                Points += selectedMove.value;
            }
            computersTurn = true;
            //selectedMove.
        }
    }
}
