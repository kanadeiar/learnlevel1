namespace Task2GuessNumberApp
{
    public partial class TryInputForm : Form
    {
        public int TryNumber { get; private set; }

        public TryInputForm()
        {
            InitializeComponent();
        }

        private void buttonTry_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out var number))
            {
                TryNumber = number;
                DialogResult = DialogResult.OK;
                return;
            }
            MessageBox.Show("Не удалось разобрать число в текстовом поле.");
        }
    }
}
