using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace QuikGrapTest
{
	public static class GraphRenderer
	{
		public static void Render(Canvas canvas)
		{
			if (canvas == null) return;
			// Rendering is performed by MainWindow using its GraphCanvas.
			// This parameterless method is kept for compatibility; MainWindow
			// will call rendering helpers that access the canvas instance.
			canvas.Children.Clear();
		}
	}
}
