using System.Windows;

namespace BerlinClock.App
{
    public static class UIElementExtension
    {
        public static void SetShapeOpacity(this UIElement element, bool noOpacity)
        {
            const double _maxOpacity = 0.5;
            const double _minOpacity = 0;

            element.Opacity = noOpacity ? _minOpacity : _maxOpacity;
        }
    }
}