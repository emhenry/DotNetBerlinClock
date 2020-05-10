using System.Windows;

namespace BerlinClock.App
{
    /// <summary>
    /// Extension to manage to opacity of an UI element
    /// </summary>
    public static class UIElementExtension
    {
        public static void SetShapeOpacity(this UIElement element, bool isVisible)
        {
            const double _minOpacity = 0.2;
            const double _maxOpacity = 1;

            element.Opacity = isVisible ? _maxOpacity : _minOpacity;
        }
    }
}