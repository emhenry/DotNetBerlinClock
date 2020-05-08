using System.Windows;
using System.Windows.Threading;

namespace BerlinClock.App
{
    public static class UIElementExtension
    {
        public static void SetShapeOpacity(this UIElement element, Dispatcher dispatcher, bool noOpacity)
        {
            const double _maxOpacity = 0.4;
            const double _minOpacity = 1;

            dispatcher.Invoke(() => element.Opacity = noOpacity ? _minOpacity : _maxOpacity);
        }
    }
}