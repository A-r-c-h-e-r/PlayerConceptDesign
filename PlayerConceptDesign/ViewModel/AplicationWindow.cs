using PlayerConceptDesign.View;
using System.Windows.Controls;

namespace PlayerConceptDesign.ViewModel
{
    public static class AplicationWindow
    {
        public static MainWindow AplicationMainWindow;
        public static WrapPanel[] WrapPanelLibrary;

        static AplicationWindow()
        {
            WrapPanelLibrary = new WrapPanel[4];
        }

        public static void SetWrapPanelLibrary (ref WrapPanel WrapPanelLibrary_, int index)
        {
            WrapPanelLibrary[index] = WrapPanelLibrary_;
        }
    }
}
