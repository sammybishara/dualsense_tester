
using DualSenseAPI.State;
using DualSenseAPI;


public class DualSenseTester
{


    public DualSenseTester()
    {
        DualSense ds = DualSense.EnumerateControllers().First();
        ds.Acquire();
        Poll(ds);
    }

    // Intiates Async polling with the controller
    private void Poll(DualSense ds)
    {
        ds.OnButtonStateChanged += OnButtonsPressed;
        ds.BeginPolling(10);
    }

    // handler to capture any buttons changed 
    private void OnButtonsPressed(DualSense ds, DualSenseInputStateButtonDelta changes)
    {

    }
}