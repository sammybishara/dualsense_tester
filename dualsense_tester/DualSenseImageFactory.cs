using System.Windows.Media;
using System.Windows;
using System.Windows.Navigation;

public class DrawingImageCreator
{
	public DrawingImage CreateDualSenseDrawingImage()
	{

		// X icon and outline
		var xButton = DrawXButton();
		DrawingGroup xIcon = xButton.Item1;
		DrawingGroup xButtonOutline = xButton.Item2;

		//// Square Icon and outline
		var squareButton = CreateSquareButton();
		DrawingGroup squareIcon = squareButton.Item1;
		DrawingGroup squareButtonOutline = squareButton.Item2;


		//// Triangle Icon and outline
		var trianglebutton = CreateTriangleButton();
		DrawingGroup triangleIcon = trianglebutton.Item1;
		DrawingGroup triangleButtonOutline = trianglebutton.Item2;

		//// Circle button icon and outline
		var circleButton = CreateCircleButton();
		DrawingGroup circleIcon = circleButton.Item1;
		DrawingGroup circleOutline = circleButton.Item2;

		// R2 Button 
		DrawingGroup r2Button = CreateTriggerButton(3.46, "F0 M1117,892z M0,0z M1579.77,357.225L1679.77,357.225C1690.55,357.225 1678.68,262.657 1610.67,262.657 1578,262.657 1565.31,357.225 1579.77,357.225z", new Matrix(1.19695, 0, 0, 1.20074, -286.588, -56.1541));

		//
		// L2 Button
		//
		DrawingGroup l2Button = CreateTriggerButton(3.46, "F0 M1117,892z M0,0z M1579.77,357.225L1679.77,357.225C1690.55,357.225 1678.68,262.657 1610.67,262.657 1578,262.657 1565.31,357.225 1579.77,357.225z", new Matrix(-1.19695, 0, 0, 1.20074, 2851.49, -56.1541));


		//
		// Up d pad key
		//
		// outline for d pad key
		DrawingGroup upButton = CreateDPadButton("F0 M1117,892z M0,0z M934.408,542.109C934.408,530.894,925.317,521.803,914.103,521.803L885.214,521.803C874,521.803,864.909,530.894,864.909,542.109L864.909,566.444C864.909,572.731 867.306,578.78 871.612,583.36 878.468,590.653 888.943,601.795 894.962,608.198 896.181,609.494 897.88,610.229 899.658,610.229 901.437,610.229 903.136,609.494 904.355,608.198 910.374,601.795 920.849,590.653 927.705,583.36 932.011,578.78 934.408,572.731 934.408,566.444 934.408,559.679 934.408,550.432 934.408,542.109z",
												"F0 M1117, 892z M0, 0z M889.258, 543.129L907.916, 543.129 898.835, 534.049 889.258, 543.129z",
												new Matrix(1.04799, 0, 0, 1.02376, -59.2527, -26.3824),
												new Matrix(1.04799, 0, 0, 1.02376, -59.2527, -26.3824)
												);
		//
		// Down D pad Button 
		//
		DrawingGroup downButton = CreateDPadButton("F0 M1117,892z M0,0z M934.408,542.109C934.408,530.894,925.317,521.803,914.103,521.803L885.214,521.803C874,521.803,864.909,530.894,864.909,542.109L864.909,566.234C864.909,572.646 867.402,578.806 871.862,583.412 878.746,590.522 889.092,601.208 895.028,607.339 896.242,608.593 897.913,609.301 899.658,609.301 901.404,609.301 903.075,608.593 904.289,607.339 910.225,601.208 920.571,590.522 927.455,583.412 931.914,578.806 934.408,572.646 934.408,566.234 934.408,559.488 934.408,550.346 934.408,542.109z",
													"F0 M1117,892z M0,0z M889.258,543.129L907.916,543.129 898.835,534.049 889.258,543.129z",
													new Matrix(1, 0, 0, 1, 0, 3),
													new Matrix(1.04799, 0, 0, -1.02376, -59.2527, 1264.91)
													);

		//
		// Right D pad Key
		//

		// Right D pad key outline
		DrawingGroup rightButton = CreateDPadButton("F0 M1117,892z M0,0z M934.408,542.109C934.408,530.894,925.317,521.803,914.103,521.803L885.214,521.803C874,521.803,864.909,530.894,864.909,542.109L864.909,566.458C864.909,572.736 867.3,578.778 871.596,583.357 878.24,590.438 888.25,601.106 894.029,607.265 895.224,608.538 896.884,609.272 898.63,609.299 900.376,609.326 902.058,608.643 903.292,607.407 909.386,601.302 920.069,590.597 927.192,583.461 931.813,578.831 934.408,572.556 934.408,566.015 934.408,559.291 934.408,550.257 934.408,542.109z",
														"F0 M1117,892z M0,0z M889.258,543.129L907.916,543.129 898.835,534.049 889.258,543.129z",
														new Matrix(1, 0, 0, 1, 0, 3),
														new Matrix(6.41709E-17, -1.02376, -1.04799, -6.26875E-17, 1543.94, 1539.75)
														);

		//
		// Left D Pad Key
		// 
		DrawingGroup leftButton = CreateDPadButton("F0 M1117, 892z M0, 0z M934.408, 542.109C934.408, 530.894, 925.317, 521.803, 914.103, 521.803L885.214, 521.803C874, 521.803, 864.909, 530.894, 864.909, 542.109L864.909, 566.458C864.909, 572.736 867.3, 578.778 871.596, 583.357 878.24, 590.438 888.25, 601.106 894.029, 607.265 895.224, 608.538 896.884, 609.272 898.63, 609.299 900.376, 609.326 902.058, 608.643 903.292, 607.407 909.386, 601.302 920.069, 590.597 927.192, 583.461 931.813, 578.831 934.408, 572.556 934.408, 566.015 934.408, 559.291 934.408, 550.257 934.408, 542.109",
													"F0 M1117,892z M0,0z M889.258,543.129L907.916,543.129 898.835,534.049 889.258,543.129z",
													new Matrix(1, 0, 0, 1, 0, 3),
													new Matrix(-6.41709E-17, -1.02376, 1.04799, -6.26875E-17, 223.22, 1539.75)
													);
 
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
		drawing_2.Children.Add(squareButtonOutline);
		drawing_2.Children.Add(triangleIcon);
		drawing_2.Children.Add(triangleButtonOutline);
		drawing_2.Children.Add(circleIcon);
		drawing_2.Children.Add(circleOutline);
		drawing_2.Children.Add(r2Button);
		drawing_2.Children.Add(l2Button);
		drawing_2.Children.Add(upButton);
		drawing_2.Children.Add(downButton);
		drawing_2.Children.Add(rightButton);
		drawing_2.Children.Add(leftButton);
		drawing_2.Children.Add(xButtonOutline);


		DrawingGroup drawing_1 = new DrawingGroup();
		drawing_1.ClipGeometry = Geometry.Parse("M0,0 V892 H1117 V0 H0 Z");
		drawing_1.Children.Add(drawing_2);


		DrawingImage dualsense_pic = new DrawingImage();
		dualsense_pic.Drawing = drawing_1;

		return dualsense_pic;
	}

