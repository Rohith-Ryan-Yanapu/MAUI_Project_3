namespace Calculator.Views;

public partial class History : ContentPage
{
	public History()
	{
		InitializeComponent();
		BindingContext = App.historyList;
	}
}