using System.Windows.Media;
using dualsense_tester;
using DualSenseAPI;
using DualSenseAPI.State;

public class DualSenseTester
{
    private MainWindow mainWindow;
    private DrawingImageCreator dualsenseImg;

    public DualSenseTester(MainWindow mainWindow)
    {
        this.mainWindow = mainWindow;
        this.dualsenseImg = new DrawingImageCreator();
        mainWindow.UpdateWindow(dualsenseImg.dualsenseImg);
        DualSense ds = DualSense.EnumerateControllers().First();
        ds.Acquire();
        Poll(ds);
    }

    // Intiates Async polling with the controller
    private void Poll(DualSense ds)
    {
        ds.OnButtonStateChanged += OnButtonsPressed;
        ds.BeginPolling(4);
    }

    // handler to capture any buttons changed
    private void OnButtonsPressed(DualSense ds, DualSenseInputStateButtonDelta delta)
    {
        UpdateButtonColor(delta.SquareButton, "square outline");
        UpdateButtonColor(delta.CircleButton, "circle outline");
        UpdateButtonColor(delta.TriangleButton, "triangle outline");
        UpdateButtonColor(delta.CrossButton, "x outline");
        UpdateButtonColor(delta.R2Button, "r2");
        UpdateButtonColor(delta.L2Button, "l2");
        UpdateButtonColor(delta.R1Button, "right bumper button");
        UpdateButtonColor(delta.L1Button, "left bumper button");
        UpdateButtonColor(delta.DPadDownButton, "down button");
        UpdateButtonColor(delta.DPadUpButton, "up button");
        UpdateButtonColor(delta.DPadLeftButton, "left button");
        UpdateButtonColor(delta.DPadRightButton, "right button");
        UpdateButtonColor(delta.MicButton, "mic button");
        UpdateButtonColor(delta.TouchpadButton, "touch pad");
        UpdateButtonColor(delta.LogoButton, "ps icon");
        UpdateButtonColor(delta.CreateButton, "share button");
        UpdateButtonColor(delta.MenuButton, "options button");

        // Redraw the image on the UI thread
        mainWindow.Dispatcher.Invoke(() =>
        {
            mainWindow.UpdateWindow(dualsenseImg.dualsenseImg);
        });
    }

    private void UpdateButtonColor(ButtonDeltaState state, string buttonName)
    {
        if (state == ButtonDeltaState.NoChange)
            return;
        Brush color = state == ButtonDeltaState.Pressed ? Brushes.Black : Brushes.Transparent;

        mainWindow.Dispatcher.Invoke(() =>
        {
            dualsenseImg.ChangeButtonColor(buttonName, color);
        });
    }
}
