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


        public BattleForm(PictureBox[] playerBoxesFromPreviousForm)
        {
            playerBoxes = playerBoxesFromPreviousForm;
         
              comboBox1.SelectedItem = "";
            InitializeComponent();
        }
        
        private void BattleForm_Load(object sender, EventArgs e)
        {

            attack.Add("cry", 10);
            comboBox1.Items.Contains("cry");
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                attack.Add(comboBox1.Items[i].ToString(), 10);
            }

            //attack["cry"]
        }
    }
}
