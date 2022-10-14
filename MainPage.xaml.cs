using Telerik.Maui.Controls.Compatibility.DataGrid;
using TelerikDataGridDemo.ViewModels;

namespace TelerikDataGridDemo;

public partial class MainPage : ContentPage
{
	private readonly PersonViewModel viewModel;
	public MainPage()
	{
		InitializeComponent();
		viewModel = new PersonViewModel();
		BindingContext = viewModel;
		dataGrid.SelectItem(viewModel.PersonCollection.Last());
	}

	private void dataGrid_SelectionChanged(object sender, DataGridSelectionChangedEventArgs e)
	{
        var selectedItem = e.AddedItems.FirstOrDefault();
    }

	private void RadButton_Clicked(object sender, EventArgs e)
	{
        dataGrid.SelectItem(viewModel.PersonCollection.Last());
    }
}

