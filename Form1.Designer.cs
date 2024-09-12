namespace piedra_papel_tijera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            CPU_PIC = new PictureBox();
            PLAYER_PIC = new PictureBox();
            lblCPUchoice = new Label();
            lblPlayerchoice = new Label();
            lblPlayerresult = new Label();
            lblCPUresult = new Label();
            CPU_CARA = new PictureBox();
            HUM_CARA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CPU_PIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CPU_CARA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HUM_CARA).BeginInit();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Font = new Font("Segoe UI", 12.3076925F, FontStyle.Bold);
            btnRock.Location = new Point(86, 375);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(147, 63);
            btnRock.TabIndex = 0;
            btnRock.Tag = "R";
            btnRock.Text = "PIEDRA";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += MakeChoiceEvent;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Segoe UI", 12.3076925F, FontStyle.Bold);
            btnPaper.Location = new Point(325, 375);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(147, 63);
            btnPaper.TabIndex = 1;
            btnPaper.Tag = "P";
            btnPaper.Text = "PAPEL";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += MakeChoiceEvent;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("Segoe UI", 12.3076925F, FontStyle.Bold);
            btnScissors.Location = new Point(583, 375);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(147, 63);
            btnScissors.TabIndex = 2;
            btnScissors.Tag = "S";
            btnScissors.Text = "TIJERA";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += MakeChoiceEvent;
            // 
            // CPU_PIC
            // 
            CPU_PIC.BackColor = Color.Transparent;
            CPU_PIC.Location = new Point(350, 53);
            CPU_PIC.Name = "CPU_PIC";
            CPU_PIC.Size = new Size(99, 99);
            CPU_PIC.SizeMode = PictureBoxSizeMode.Zoom;
            CPU_PIC.TabIndex = 3;
            CPU_PIC.TabStop = false;
            // 
            // PLAYER_PIC
            // 
            PLAYER_PIC.BackColor = Color.Transparent;
            PLAYER_PIC.Location = new Point(350, 211);
            PLAYER_PIC.Name = "PLAYER_PIC";
            PLAYER_PIC.Size = new Size(99, 99);
            PLAYER_PIC.SizeMode = PictureBoxSizeMode.Zoom;
            PLAYER_PIC.TabIndex = 4;
            PLAYER_PIC.TabStop = false;
            // 
            // lblCPUchoice
            // 
            lblCPUchoice.AutoSize = true;
            lblCPUchoice.Font = new Font("Segoe UI Semibold", 12.3076925F, FontStyle.Bold);
            lblCPUchoice.Location = new Point(289, 9);
            lblCPUchoice.Name = "lblCPUchoice";
            lblCPUchoice.Size = new Size(209, 30);
            lblCPUchoice.TabIndex = 5;
            lblCPUchoice.Text = "Jugada de la Compu";
            // 
            // lblPlayerchoice
            // 
            lblPlayerchoice.AutoSize = true;
            lblPlayerchoice.Font = new Font("Segoe UI Semibold", 12.3076925F, FontStyle.Bold);
            lblPlayerchoice.Location = new Point(289, 324);
            lblPlayerchoice.Name = "lblPlayerchoice";
            lblPlayerchoice.Size = new Size(204, 30);
            lblPlayerchoice.TabIndex = 6;
            lblPlayerchoice.Text = "Jugada del Humano";
            // 
            // lblPlayerresult
            // 
            lblPlayerresult.AutoSize = true;
            lblPlayerresult.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPlayerresult.Location = new Point(40, 156);
            lblPlayerresult.Name = "lblPlayerresult";
            lblPlayerresult.Size = new Size(194, 23);
            lblPlayerresult.TabIndex = 7;
            lblPlayerresult.Text = "Resultados del Humano";
            // 
            // lblCPUresult
            // 
            lblCPUresult.AutoSize = true;
            lblCPUresult.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCPUresult.Location = new Point(583, 211);
            lblCPUresult.Name = "lblCPUresult";
            lblCPUresult.Size = new Size(197, 23);
            lblCPUresult.TabIndex = 8;
            lblCPUresult.Text = "Resultados de la Compu";
            // 
            // CPU_CARA
            // 
            CPU_CARA.BackColor = Color.Transparent;
            CPU_CARA.Location = new Point(583, 53);
            CPU_CARA.Name = "CPU_CARA";
            CPU_CARA.Size = new Size(152, 143);
            CPU_CARA.SizeMode = PictureBoxSizeMode.Zoom;
            CPU_CARA.TabIndex = 9;
            CPU_CARA.TabStop = false;
            // 
            // HUM_CARA
            // 
            HUM_CARA.BackColor = Color.Transparent;
            HUM_CARA.Location = new Point(81, 211);
            HUM_CARA.Name = "HUM_CARA";
            HUM_CARA.Size = new Size(152, 143);
            HUM_CARA.SizeMode = PictureBoxSizeMode.Zoom;
            HUM_CARA.TabIndex = 10;
            HUM_CARA.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(HUM_CARA);
            Controls.Add(CPU_CARA);
            Controls.Add(lblCPUresult);
            Controls.Add(lblPlayerresult);
            Controls.Add(lblPlayerchoice);
            Controls.Add(lblCPUchoice);
            Controls.Add(PLAYER_PIC);
            Controls.Add(CPU_PIC);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "PIEDRA PAPEL o TIJERA";
            ((System.ComponentModel.ISupportInitialize)CPU_PIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)CPU_CARA).EndInit();
            ((System.ComponentModel.ISupportInitialize)HUM_CARA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private PictureBox CPU_PIC;
        private PictureBox PLAYER_PIC;
        private Label lblCPUchoice;
        private Label lblPlayerchoice;
        private Label lblPlayerresult;
        private Label lblCPUresult;
        private PictureBox CPU_CARA;
        private PictureBox HUM_CARA;
    }
}
