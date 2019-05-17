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
        Dictionary<string, int> attack = new Dictionary<string, int>();
        Character Player1;
        Character Player2;

        public BattleForm(PictureBox[] playerBoxesFromPreviousForm,Character player1, Character player2)
        {
            playerBoxes = playerBoxesFromPreviousForm;
            Player1 = player1;
            Player2 = player2;
            
            InitializeComponent();
        }
        
        private void BattleForm_Load(object sender, EventArgs e)
        {
            player1PicBox.Image = playerBoxes[0].Image;
            player2PicBox.Image = playerBoxes[1].Image;
            player2Label.Text = Player2.Name;
            for (int i = 0; i < 4; i++)
            {
                if (!attack.ContainsKey(Player1.nameOfMoves(i)))
                {
                    attack.Add(Player1.nameOfMoves(i), Player1.valueOfMove(i));
                  
                }
                if (!attack.ContainsKey(Player2.nameOfMoves(i)))
                {
                    attack.Add(Player2.nameOfMoves(i), Player2.valueOfMove(i));
                }
               
                listOfComputerAttackBox.Items.Add(Player2.nameOfMoves(i));
                listOfUserComboBox.Items.Add(Player1.nameOfMoves(i));
            }

        

            //attack["cry"]
        }
    }
}
