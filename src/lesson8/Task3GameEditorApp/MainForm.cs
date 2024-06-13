using Task3GameEditorCore.BelieveOrNotBelieveFunc;

namespace Task3GameEditorApp
{
    public partial class MainForm : Form
    {
        private TrueFalse? _data;

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuItemClose_Click(object sender, EventArgs e) => Close();

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _data = new TrueFalse(dialog.FileName);
                _data.Add("123", true);
                _data.Save();
                numericUpDownNumber.Minimum = 1;
                numericUpDownNumber.Maximum = 1;
                numericUpDownNumber.Value = 1;
            }
        }
    }
}
