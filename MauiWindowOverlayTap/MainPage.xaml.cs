namespace MauiWindowOverlayTap;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Window window = this.Window;

        ReconnectingWindowOverlay windowOverlay = new(window);
        ReconnectingWindowOverlayElement overlayElement = new();

        if (!windowOverlay.AddWindowElement(overlayElement))
            throw new Exception("Failed to add window element to the window overlay.");

        if (!window.AddOverlay(windowOverlay))
            throw new Exception("Failed to show the window overlay.");
    }
}