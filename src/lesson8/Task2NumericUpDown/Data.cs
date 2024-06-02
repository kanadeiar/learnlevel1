using Kanadeiar.Desktop.Forms;

namespace Task2NumericUpDown;

public class Data : ModelBase
{
    private decimal _value;

    public decimal Value
    {
        get => _value;
        set
        {
            if (Set(ref _value, value))
            {
                Text = value.ToString();
            }
        }
    }

    private string _text;

    public string Text
    {
        get => _text;
        set
        {
            if (Set(ref _text, value))
            {
                if (decimal.TryParse(value, out var newValue))
                {
                    Value = newValue;
                }
            }
        }
    }
}