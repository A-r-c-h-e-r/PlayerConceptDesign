using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PlayerConceptDesign.Model
{
    public class ColorsTheme : INPropertyChanged
    {
        private SolidColorBrush ColorPlayerPanel_, ColorForegroundHome_,  ColorMenu_, ColorForeground_, ColorMenuForeground_,  ColorInfoBorder_, ColorPlayerPanelBorderBrush_, ColorPlayerSlider_;
        private Color ColorMainGradient1_, ColorMainGradient2_, ColorEnlargeGradient1_, ColorEnlargeGradient2_,  ColorBackLight_;

        public SolidColorBrush ColorForegroundHome
        { get { return ColorForegroundHome_; } set { if (value != ColorForegroundHome_) { ColorForegroundHome_ = value; OnPropertyChanged("ColorForegroundHome"); } } }


        public SolidColorBrush ColorPlayerPanel
        { get { return ColorPlayerPanel_; } set { if (value != ColorPlayerPanel_) { ColorPlayerPanel_ = value; OnPropertyChanged("ColorPlayerPanel"); } } }

        public SolidColorBrush ColorMenu
        { get { return ColorMenu_; } set { if (value != ColorMenu_) { ColorMenu_ = value; OnPropertyChanged("ColorMenu"); } } }

        public SolidColorBrush ColorForeground
        { get { return ColorForeground_; } set { if (value != ColorForeground_) { ColorForeground_ = value; OnPropertyChanged("ColorForeground"); } } }

        public SolidColorBrush ColorMenuForeground
        { get { return ColorMenuForeground_; } set { if (value != ColorMenuForeground_) { ColorMenuForeground_ = value; OnPropertyChanged("ColorMenuForeground"); } } }
        

        public SolidColorBrush ColorInfoBorder
        { get { return ColorInfoBorder_; } set { if (value != ColorInfoBorder_) { ColorInfoBorder_ = value; OnPropertyChanged("ColorInfoBorder"); } } }

        public SolidColorBrush ColorPlayerPanelBorderBrush
        { get { return ColorPlayerPanelBorderBrush_; } set { if (value != ColorPlayerPanelBorderBrush_) { ColorPlayerPanelBorderBrush_ = value; OnPropertyChanged("ColorPlayerPanelBorderBrush"); } } }

        public SolidColorBrush ColorPlayerSlider
        { get { return ColorPlayerSlider_; } set { if (value != ColorPlayerSlider_) { ColorPlayerSlider_ = value; OnPropertyChanged("ColorPlayerSlider"); } } }

        public Color ColorBackLight
        { get { return ColorBackLight_; } set { if (value != ColorBackLight_) { ColorBackLight_ = value; OnPropertyChanged("ColorBackLight"); } } }

        public Color ColorMainGradient1
        { get { return ColorMainGradient1_; } set { if (value != ColorMainGradient1_) { ColorMainGradient1_ = value; OnPropertyChanged("ColorMainGradient1"); } } }

        public Color ColorMainGradient2
        { get { return ColorMainGradient2_; } set { if (value != ColorMainGradient2_) { ColorMainGradient2_ = value; OnPropertyChanged("ColorMainGradient2"); } }  }

        public Color ColorEnlargeGradient1
        { get { return ColorEnlargeGradient1_; } set { if (value != ColorEnlargeGradient1_) { ColorEnlargeGradient1_ = value; OnPropertyChanged("ColorEnlargeGradient1"); } } }

        public Color ColorEnlargeGradient2
        { get { return ColorEnlargeGradient2_; } set { if (value != ColorEnlargeGradient2_) { ColorEnlargeGradient2_ = value; OnPropertyChanged("ColorEnlargeGradient2"); } } }

    }
}