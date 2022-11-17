using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator.ViewModels;

public class HistoryPageViewModel 
{


    private ObservableCollection<String> historyCollection;
    public HistoryPageViewModel()
    {
        historyCollection = new ObservableCollection<String>();

        historyCollection.Add("2+3=5");
        historyCollection.Add("2-3=-1");
        historyCollection.Add("2*3=6");
        historyCollection.Add("2/3=0.66");
        historyCollection.Add("2%3=0");
    }

    public ObservableCollection<String> HistoryData
    {
        get => historyCollection;
    }

}