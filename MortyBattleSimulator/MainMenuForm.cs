using MortyBattleSimulator.Properties;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        // Character[] Mortys
        bool toBeClick = true;
        bool toBeSelect = true;
        bool playMenu = true;
      //  PictureBox computerPlayer;
       // Character player1;
        //Character player2;
        Size originalPlayer1PicBox = new Size(236, 370);
        PictureBox[] mortys;
        PictureBox[] playerBoxes;

        Dictionary<string, CharacterMoves> Moves = new Dictionary<string, CharacterMoves>()
            {
                {  "Outburst", new CharacterMoves(moves.attack, "Outburst", 20) },
                {"Cry", new CharacterMoves(moves.debuff,"Cry",15) },
                {"Flail",  new CharacterMoves(moves.attack,"Flail",20)  },
                {"JuiceBox",  new CharacterMoves(moves.buff,"JuiceBox",20)    },
                {"Provoke",  new CharacterMoves(moves.debuff,"Provoke", 15) },
                {"KarateChop",  new CharacterMoves(moves.attack,"KarateChop",20) },
                {"StareDown",  new CharacterMoves(moves.debuff,"StareDown", 15) },
                {"RetainStrength",  new CharacterMoves(moves.buff,"RetainStrength",20) },
                {"CallJerry",  new CharacterMoves(moves.debuff,"CallJerry",20) },
                {"FlowerChild",  new CharacterMoves(moves.buff,"FlowerChild",15) },
                {"Dig",  new CharacterMoves(moves.buff,"Dig",15) },
                {"Relax",  new CharacterMoves(moves.buff,"Relax,",20) },
                {"CallRick",  new CharacterMoves(moves.buff,"CallRick",100) }
            };
        CharacterMoves[] OGMortyMoves;
        CharacterMoves[] ScruffyMortyMoves;
        CharacterMoves[] GhostMortyMoves;
        CharacterMoves[] HippeMortyMoves;
        CharacterMoves[] KarateMortyMoves;
        CharacterMoves[] ZombieMortyMoves;
        void settingPictureSizeToDefault(PictureBox pics)
        {
            pics.Size.Equals(originalPlayer1PicBox);
        }
        void hoverOverPicture(object sender, EventArgs e)
        {
            if (toBeClick)
            {
                PictureBox pictureBox = (PictureBox)sender;
                player1PicBox.Image = pictureBox.Image;
            }
        }
        //fix thisV
        void hoverAwayPicture(object sender, EventArgs e)
        {
            if (toBeClick)
            {
                player1PicBox.Image = Properties.Resources.shadowMorty;
                settingPictureSizeToDefault((PictureBox)sender);
            }
        }
        void clickOnCharacter(object sender, EventArgs e)
        {
            toBeClick = false;
            if (toBeSelect)
            {
                PictureBox pictureBox = (PictureBox)sender;
                player1PicBox.Image = pictureBox.Image;
                //player1 = new Character(player1PicBox.Image);
            }
        }
        void fighterSelectMenu(bool show)
        {
            if (show)
            {
                appearFighters(mortys, playerBoxes);
                versusPicBox.Visible = true;
            }


        }
        void disappearFighters(PictureBox[] pics, PictureBox[] playerbox)
        {
            for (int i = 0; i < pics.Length; i++)
            {
                pics[i].Visible = false;

            }
            for (int i = 0; i < playerBoxes.Length; i++)
            {
                playerBoxes[i].Visible = false;
            }


        }
        void appearFighters(PictureBox[] mortyPics, PictureBox[] playerBoxes)
        {
            for (int i = 0; i < mortyPics.Length; i++)
            {
                mortyPics[i].Visible = true;
            }
            for (int i = 0; i < playerBoxes.Length; i++)
            {
                playerBoxes[i].Visible = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           

            OGMortyMoves = new CharacterMoves[] { Moves["Outburst"], Moves["Cry"], Moves["JuiceBox"], Moves["CallRick"] };
            ScruffyMortyMoves = new CharacterMoves[] { Moves["RetainStrength"], Moves["StareDown"], Moves["Cry"], Moves["Relax"] };
            GhostMortyMoves = new CharacterMoves[] { Moves["StareDown"], Moves["Dig"], Moves["Provoke"], Moves["Outburst"] };
            HippeMortyMoves = new CharacterMoves[] { Moves["FlowerChild"], Moves["CallJerry"], Moves["Provoke"], Moves["JuiceBox"] };
            KarateMortyMoves = new CharacterMoves[] { Moves["KarateChop"], Moves["StareDown"], Moves["CallRick"], Moves["Flail"] };
            ZombieMortyMoves = new CharacterMoves[] { Moves["Dig"], Moves["Cry"], Moves["StareDown"], Moves["Outburst"] };


            playerBoxes = new PictureBox[2];
            mortys = new PictureBox[6];
            Character[] characters = new Character[6];
            //4-9-2019~~~~~~~~~dont forget to give them their unique moves
             characters[0] = new Character("OGMorty",OGPicBox.Image,OGMortyMoves);
             characters[1]= new Character("OGMorty",OGPicBox.Image,OGMortyMoves);
             characters[2]= new Character("OGMorty",OGPicBox.Image,OGMortyMoves);
             characters[3]= new Character("OGMorty",OGPicBox.Image,OGMortyMoves);
             characters[4]= new Character("OGMorty",OGPicBox.Image,OGMortyMoves);
             characters[5]= new Character("OGMorty",OGPicBox.Image,OGMortyMoves);
             
        
            
            
            //CharacterMoves[] attacksForScruffy = new CharacterMoves[4];
            //attacksForScruffy[0] = new CharacterMoves("Cry", 20);
            //  characters[0] = new Character("scruffyPicBox",mortys[0].Image,)
            for (int i = 0; i < mortys.Length; i++)
            {
                mortys[i] = new PictureBox();
            }
             for (int i = 0; i < playerBoxes.Length; i++)
            {

                playerBoxes[i] = new PictureBox();

            }


            mortys[0] = scruffyPicBox;
            mortys[1] = ghostPicBox;
            mortys[2] = OGPicBox;
            mortys[3] = karatePicBox;
            mortys[4] = hippiePicBox;
            mortys[5] = zombiePicBox;
            playerBoxes[0] = player1PicBox;
            playerBoxes[1] = player2PicBox;
         

          
            
         
            disappearFighters(mortys,playerBoxes);
            player1Ready.Visible = false;
        }



        private void startButton_Click(object sender, EventArgs e)
        {
            if (playMenu)
            {
                fighterSelectMenu(true);
                startButton.Visible = false;
                player1Ready.Visible = true;
                playMenu = false;
            }
            else
            {
                Random computerRandomSelect = new Random(mortys.Length);
               // player2 = new Character(mortys[computerRandomSelect.Next(mortys.Length)].Image);
               // player2PicBox.Image = player2.playerImage;

                BattleForm battleForm = new BattleForm(playerBoxes);
                battleForm.Show();
                    
            }
        }

        /*
         * BattleForm form = new BattleForm(playerBoxes)
         * 
         */

        private void player1Ready_CheckedChanged(object sender, EventArgs e)
        {
            if (player1Ready.Checked == true)
            {
                toBeSelect = false;
                startButton.Visible = true;
            }
            else
            {
                toBeSelect = true;
            }

        }
    }
}

