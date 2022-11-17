using Calculator.ViewModels;

namespace Calculator;

public partial class App : Application
{
        public static HistoryPageViewModel historyList;
	public App()
	{

        InitializeComponent();
		MainPage = new AppShell();
        historyList = new HistoryPageViewModel();
        BindingContext = historyList;
    }
}
