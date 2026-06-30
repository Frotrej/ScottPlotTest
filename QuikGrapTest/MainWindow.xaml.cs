using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Linq;
using ScottPlot;
using ScottPlot.WPF;

namespace QuikGrapTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object? sender, RoutedEventArgs e)
		{

			ScottPlot.Plot myPlot = new();

			PieSlice slice1 = new() { Value = 80, FillColor = ScottPlot.Colors.Red, Label = "alpha", LegendText = "Alpha" };
			PieSlice slice2 = new() { Value = 5, FillColor = ScottPlot.Colors.Orange, Label = "beta", LegendText = "Beta" };
			PieSlice slice3 = new() { Value = 25, FillColor = ScottPlot.Colors.Gold, Label = "gamma"};
			PieSlice slice4 = new() { Value = 31, FillColor = ScottPlot.Colors.Green, Label = "delta", LegendText = "Delta" };
			PieSlice slice5 = new() { Value = 13, FillColor = ScottPlot.Colors.Blue, Label = "epsilon"};

			List<PieSlice> slices = new() { slice1, slice2, slice3, slice4, slice5 };

			var pie = myPlot.Add.Pie(slices);
			pie.ExplodeFraction = .1;

			myPlot.HideAxesAndGrid();
			

			PiePlot.Reset(myPlot);
			PiePlot.Refresh();


			//co to ma byc xD
			// Disable mouse interactions that would pan/zoom/move the plot while the app is running
			// Use Preview* so events are handled before ScottPlot's handlers run.
			/*PiePlot.PreviewMouseDown += (s, ev) => ev.Handled = true;
			PiePlot.PreviewMouseMove += (s, ev) => ev.Handled = true;
			PiePlot.PreviewMouseUp += (s, ev) => ev.Handled = true;
			PiePlot.PreviewMouseWheel += (s, ev) => ev.Handled = true;*/
		}
	}
}