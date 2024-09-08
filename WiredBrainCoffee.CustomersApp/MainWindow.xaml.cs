using System.Windows;
using System.Windows.Controls;

namespace WiredBrainCoffee.CustomersApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
		{
			btnAddCustomer.Content = "Customer edit";
		}

		private void ButtonMoveCustomerList_Click(object sender, RoutedEventArgs e)
		{
			//var column = (int)customerListGridElement.GetValue(Grid.ColumnProperty);

			//var newColumn = column == 0 ? 2 : 0;

			//customerListGridElement.SetValue(Grid.ColumnProperty, newColumn);

			var column = Grid.GetColumn(customerListGridElement);

			var newColumn = column == 0 ? 2 : 0;

			Grid.SetColumn(customerListGridElement, newColumn);
		}
	}
}