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
			CreateBasicPieChart();

			CreateBasicScatterChart();

			CreateBasicBarChart();
		}

		private void CreateBasicPieChart()
		{
			ScottPlot.Plot myPlot = new();

			PieSlice slice1 = new() { Value = 80, FillColor = ScottPlot.Colors.Red, Label = "alpha", LegendText = "Alpha" };
			PieSlice slice2 = new() { Value = 5, FillColor = ScottPlot.Colors.Orange, Label = "beta", LegendText = "Beta" };
			PieSlice slice3 = new() { Value = 25, FillColor = ScottPlot.Colors.Gold, Label = "gamma" };
			PieSlice slice4 = new() { Value = 31, FillColor = ScottPlot.Colors.Green, Label = "delta", LegendText = "Delta" };
			PieSlice slice5 = new() { Value = 13, FillColor = ScottPlot.Colors.Blue, Label = "epsilon" };

			List<PieSlice> slices = new() { slice1, slice2, slice3, slice4, slice5 };

			var pie = myPlot.Add.Pie(slices);
			pie.ExplodeFraction = .1;

			myPlot.HideAxesAndGrid();

			WPFPiePlot.Reset(myPlot);
			WPFPiePlot.Refresh();
		}
		private void CreateBasicScatterChart()
		{
			ScottPlot.Plot myPlot = new();

			string[] XValuesString = { "day1", "day2", "day3", "day4", "day5", "day6" };
			double[] XValues = { 1, 2, 3, 4, 5, 6 };
			double[] YValues = { 4, 30, 13, 25, 30, 35 };

			myPlot.Add.Scatter(XValues, YValues);

			WPFScatterPlot.Reset(myPlot);
			WPFScatterPlot.Refresh();
		}
		private void CreateBasicBarChart()
		{
			ScottPlot.Plot myPlot = new();

			double[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 };

			var barPlot = myPlot.Add.Bars(values);

			foreach (var bar in barPlot.Bars)
			{
				bar.Label = bar.Value.ToString();
			}

			WPFBarPlot.Reset(myPlot);
			WPFBarPlot.Refresh();
		}
	}
}