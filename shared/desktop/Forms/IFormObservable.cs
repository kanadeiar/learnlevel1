namespace Kanadeiar.Desktop.Forms;

public interface IFormObservable
{
    void AddObserver(IFormObserver formObserver);
    void RemoveObserver(IFormObserver formObserver);
    void NotifyObservers();
}