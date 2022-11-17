using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator.ViewModels;

public class HistoryPageViewModel : INotifyPropertyChanged
{

    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<String> historyCollection;
    public HistoryPageViewModel()
    {
        historyCollection = new ObservableCollection<String>();
    }

    public ObservableCollection<String> HistoryData
    {
        get => historyCollection;
    }

    public void AddHistoryList(String exp, String ans)
    {

        historyCollection.Add(exp + "=" + ans);
        OnPropertyChanged("history");
        OnPropertyChanged();
    }

    public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}