using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;

public class DrawingImageCreator
{
    public DrawingImage CreateDualSenseDrawingImage()
    {
        // X button outline and Icon
        DrawingGroup xIcon = CreateShape(
            "F0 M1117,892z M0,0z M1639.49,679.525L1672.29,712.319 M1672.29,679.525L1639.49,712.319",
            new Matrix(1.04799, 0, 0, 1.02376, -60.1837, -20.9858),
            4,
            1
        );

        DrawingGroup xButtonOutline = CreateShape(
            34.957,
            34.957,
            1665.11,
            525.401,
            new Matrix(1.04799, 0, 0, 1.02376, -69.8487, 153.587),
            4,
            1
        );
        //// Square Icon and outline
        DrawingGroup squareIcon = CreateShape(
            "M 1634.48,533.609 H 1671.787 V 570.916 H 1634.48 Z",
            new Matrix(0.923202, 0, 0, 0.90186, 75.2895, 121.747),
            4.54,
            1
        );

        DrawingGroup squareOutline = CreateShape(
            34.957,
            34.957,
            1665.11,
            525.401,
            new Matrix(1.04799, 0, 0, 1.02376, -143.208, 81.9239),
            4,
            1
        );

        //// Triangle Icon and outline
        DrawingGroup triangleIcon = CreateShape(
            "F0 M1117,892z M0,0z M1668.06,540.081L1689.09,574.313 1647.02,574.313 1668.06,540.081z",
            new Matrix(1.00662, 0, 0, 0.997527, -3.92375, -7.67218),
            4.13,
            1
        );
        DrawingGroup triangleOutline = CreateShape(
            34.957,
            34.957,
            1665.11,
            525.401,
            new Matrix(1.04799, 0, 0, 1.02376, -69.8487, 10.2604),
            4,
            1
        );

        //// Circle button icon and outline
        DrawingGroup circleOutline = CreateShape(
            34.957,
            34.957,
            1665.11,
            525.401,
            new Matrix(1.04799, 0, 0, 1.02376, 3.51071, 81.9239),
            1,
            4
        );

        DrawingGroup circleIcon = CreateShape(
            "M 1748.24, 623.366 A 19.1, 19.1 0 1, 0 1710.04, 623.366 A 19.1, 19.1 0 1, 0 1748.24, 623.366",
            new Matrix(1.04799, 0, 0, 1.02376, -63.5968, -18.369),
            4,
            1
        );

        // R2 Button
        DrawingGroup r2Button = CreateShape(
            "F0 M1117,892z M0,0z M1579.77,357.225L1679.77,357.225C1690.55,357.225 1678.68,262.657 1610.67,262.657 1578,262.657 1565.31,357.225 1579.77,357.225z",
            new Matrix(1.19695, 0, 0, 1.20074, -286.588, -56.1541),
            3.46,
            1
        );

        //
        // L2 Button
        //
        DrawingGroup l2Button = CreateShape(
            "F0 M1117,892z M0,0z M1579.77,357.225L1679.77,357.225C1690.55,357.225 1678.68,262.657 1610.67,262.657 1578,262.657 1565.31,357.225 1579.77,357.225z",
            new Matrix(-1.19695, 0, 0, 1.20074, 2851.49, -56.1541),
            3.46,
            1
        );

        //
        // Up d pad key
        //
        DrawingGroup upButton = CreateDPadButton(
            "F0 M1117,892z M0,0z M934.408,542.109C934.408,530.894,925.317,521.803,914.103,521.803L885.214,521.803C874,521.803,864.909,530.894,864.909,542.109L864.909,566.444C864.909,572.731 867.306,578.78 871.612,583.36 878.468,590.653 888.943,601.795 894.962,608.198 896.181,609.494 897.88,610.229 899.658,610.229 901.437,610.229 903.136,609.494 904.355,608.198 910.374,601.795 920.849,590.653 927.705,583.36 932.011,578.78 934.408,572.731 934.408,566.444 934.408,559.679 934.408,550.432 934.408,542.109z",
            "F0 M1117, 892z M0, 0z M889.258, 543.129L907.916, 543.129 898.835, 534.049 889.258, 543.129z",
            new Matrix(1.04799, 0, 0, 1.02376, -59.2527, -26.3824),
            new Matrix(1.04799, 0, 0, 1.02376, -59.2527, -26.3824)
        );
        //
        // Down D pad Button
        //
        DrawingGroup downButton = CreateDPadButton(
            "F0 M1117,892z M0,0z M934.408,542.109C934.408,530.894,925.317,521.803,914.103,521.803L885.214,521.803C874,521.803,864.909,530.894,864.909,542.109L864.909,566.234C864.909,572.646 867.402,578.806 871.862,583.412 878.746,590.522 889.092,601.208 895.028,607.339 896.242,608.593 897.913,609.301 899.658,609.301 901.404,609.301 903.075,608.593 904.289,607.339 910.225,601.208 920.571,590.522 927.455,583.412 931.914,578.806 934.408,572.646 934.408,566.234 934.408,559.488 934.408,550.346 934.408,542.109z",
            "F0 M1117,892z M0,0z M889.258,543.129L907.916,543.129 898.835,534.049 889.258,543.129z",
            new Matrix(1, 0, 0, 1, 0, 3),
            new Matrix(1.04799, 0, 0, -1.02376, -59.2527, 1264.91)
        );

        //
        // Right D pad Key
        //

        // Right D pad key outline
        DrawingGroup rightButton = CreateDPadButton(
            "F0 M1117,892z M0,0z M934.408,542.109C934.408,530.894,925.317,521.803,914.103,521.803L885.214,521.803C874,521.803,864.909,530.894,864.909,542.109L864.909,566.458C864.909,572.736 867.3,578.778 871.596,583.357 878.24,590.438 888.25,601.106 894.029,607.265 895.224,608.538 896.884,609.272 898.63,609.299 900.376,609.326 902.058,608.643 903.292,607.407 909.386,601.302 920.069,590.597 927.192,583.461 931.813,578.831 934.408,572.556 934.408,566.015 934.408,559.291 934.408,550.257 934.408,542.109z",
            "F0 M1117,892z M0,0z M889.258,543.129L907.916,543.129 898.835,534.049 889.258,543.129z",
            new Matrix(1, 0, 0, 1, 0, 3),
            new Matrix(6.41709E-17, -1.02376, -1.04799, -6.26875E-17, 1543.94, 1539.75)
        );

        //
        // Left D Pad Key
        //
        DrawingGroup leftButton = CreateDPadButton(
            "F0 M1117, 892z M0, 0z M934.408, 542.109C934.408, 530.894, 925.317, 521.803, 914.103, 521.803L885.214, 521.803C874, 521.803, 864.909, 530.894, 864.909, 542.109L864.909, 566.458C864.909, 572.736 867.3, 578.778 871.596, 583.357 878.24, 590.438 888.25, 601.106 894.029, 607.265 895.224, 608.538 896.884, 609.272 898.63, 609.299 900.376, 609.326 902.058, 608.643 903.292, 607.407 909.386, 601.302 920.069, 590.597 927.192, 583.461 931.813, 578.831 934.408, 572.556 934.408, 566.015 934.408, 559.291 934.408, 550.257 934.408, 542.109",
            "F0 M1117,892z M0,0z M889.258,543.129L907.916,543.129 898.835,534.049 889.258,543.129z",
            new Matrix(1, 0, 0, 1, 0, 3),
            new Matrix(-6.41709E-17, -1.02376, 1.04799, -6.26875E-17, 223.22, 1539.75)
        );

        //
        // Controller Bottom
        //
        DrawingGroup controllerBottom = CreateShape(
            "F0 M1117,892z M0,0z M821.891,1149.7C830.442,1151.31 884.247,1153.8 890.27,1146.55 924.201,1105.72 959.792,992.312 975.686,950.409 985.478,924.595 1011.09,912.527 1043.18,909.722 1073.78,923.291 1088.33,923.703 1139.89,913.315L1420.11,913.315C1471.67,923.703 1486.23,923.291 1516.82,909.722 1548.91,912.527 1574.52,924.595 1584.31,950.409 1600.21,992.312 1635.8,1105.72 1669.73,1146.55 1675.75,1153.8 1729.56,1151.31 1738.11,1149.7",
            new Matrix(1.04799, 0, 0, 1.02376, -59.2527, -21.0995),
            4,
            1
        );

        //
        // Mic Button
        //
        DrawingGroup micButton = CreateShape(
            "F0 M1117,892z M0,0z M1313.44,858.8C1313.44,855.101 1310.44,852.102 1306.75,852.102 1294.83,852.102 1270.09,852.102 1258.18,852.102 1254.48,852.102 1251.48,855.101 1251.48,858.8 1251.48,858.801 1251.48,858.801 1251.48,858.802 1251.48,862.501 1254.48,865.5 1258.18,865.5 1270.09,865.5 1294.83,865.5 1306.75,865.5 1310.44,865.5 1313.44,862.501 1313.44,858.802 1313.44,858.801 1313.44,858.801 1313.44,858.8z",
            new Matrix(1.04799, 0, 0, 1.02376, -61.8321, -20.6709),
            4,
            1
        );

        //
        // Right Side of top of controller
        //
        DrawingGroup controllerTopRight = CreateShape(
            "F0 M1117,892z M0,0z M1003.45,436.511C1017.29,438.306,1031.13,435.352,1044.97,430",
            new Matrix(-1.04799, 0, 0, 1.02376, 2623.29, -21.0995),
            4,
            1
        );

        //
        // Left side of top of controller
        //
        DrawingGroup controllerTopLeft = CreateShape(
            "F0 M1117,892z M0,0z M1003.45,436.511C1017.29,438.306,1031.13,435.352,1044.97,430",
            new Matrix(1.04799, 0, 0, 1.02376, -59.2527, -21.0995),
            4,
            1
        );

        //
        // Right Side Handle
        //
        DrawingGroup rightHandle = CreateShape(
            "F0 M1117,892z M0,0z M1536.64,461.082C1538.1,454.139 1540.62,448.211 1544.23,443.324 1554.11,429.923 1572.15,424.356 1598.92,427.18 1639.66,431.477 1678.74,439.099 1714.35,449.489 1726.25,452.963 1737.83,457.763 1742.74,468.16 1833.75,661.122 1849.58,876.955 1798.65,1111.24 1795.7,1124.8 1789.6,1135.46 1777.6,1143.35 1771.76,1147.18 1765.01,1150.41 1755.71,1152.79 1734.15,1158.32 1724.67,1142.93 1722.08,1129.04 1688.66,950.214 1633.4,786.687 1530.41,678.802 1521.1,669.041 1512.23,647.121 1509.78,627.068 1508.81,619.143 1509.33,611.735 1510.24,605.032 1515.61,565.609 1524.43,519.826 1533.28,477.13 1534.4,471.724 1535.52,466.369 1536.64,461.082z",
            new Matrix(1.04799, 0, 0, 1.02376, -54.0127, -21.0995),
            4,
            1
        );

        //
        // Left side handle/grip of controller
        //
        DrawingGroup leftHandle = CreateShape(
            "F0 M1117,892z M0,0z M1536.64,461.082C1538.1,454.139 1540.62,448.211 1544.23,443.324 1554.11,429.923 1572.15,424.356 1598.92,427.18 1639.66,431.477 1678.74,439.099 1714.35,449.489 1726.25,452.963 1737.83,457.763 1742.74,468.16 1833.75,661.122 1849.58,876.955 1798.65,1111.24 1795.7,1124.8 1789.6,1135.46 1777.6,1143.35 1771.76,1147.18 1765.01,1150.41 1755.71,1152.79 1734.15,1158.32 1724.67,1142.93 1722.08,1129.04 1688.66,950.214 1633.4,786.687 1530.41,678.802 1521.1,669.041 1512.23,647.121 1509.78,627.068 1508.81,619.143 1509.33,611.735 1510.24,605.032 1515.61,565.609 1524.43,519.826 1533.28,477.13 1534.4,471.724 1535.52,466.369 1536.64,461.082z",
            new Matrix(-1.04799, 0, 0, 1.02376, 2617.56, -21.0995),
            4,
            1
        );
        //
        // touch pad outline
        //
        DrawingGroup touchPad = CreateShape(
            "F0 M1117,892z M0,0z M1280,410.968C1280,410.968 1295.92,410.887 1319.85,411.295 1371.4,412.176 1460.09,415.33 1506.56,426.465 1512.6,427.914 1517.79,431.384 1521.32,435.732 1525.05,440.326 1526.93,445.901 1526.02,451.109 1517.08,502.33 1505.67,560.142 1495.49,611.132 1487.46,651.356 1454.6,664.948 1427.06,664.824 1399.52,664.7 1280,664.265 1280,664.265 1280,664.265 1160.48,664.7 1132.94,664.824 1105.4,664.948 1072.54,651.356 1064.51,611.132 1054.33,560.142 1042.92,502.33 1033.98,451.109 1032.21,440.971 1041.01,429.445 1053.44,426.465 1121.47,410.163 1280,410.968 1280,410.968z",
            new Matrix(1.03398, 0, 0, 1.03077, -37.8634, -25.7549),
            4.01,
            1
        );

        //
        // R1/R bumper button
        //
        DrawingGroup r1Button = CreateShape(
            "F0 M1117,892z M0,0z M1710.79,448.465C1710.06,419.222 1559.14,376.876 1562.69,430 1572.21,426.604 1584.26,425.633 1598.92,427.18 1638.31,431.335 1676.14,438.597 1710.79,448.465z",
            new Matrix(1.04799, 0, 0, 1.02376, -53.1719, -21.1936),
            4,
            1
        );

        //
        // Left bumper button
        //
        DrawingGroup l1Button = CreateShape(
            "F0 M1117,892z M0,0z M1710.79,448.465C1710.06,419.222 1559.14,376.876 1562.69,430 1572.21,426.604 1584.26,425.633 1598.92,427.18 1638.31,431.335 1676.14,438.597 1710.79,448.465z",
            new Matrix(-1.04799, 0, 0, 1.02376, 2617.56, -21.0995),
            4,
            1
        );

        //
        // Options Button
        //
        DrawingGroup optionsButton = CreateShape(
            "F0 M1117,892z M0,0z M1550.36,480.226L1550.36,520.418C1550.36,520.418 1550.17,535.418 1565.03,535.418 1579.88,535.418 1579.7,520.418 1579.7,520.418L1579.7,480.025C1579.7,480.025 1579.89,465.024 1565.03,465.126 1550.17,465.227 1550.36,480.226 1550.36,480.226z",
            new Matrix(1.00731, 0.196365, -0.166064, 0.812946, 93.6712, -230.389),
            4.45,
            1
        );

        //
        // Share button
        //
        DrawingGroup shareButton = CreateShape(
            "F0 M1117,892z M0,0z M1566.37,476.359L1566.37,516.552C1566.37,516.552 1566.18,531.552 1581.04,531.552 1595.89,531.552 1595.71,516.552 1595.71,516.552L1595.71,476.158C1595.71,476.158 1595.89,461.157 1581.04,461.259 1566.18,461.36 1566.37,476.359 1566.37,476.359z",
            new Matrix(-1.00731, 0.196365, 0.166064, 0.812946, 2489.53, -230.389),
            4.45,
            1
        );

        //
        // Share Button Icon
        //
        DrawingGroup shareButtonIcon = Create3PartShape(
            "F0 M1117,892z M0,0z M985.029,452.795L980.502,445.716 985.029,452.795z",
            "F0 M1117,892z M0,0z M992.053,450.079L992.053,441.353 992.053,450.079z",
            "F0 M1117,892z M0,0z M997.87,452.795L1003.06,445.716",
            4,
            1,
            new Matrix(1.04799, 0, 0, 1.02376, -60.7353, -17.8077)
        );

        //
        // Options Button Icon
        //
        DrawingGroup line1 = CreateShape(
            "F0 M1117,892z M0,0z M1580.81,444.569L1566.83,444.569 1580.81,444.569z",
            new Matrix(1, 0, 0, 1, -3, -2),
            4,
            1
        );

        DrawingGroup line2 = CreateShape(
            "F0 M1117,892z M0,0z M1580.81,450.289L1566.83,450.289 1580.81,450.289z",
            new Matrix(1, 0, 0, 1, -3, -2),
            4,
            1
        );

        DrawingGroup line3 = CreateShape(
            "F0 M1117,892z M0,0z M1580.81,456.01L1566.83,456.01",
            new Matrix(1, 0, 0, 1, -3, -2),
            4,
            1
        );

        DrawingGroup optionsButtonIcon = new DrawingGroup
        {
            Opacity = 1,
            Transform = new MatrixTransform(new Matrix(1.04799, 0, 0, 1.02376, -59.2527, -21.0995)),
        };
        optionsButtonIcon.Children.Add(line1);
        optionsButtonIcon.Children.Add(line2);
        optionsButtonIcon.Children.Add(line3);

        //
        // Right Joystick and right joystick outline
        //
        DrawingGroup rightOutline = CreateShape(
            78.002,
            78.002,
            1493.18,
            791.553,
            new Matrix(1.11981, 0, 0, 1.11981, -187.697, -89.8877),
            1,
            3.57
        );

        DrawingGroup rightJoystick = CreateShape(
            78.002,
            78.002,
            1493.18,
            791.553,
            new Matrix(0.733227, 0, 0, 0.733227, 389.538, 216.112),
            1,
            5.46
        );

        DrawingGroup rightJoystickGroup = new DrawingGroup
        {
            Opacity = 1,
            Transform = new MatrixTransform(new Matrix(1.04799, 0, 0, 1.02376, -59.2527, -21.0995)),
        };

        rightJoystickGroup.Children.Add(rightJoystick);
        rightJoystickGroup.Children.Add(rightOutline);

        //
        // Left Joystick Outline and left joystick
        //
        DrawingGroup leftOutline = CreateShape(
            78.002,
            78.002,
            1493.18,
            791.553,
            new Matrix(1.11981, 0, 0, 1.11981, -599.389, -89.8877),
            1,
            3.57
        );

        DrawingGroup leftJoystick = CreateShape(
            78.002,
            78.002,
            1493.18,
            791.553,
            new Matrix(0.733227, 0, 0, 0.733227, -2.1542, 216.112),
            1,
            5.46
        );

        DrawingGroup leftJoystickGroup = new DrawingGroup
        {
            Opacity = 1,
            Transform = new MatrixTransform(new Matrix(1.04799, 0, 0, 1.02376, -59.2527, -21.0995)),
        };

        leftJoystickGroup.Children.Add(leftOutline);
        leftJoystickGroup.Children.Add(leftJoystick);

        // unknown
        DrawingGroup unknown = CreateShape(
            "F1 M1117,892z M0,0z M81.55,606.2C22.2,589.175 12.375,554.1 39.3,533.725 58.7,520.975 81,509.875 104.6,501.525L106.775,500.85 282.2,437.95 282.2,510.2 156.45,556.175C134.425,564.65 130.675,575.925 148.975,581.975 158.1,584.3 168.55,585.65 179.325,585.65 194.7,585.65 209.425,582.925 223.05,577.95L222.175,578.225 282.725,556.175 282.725,620.975C278.975,621.9 274.725,622.35 270.55,623.25 251.175,626.65 228.875,628.6 206.125,628.6 161.675,628.6 118.975,621.15 79.175,607.45L81.925,608.275 81.55,606.2z M451.225,613.6L647.925,542.525C670.25,534.475 673.725,523 655.6,516.975 646.525,514.75 636.125,513.475 625.4,513.475 609.85,513.475 594.9,516.175 581.05,521.1L581.975,520.825 450.6,567.675 450.6,493.1 458.1,490.45C484.35,481.725,515.2,474.95,547.025,471.425L549.1,471.225C560.8,469.975 574.35,469.275 588.075,469.275 635,469.275 680,477.55 721.65,492.75L718.95,491.875C776.675,510.65 782.675,537.85 768.175,556.6 754.2,570.525 737.3,581.55 718.475,588.65L717.5,588.975 450.575,686.05 450.575,614.325 451.225,613.6z M305.775,106.2L305.775,654.375 428.075,693.775 428.075,234.025C428.075,212.475 437.575,198.075 452.875,203.075 472.75,208.7 476.625,228.5 476.625,250.1L476.625,433.65C552.875,470.925 612.9,433.575 612.9,335.175 612.9,234.05 577.725,189.125 474.25,153.125 429.625,136.925 373.25,120.775 315.575,108L305.85,106.2 305.775,106.2z",
            new Matrix(0.111834, 0, 0, 0.109248, 1237.45, 737.829),
            30,
            1
        );

        // Final
        DrawingGroup drawing_2 = new DrawingGroup();
        drawing_2.Opacity = 1.0;
        drawing_2.Transform = new MatrixTransform(
            new Matrix(0.954207, 0, 0, 0.976787, -664.382, -247.343)
        );

        drawing_2.Children.Add(xIcon);
        drawing_2.Children.Add(squareIcon);
        drawing_2.Children.Add(squareOutline);
        drawing_2.Children.Add(triangleIcon);
        drawing_2.Children.Add(triangleOutline);
        drawing_2.Children.Add(circleIcon);
        drawing_2.Children.Add(circleOutline);
        drawing_2.Children.Add(r2Button);
        drawing_2.Children.Add(l2Button);
        drawing_2.Children.Add(upButton);
        drawing_2.Children.Add(downButton);
        drawing_2.Children.Add(rightButton);
        drawing_2.Children.Add(leftButton);
        drawing_2.Children.Add(xButtonOutline);
        drawing_2.Children.Add(controllerBottom);
        drawing_2.Children.Add(micButton);
        drawing_2.Children.Add(controllerTopRight);
        drawing_2.Children.Add(controllerTopLeft);
        drawing_2.Children.Add(rightHandle);
        drawing_2.Children.Add(leftHandle);
        drawing_2.Children.Add(touchPad);
        drawing_2.Children.Add(r1Button);
        drawing_2.Children.Add(l1Button);
        drawing_2.Children.Add(optionsButton);
        drawing_2.Children.Add(shareButton);
        drawing_2.Children.Add(shareButtonIcon);
        drawing_2.Children.Add(optionsButtonIcon);
        drawing_2.Children.Add(rightJoystickGroup);
        drawing_2.Children.Add(leftJoystickGroup);
        drawing_2.Children.Add(unknown);

        DrawingGroup drawing_1 = new DrawingGroup();
        drawing_1.ClipGeometry = Geometry.Parse("M0,0 V892 H1117 V0 H0 Z");
        drawing_1.Children.Add(drawing_2);

        DrawingImage dualsense_pic = new DrawingImage();
        dualsense_pic.Drawing = drawing_1;

        return dualsense_pic;
    }

