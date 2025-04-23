
namespace Jogo___Aula_de_terça
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Broadway", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 71);
            label1.Name = "label1";
            label1.Size = new Size(582, 50);
            label1.TabIndex = 0;
            label1.Text = "Jogo Da Memória - ZOO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Broadway", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(286, 235);
            button1.Name = "button1";
            button1.Size = new Size(228, 59);
            button1.TabIndex = 1;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-161, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(255, 224, 192);
            txtNome.Location = new Point(378, 186);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(183, 27);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(139, 187);
            label2.Name = "label2";
            label2.Size = new Size(233, 26);
            label2.TabIndex = 4;
            label2.Text = "Digite seu nome:";
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = Properties.Resources.cartaVirada;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "TelaInicial";
            Text = "Tela Inicial";
            Load += TelaInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 jogo = new Form1(); // Form1 é sua tela do jogo
            jogo.Show();
            this.Hide(); // Esconde a tela inicial

        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox txtNome;
        private Label label2;
    }
}