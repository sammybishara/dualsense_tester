using System.Windows.Media;
using System.Windows;
using System.Windows.Navigation;

public static class DrawingImageCreator
{
	public static DrawingImage CreateDualSenseDrawingImage()
	{

		// X icon
		GeometryDrawing xIconGD = new GeometryDrawing
		{
			Pen = new Pen
			{
				Brush = Brushes.Black,
				Thickness = 4,
				StartLineCap = PenLineCap.Round,
				EndLineCap = PenLineCap.Round,
				LineJoin = PenLineJoin.Round,
			},
			Geometry = Geometry.Parse("F0 M1117,892z M0,0z M1639.49,679.525L1672.29,712.319 M1672.29,679.525L1639.49,712.319")
		};

		DrawingGroup xIcon = new DrawingGroup
		{
			Opacity = 1.0,
			Transform = new MatrixTransform(
            new Matrix(
                1.04799,
                0,
                0,
                1.02376,
                -60.1837,
                -20.9858
            )
			)
        };
	
		xIcon.Children.Add(xIconGD);

		//// Square Icon
		GeometryDrawing squareIconGD = new GeometryDrawing
		{
			Pen = new Pen
			{
				Brush = Brushes.Black,
				Thickness = 4.54,
				StartLineCap = PenLineCap.Round,
				EndLineCap = PenLineCap.Round,
				LineJoin = PenLineJoin.Round,
			},

			Geometry = new RectangleGeometry(
				new Rect(1634.48, 533.609, 37.307, 37.307),
				0,
				0
			)
		};
		DrawingGroup squareIcon = new DrawingGroup
		{
			Opacity = 1.0,
			Transform = new MatrixTransform(0.923202, 0, 0, 0.90186, 75.2895, 121.747)

		};
		squareIcon.Children.Add(squareIconGD);

		//// Triangle Icon
		GeometryDrawing triangleIconGD = new GeometryDrawing
		{
			Geometry = Geometry.Parse("F0 M1117,892z M0,0z M1668.06,540.081L1689.09,574.313 1647.02,574.313 1668.06,540.081z"),
			Pen = new Pen
			{
				Brush = Brushes.Black,
				Thickness = 4.13,
				StartLineCap = PenLineCap.Round,
				EndLineCap = PenLineCap.Round,
				LineJoin = PenLineJoin.Round
			}
		};
		DrawingGroup triangleIcon = new DrawingGroup
		{
			Opacity = 1.0,
			Transform = new MatrixTransform(
				new Matrix(1.00662, 0, 0, 0.997527, -3.92375, -7.67218)
			)
		};
		triangleIcon.Children.Add(triangleIconGD);

		//// Circle Button Icon
		GeometryDrawing circleIconGD = new GeometryDrawing
		{
			Pen = new Pen
			{
				Brush = Brushes.Black,
				Thickness = 4,
				StartLineCap = PenLineCap.Round,
				EndLineCap = PenLineCap.Round,
				LineJoin = PenLineJoin.Round
			},
			Geometry = new EllipseGeometry
			{
				RadiusX = 19.1,
				RadiusY = 19.1,
				Center = new Point(1729.14, 623.366)

			}
		};
		DrawingGroup circleIcon = new DrawingGroup
		{
			Opacity = 1.0,
			Transform = new MatrixTransform(
				new Matrix(1.04799, 0, 0, 1.02376, -63.5968, -18.369)
			)
		};
		circleIcon.Children.Add(circleIconGD);




		// Final
		DrawingGroup drawing_2 = new DrawingGroup();
        drawing_2.Opacity = 1.0;
        drawing_2.Transform = new MatrixTransform(
            new Matrix(
                0.954207,
                0,
                0,
                0.976787,
                -664.382,
                -247.343
            )
        );

		drawing_2.Children.Add(xIcon);
		drawing_2.Children.Add(squareIcon);
		drawing_2.Children.Add(triangleIcon);
		drawing_2.Children.Add(circleIcon);


		DrawingGroup drawing_1 = new DrawingGroup();
        drawing_1.ClipGeometry = Geometry.Parse("M0,0 V892 H1117 V0 H0 Z");
		drawing_1.Children.Add(drawing_2);


        DrawingImage dualsense_pic = new DrawingImage();
		dualsense_pic.Drawing = drawing_1;

        return dualsense_pic;
    }
}
