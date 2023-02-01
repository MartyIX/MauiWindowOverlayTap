using Font = Microsoft.Maui.Graphics.Font;

namespace MauiWindowOverlayTap;

public class ReconnectingWindowOverlay : WindowOverlay
{
    /// <inheritdoc/>
    public ReconnectingWindowOverlay(IWindow window) : base(window)
    {
        this.DisableUITouchEventPassthrough = true;
    }
}

public class ReconnectingWindowOverlayElement : IWindowOverlayElement
{
    /// <inheritdoc/>
    public bool Contains(Point point)
    {
        return true;
    }

    /// <inheritdoc/>
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.FillColor = Brush.DimGray.Color.WithAlpha(0.8f);
        canvas.FillRectangle(dirtyRect);

        canvas.FontSize = 30;
        canvas.FontColor = Brush.Black.Color;
        canvas.Font = Font.DefaultBold;

        canvas.DrawString("WIP…", dirtyRect.Width / 2, dirtyRect.Height / 2, HorizontalAlignment.Center);
    }
}