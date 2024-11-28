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
        mainWindow.UpdateImage(dualsenseImg.dualsenseImg);
        DualSense ds = DualSense.EnumerateControllers().First();
        ds.Acquire();
        Poll(ds);
    }

    // Intiates Async polling with the controller
    private void Poll(DualSense ds)
    {
        ds.OnButtonStateChanged += OnButtonsPressed;
        ds.OnStatePolled += OnStatePolled;
        ds.BeginPolling(4);
    }

    // Handler to update joystick positions and touch pad positions 
    private void OnStatePolled(DualSense ds) {
        DualSenseInputState state = ds.InputState;
        Vec2 left_joystick = state.LeftAnalogStick;
        Vec2 right_joystick = state.RightAnalogStick;
       
        mainWindow.Dispatcher.Invoke(() => {
            dualsenseImg.MoveJoystick(left_joystick.X, left_joystick.Y, "left joystick");
            dualsenseImg.MoveJoystick(right_joystick.X, right_joystick.Y, "right joystick");
        });

        mainWindow.Dispatcher.Invoke(() =>
        {
            mainWindow.UpdateImage(dualsenseImg.dualsenseImg);
        });
    }

    // Handler to capture any buttons pressed or released
    private void OnButtonsPressed(DualSense ds, DualSenseInputStateButtonDelta delta)
    {
        // If no observerable button changes, return
        if (!delta.HasChanges) return;
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
        UpdateButtonColor(delta.R3Button, "right joystick");
        UpdateButtonColor(delta.L3Button, "left joystick");

        // Redraw the image on the UI thread
        mainWindow.Dispatcher.Invoke(() =>
        {
            mainWindow.UpdateImage(dualsenseImg.dualsenseImg);
        });
    }

    private void UpdateButtonColor(ButtonDeltaState state, string buttonName)
    {
        if (state == ButtonDeltaState.NoChange) return;

        if (buttonName == "left joystick" || buttonName == "right joystick")
        {
            mainWindow.Dispatcher.Invoke(() =>
            {
                dualsenseImg.ChangeJoystickColor(buttonName, state == ButtonDeltaState.Pressed ? Brushes.Black : Brushes.White);
            });
        }
        else
        {
            mainWindow.Dispatcher.Invoke(() =>
            {
                dualsenseImg.ChangeButtonColor(buttonName, state == ButtonDeltaState.Pressed ? Brushes.Black : Brushes.Transparent);
            });
        }
    }

}