	public (DrawingGroup, DrawingGroup) DrawXButton()
	{
		// X Icon 
		DrawingGroup xIcon = CreateButtonIcon(
												4,
												"F0 M1117,892z M0,0z M1639.49,679.525L1672.29,712.319 M1672.29,679.525L1639.49,712.319",
												new Matrix(1.04799, 0, 0, 1.02376, -60.1837, -20.9858)
											);
		// X button Outline
		DrawingGroup xButtonOutline = CreateButtonOutline(
															34.957,
															34.957,
															1665.11,
															525.401,
															new Matrix(1.04799, 0, 0, 1.02376, -69.8487, 153.587)
														);
		return (xIcon, xButtonOutline);
	}

	public (DrawingGroup, DrawingGroup) CreateSquareButton()
	{
		// Square Button Icon
		DrawingGroup squareIcon = CreateButtonIcon(
													4.54,
													"M 1634.48,533.609 H 1671.787 V 570.916 H 1634.48 Z",
													new Matrix(0.923202, 0, 0, 0.90186, 75.2895, 121.747)
												   );

		// Square Button Outline
		DrawingGroup squareOutline = CreateButtonOutline(
															34.957,
															34.957,
															1665.11,
															525.401,
															new Matrix(1.04799, 0, 0, 1.02376, -143.208, 81.9239)
														);
		return (squareIcon, squareOutline);
	}

	public (DrawingGroup, DrawingGroup) CreateCircleButton()
	{
		//// circle button icon
		DrawingGroup circleIcon = CreateButtonIcon(
													4,
													"M 1748.24, 623.366 A 19.1, 19.1 0 1, 0 1710.04, 623.366 A 19.1, 19.1 0 1, 0 1748.24, 623.366",
													new Matrix(1.04799, 0, 0, 1.02376, -63.5968, -18.369)
												);

		// Circle Button outline
		DrawingGroup circleOutline = CreateButtonOutline(
															34.957,
															34.957,
															1665.11,
															525.401,
															new Matrix(1.04799, 0, 0, 1.02376, 3.51071, 81.9239)
														);
		return (circleIcon, circleOutline);
	}

