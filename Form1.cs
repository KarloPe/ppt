using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piedra_papel_tijera
{
    public partial class Form1 : Form
    {

        string playerChoice;
        string computerChoice;
        string[] Options = { "R", "P", "R", "S", "P", "S", "R", "S", "P", "R", "P", "S" };
        //modo facil gana o empata PIEDRA
        string[] Facil = { "R", "S", "R", "S"};
        //modo hard perdes con piedra
        string[] Hard = { "P", "P", "R", "P", "P", "P", "S" };

        Random random = new Random();
        int computerScore;
        int playerScore;
        string draw;


        public Form1()
        {
            InitializeComponent();
        }

        public int Difi()
        {
            //fija el modo de juego 0=facil 1=normal 2=dificil
            int modo = 1;
            return modo;

        }

        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            int i;

            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;

            //selecciona el modo de juego 0=facil 1=normal 2=dificil
            /*if (Difi() == 0) 
            {
                int i = random.Next(0, Facil.Length);
                computerChoice = Facil[i];
            }
            else if (Difi()==2)
            {
                int i = random.Next(0, Hard.Length);
                computerChoice = Hard[i];
            }
            else
            {
                int i = random.Next(0, Options.Length);
                computerChoice = Options[i];
            }*/

            switch (Difi())
            {
                case 0:
                    i = random.Next(0, Facil.Length);
                    computerChoice = Facil[i];
                    lblModo.Text = "F";
                    break;
                case 1:
                    i = random.Next(0, Options.Length);
                    computerChoice = Options[i];
                    lblModo.Text = "N";
                    break;
                case 2:
                    i = random.Next(0, Hard.Length);
                    computerChoice = Hard[i];
                    lblModo.Text = "H";
                    break;

            }
            


            //int i = random.Next(0, Options.Length);
            //computerChoice = Options[i];
            ///int i = random.Next(0, Facil.Length);
            ////computerChoice = Facil[i];

            lblPlayerchoice.Text = "Humano juega: " + UpdateTextandImage(playerChoice, PLAYER_PIC);
            lblCPUchoice.Text = "Compu juega: " + UpdateTextandImage(computerChoice, CPU_PIC);
            CheckGame();

        }

        private string UpdateTextandImage(string text, PictureBox pic)
        {
            string word = null;
            switch (text)
            {
                case "R":
                    word = "Piedra";
                    pic.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    word = "Papel";
                    pic.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    word = "Tijera";
                    pic.Image = Properties.Resources.SCISSORS;
                    break;
            }
            return word;
        }

        private void CheckGame()
        {
            PictureBox pic = CPU_CARA;
            PictureBox pih = HUM_CARA;

            //si es empate
            if (computerChoice == playerChoice)
            {
                draw = "- Empate -";
                //poner carita
                pic.Image = Properties.Resources.maria;
                pih.Image = Properties.Resources.humempata1;

                lblCPUresult.Text = "Puntos Compu: " + computerScore + Environment.NewLine + draw;
                lblPlayerresult.Text = "Puntos Humano: " + playerScore + Environment.NewLine + draw;
            }
            //si gana compu
            else if (playerChoice == "R" && computerChoice == "P" || playerChoice == "S" && computerChoice == "R" || playerChoice == "P" && computerChoice == "S")
            {
                computerScore++;
                draw = "* Punto para Compu";
                //poner carita
                pic.Image = Properties.Resources.mariagana;
                pih.Image = Properties.Resources.humpierde1;

                lblCPUresult.Text = "Puntos Compu: " + computerScore + Environment.NewLine + draw;
                lblPlayerresult.Text = "Puntos Humano: " + playerScore + Environment.NewLine ;

            }
            // si llega aca entonces x descarte gana humano
            else
            {
                playerScore++;
                draw = "* Punto para Humano";
                //poner carita
                pic.Image = Properties.Resources.mariapierde;
                pih.Image = Properties.Resources.humgana1;

                lblCPUresult.Text = "Puntos Compu: " + computerScore + Environment.NewLine ;
                lblPlayerresult.Text = "Puntos Humano: " + playerScore + Environment.NewLine + draw;

            }
            //lblCPUresult.Text = "Puntos Compu: " + computerScore + Environment.NewLine + draw;
            //lblPlayerresult.Text = "Puntos Humano: " + playerScore + Environment.NewLine + draw;
        }


    }
}