    // General class used to create shapes with only one drawing group and one geometry drawing using an ellipse
    private DrawingGroup CreateShape(
        double radiusX,
        double radiusY,
        double centerX,
        double centerY,
        Matrix matrix,
        int opacity,
        double brushThickness
    )
    {
        // Creates outline for shape buttons
        GeometryDrawing outlineGD = new GeometryDrawing
        {
            Brush = Brushes.Black,
            Pen = new Pen
            {
                Brush = Brushes.Black,
                Thickness = 4,
                StartLineCap = PenLineCap.Round,
                EndLineCap = PenLineCap.Round,
                LineJoin = PenLineJoin.Round,
            },
            Geometry = new EllipseGeometry
            {
                RadiusX = radiusX,
                RadiusY = radiusY,
                Center = new Point(centerX, centerY),
            },
        };

        DrawingGroup outline = new DrawingGroup
        {
            Opacity = opacity,
            Transform = new MatrixTransform(matrix),
        };
        outline.Children.Add(outlineGD);

        return outline;
    }

    // General class using to create shapes with only one drawing group and one geometry drawing using a geometry string
    private DrawingGroup CreateShape(
        string geometry,
        Matrix matrix,
        double penThickness,
        int opacity
    )
    {
        GeometryDrawing gd = new GeometryDrawing
        {
            Pen = new Pen
            {
                Brush = Brushes.Black,
                Thickness = penThickness,
                StartLineCap = PenLineCap.Round,
                EndLineCap = PenLineCap.Round,
                LineJoin = PenLineJoin.Round,
            },
            Geometry = Geometry.Parse(geometry),
        };

        DrawingGroup dg = new DrawingGroup
        {
            Opacity = opacity,
            Transform = new MatrixTransform(matrix),
        };

        dg.Children.Add(gd);
        return dg;
    }