	public (DrawingGroup, DrawingGroup) CreateTriangleButton()
	{
		// Triangle Icon
		DrawingGroup triangleIcon = CreateButtonIcon(
														4.13,
														"F0 M1117,892z M0,0z M1668.06,540.081L1689.09,574.313 1647.02,574.313 1668.06,540.081z",
														new Matrix(1.00662, 0, 0, 0.997527, -3.92375, -7.67218)
													);

		// Triangle Button Outline
		DrawingGroup triangleOutline = CreateButtonOutline(
															34.957,
															34.957,
															1665.11,
															525.401,
															new Matrix(1.04799, 0, 0, 1.02376, -69.8487, 10.2604)
															);

		return (triangleIcon, triangleOutline);
	}

	private DrawingGroup CreateButtonIcon(double penThickness, string geometry, Matrix transform)
	{
		// Creates the button icons for each shape button
		GeometryDrawing iconGD = new GeometryDrawing
		{
			Geometry = Geometry.Parse(geometry),
			Pen = new Pen
			{
				Brush = Brushes.Black,
				Thickness = penThickness,
				StartLineCap = PenLineCap.Round,
				EndLineCap = PenLineCap.Round,
				LineJoin = PenLineJoin.Round
			}
		};
		DrawingGroup icon = new DrawingGroup
		{
			Opacity = 1.0,
			Transform = new MatrixTransform(transform)
		};
		icon.Children.Add(iconGD);
		return icon;
	}

	private DrawingGroup CreateButtonOutline(double radiusX, double radiusY, double centerX, double centerY, Matrix matrix)
	{
		// Creates outline for shape buttons
		GeometryDrawing outlineGD = new GeometryDrawing
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
				RadiusX = radiusX,
				RadiusY = radiusY,
				Center = new Point(centerX, centerY)
			}
		};

		DrawingGroup outline = new DrawingGroup
		{
			Opacity = 1.0,
			Transform = new MatrixTransform(matrix)
		};
		outline.Children.Add(outlineGD);

		return outline;

	}

	private DrawingGroup CreateTriggerButton(double penThickness, string geometry, Matrix transform)
	{
		GeometryDrawing triggerGD = new GeometryDrawing
		{
			Pen = new Pen
			{
				Brush = Brushes.Black,
				Thickness = penThickness,
				StartLineCap = PenLineCap.Round,
				EndLineCap = PenLineCap.Round,
				LineJoin = PenLineJoin.Round
			},
			Geometry = Geometry.Parse(geometry)
		};

		DrawingGroup triggerButton = new DrawingGroup
		{
			Opacity = 1.0,
			Transform = new MatrixTransform(transform)
		};
		triggerButton.Children.Add(triggerGD);
		return triggerButton;
	}

	private DrawingGroup CreateDPadButton(string outlineGeometry, string iconGeometry, Matrix outlineTransform, Matrix buttonTransform)
	{
        // outline for d pad key
        GeometryDrawing	outlineGD = new GeometryDrawing
        {
            Geometry = Geometry.Parse(outlineGeometry),
            Pen = new Pen
            {
                Brush = Brushes.Black,
                Thickness = 4,
                StartLineCap = PenLineCap.Round,
                EndLineCap = PenLineCap.Round,
                LineJoin = PenLineJoin.Round
            }
        };
        DrawingGroup DG = new DrawingGroup
        {
            Opacity = 1.0,
            Transform = new MatrixTransform(outlineTransform)
        };
        DG.Children.Add(outlineGD);

        // Up d pad icon 
        GeometryDrawing iconGD = new GeometryDrawing
        {
            Brush = Brushes.Black,
            Geometry = Geometry.Parse(iconGeometry),
            Pen = new Pen
            {
                Brush = Brushes.Black,
                Thickness = 4,
                StartLineCap = PenLineCap.Round,
                EndLineCap = PenLineCap.Round,
                LineJoin = PenLineJoin.Round
            }
        };

        // up d pad outline 
        DrawingGroup button = new DrawingGroup
        {
            Opacity = 1.0,
            Transform = new MatrixTransform(buttonTransform)
        };
        button.Children.Add(outlineGD);
        button.Children.Add(iconGD);
		return button;
    }
}
