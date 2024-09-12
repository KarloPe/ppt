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
        string[] Options = { "R", "P", "S", "R", "P", "S", "R", "P", "S" };
        //modo facil mas chance de ganar con piedra
        string[] Facil = { "R", "P", "S", "R", "S", "R", "S" };

        Random random = new Random();
        int computerScore;
        int playerScore;
        string draw;


        public Form1()
        {
            InitializeComponent();
        }



        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;
            //int i = random.Next(0, Options.Length);
            //computerChoice = Options[i];
            int i = random.Next(0, Facil.Length);
            computerChoice = Facil[i];
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
                pih.Image = Properties.Resources.humempata;

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
                pih.Image = Properties.Resources.humpierde;

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
                pih.Image = Properties.Resources.humgana;

                lblCPUresult.Text = "Puntos Compu: " + computerScore + Environment.NewLine ;
                lblPlayerresult.Text = "Puntos Humano: " + playerScore + Environment.NewLine + draw;

            }
            //lblCPUresult.Text = "Puntos Compu: " + computerScore + Environment.NewLine + draw;
            //lblPlayerresult.Text = "Puntos Humano: " + playerScore + Environment.NewLine + draw;
        }


    }
}
