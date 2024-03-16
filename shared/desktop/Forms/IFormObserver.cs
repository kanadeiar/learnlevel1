namespace Kanadeiar.Desktop.Forms;

public interface IFormObserver
{
    void Update(IFormObservable observed, object? arg);
}