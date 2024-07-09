using Kanadeiar.Desktop.Forms;
using Task4BirthdaysCore.BirthdaysFunc;
using Task4BirthdaysCore.BirthdaysFunc.Abstractions;
using Task4BirthdaysCore.BirthdaysFunc.Base;

namespace Task4BirthdaysApp;

public partial class MainForm : Form, IFormObserver
{
    private Birthdays _birthdays;

    public MainForm()
    {
        InitializeComponent();

        _birthdays = new Birthdays("birthdays.xml");
        _birthdays.AddObserver(this);


    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            var surname = textBoxSurname.Text;
            var name = textBoxName.Text;
            var birth = datePickerBirth.Value;

            _birthdays.Add(new Birthday(surname, name, birth));
        }
        catch (Exception exception)
        {
            MessageBox.Show("Ошибка при создании дня рождения\n" + exception.Message);
        }
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        try
        {
            var surname = textBoxSurname.Text;
            var name = textBoxName.Text;
            var birth = datePickerBirth.Value;

            _birthdays.Edit(listBoxBirthdays.SelectedIndex, new Birthday(surname, name, birth));
        }
        catch (Exception exception)
        {
            MessageBox.Show("Ошибка при редактирования дня рождения\n" + exception.Message);
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        try
        {
            _birthdays.Remove(_birthdays.Selected);
        }
        catch (Exception exception)
        {
            MessageBox.Show("Ошибка при удалении дня рождения\n" + exception.Message);
        }
    }

    private void toolStripNew_Click(object sender, EventArgs e)
    {
        using var dialog = new SaveFileDialog
        {
            InitialDirectory = Application.StartupPath,
            Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
        };
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            if (!dialog.FileName.EndsWith(".xml"))
                dialog.FileName += ".xml";

            _birthdays.RemoveObserver(this);
            _birthdays = new Birthdays(dialog.FileName);
            _birthdays.AddObserver(this);

            try
            {
                _birthdays.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка создания нового файла.\n{exception.Message}", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Update(_birthdays, EventArgs.Empty);
        }
    }

    private void toolStripOpen_Click(object sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            InitialDirectory = Application.StartupPath,
            Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
        };
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            _birthdays.RemoveObserver(this);
            _birthdays = new Birthdays(dialog.FileName);
            _birthdays.AddObserver(this);

            try
            {
                _birthdays.Load();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка открытия файла.\n{exception.Message}", "Открытие файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Update(_birthdays, EventArgs.Empty);
        }
    }

    public void Update(IFormObservable observed, object? arg)
    {
        if (observed is ICommonBirthdays birthdays)
        {
            labelFilePath.Text = birthdays.FileName;

            var selectedIndex = listBoxBirthdays.SelectedIndex;
            listBoxBirthdays.Items.Clear();
            foreach (var each in birthdays)
            {
                listBoxBirthdays.Items.Add($"{each.Surname} {each.Name} {each.Birth:dd.MM.yyyy}");
            }
            if (selectedIndex >= birthdays.Count())
            {
                selectedIndex = birthdays.Count() - 1;
            }
            listBoxBirthdays.SelectedIndex = selectedIndex;

            textBoxSurname.Text = birthdays.Selected.Surname;
            textBoxName.Text = birthdays.Selected.Name;
            datePickerBirth.Value = birthdays.Selected.Birth;
        }
    }

    private void toolStripSave_Click(object sender, EventArgs e)
    {
        if (!_birthdays.Any())
        {
            MessageBox.Show("Пустой список дней рождения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            _birthdays.Save();
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
        }
    }

    private void toolStripSaveAs_Click(object sender, EventArgs e)
    {
        if (!_birthdays.Any())
        {
            MessageBox.Show("Пустой список дней рождения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using var dialog = new SaveFileDialog
        {
            InitialDirectory = Application.StartupPath,
            Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
        };
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            if (!dialog.FileName.EndsWith(".xml"))
                dialog.FileName += ".xml";

            var newest = new Birthdays(dialog.FileName);
            var old = _birthdays.ToArray();
            for (var i = 0; i < _birthdays.Count(); i++)
            {
                newest.Add(old[i]);
            }

            _birthdays.RemoveObserver(this);
            _birthdays = newest;
            _birthdays.AddObserver(this);

            try
            {
                _birthdays.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
            }
        }
    }

    private void toolStripClose_Click(object sender, EventArgs e) => Close();

    private void toolStripAbout_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Приложение хранения дней рождений.", "Сведения о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void listBoxBirthdays_SelectedIndexChanged(object sender, EventArgs e)
    {
        _birthdays.Select(listBoxBirthdays.SelectedIndex);
    }
}