    private DrawingGroup CreateDPadButton(
        string outlineGeometry,
        string iconGeometry,
        Matrix outlineTransform,
        Matrix buttonTransform
    )
    {
        // outline for d pad key
        GeometryDrawing outlineGD = new GeometryDrawing
        {
            Geometry = Geometry.Parse(outlineGeometry),
            Pen = new Pen
            {
                Brush = Brushes.Black,
                Thickness = 4,
                StartLineCap = PenLineCap.Round,
                EndLineCap = PenLineCap.Round,
                LineJoin = PenLineJoin.Round,
            },
        };
        DrawingGroup DG = new DrawingGroup
        {
            Opacity = 1.0,
            Transform = new MatrixTransform(outlineTransform),
        };
        DG.Children.Add(outlineGD);

        // D pad Icon
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
                LineJoin = PenLineJoin.Round,
            },
        };

        // D pad outline
        DrawingGroup button = new DrawingGroup
        {
            Opacity = 1.0,
            Transform = new MatrixTransform(buttonTransform),
        };
        button.Children.Add(outlineGD);
        button.Children.Add(iconGD);
        return button;
    }

    // General class used to create shapes with 3 parts/geometry drawings
    private DrawingGroup Create3PartShape(
        string geometry1,
        string geometry2,
        string geometry3,
        double penThickness,
        double opacity,
        Matrix transform,
        Matrix? transform2 = null
    )
    {
        GeometryDrawing gd1 = new GeometryDrawing
        {
            Pen = new Pen
            {
                Brush = Brushes.Black,
                Thickness = penThickness,
                StartLineCap = PenLineCap.Round,
                EndLineCap = PenLineCap.Round,
                LineJoin = PenLineJoin.Round,
            },
            Geometry = Geometry.Parse(geometry1),
        };

        GeometryDrawing gd2 = new GeometryDrawing
        {
            Pen = new Pen
            {
                Brush = Brushes.Black,
                Thickness = penThickness,
                StartLineCap = PenLineCap.Round,
                EndLineCap = PenLineCap.Round,
                LineJoin = PenLineJoin.Round,
            },
            Geometry = Geometry.Parse(geometry2),
        };

        GeometryDrawing gd3 = new GeometryDrawing
        {
            Pen = new Pen
            {
                Brush = Brushes.Black,
                Thickness = penThickness,
                StartLineCap = PenLineCap.Round,
                EndLineCap = PenLineCap.Round,
                LineJoin = PenLineJoin.Round,
            },
            Geometry = Geometry.Parse(geometry3),
        };

        DrawingGroup dg = new DrawingGroup
        {
            Opacity = opacity,
            Transform = new MatrixTransform(transform),
        };

        dg.Children.Add(gd1);
        dg.Children.Add(gd2);
        dg.Children.Add(gd3);
        return dg;
    }
}
