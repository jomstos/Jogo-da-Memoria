namespace Jogo___Aula_de_terça
{
    
    public partial class Form1 : Form
    {
        
        int cliques = 0;
        Random random = new Random();


        List<string> icons = new List<string>()
        {
            "🐶", "🐶", "🐱", "🐱", "🦁", "🦁", "🐵", "🐵",
            "🐘", "🐘", "🦓", "🦓", "🦒", "🦒", "🦍", "🦍"
        };



        Label firstClicked = null;
        Label secondClicked = null;
        public string NomeDoJogador { get; set; }

        public Form1(string nome)
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            NomeDoJogador = nome;
            AssignIconsToSquare();

        }

        private void AssignIconsToSquare()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.Click += label1_Click;
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor; // essa linha faz com que as imagens ficam escondidas
                    icons.RemoveAt(randomNumber); // essa linha exclui o numero que ja foi selecionado, para que nao se repita mais de 2x
                    iconLabel.Font = new Font("Segoe UI Emoji", 32, FontStyle.Regular);
                    iconLabel.TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }
            
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                {
                    return;
                }

                cliques++;
                lblCliques.Text = $"Cliques: {cliques}";

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;

                    CheckForWinner();

                    return;
                }

                timer1.Start();
            }
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show($"{NomeDoJogador}, você combinou todos os pares! PARABÉNS! 🎉\nTotal de cliques: {cliques}");

            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}