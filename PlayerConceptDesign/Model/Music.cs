using System.Windows.Media.Imaging;

namespace PlayerConceptDesign.Model
{
    public class Music
    {
        private string Path_;
        public string Path {  get { return Path_; } set { Path_ = value; } }

        private string Name_;
        public string Name { get { return Name_; } set { Name_ = value; } }

        private BitmapImage Image_;
        public BitmapImage Image { get { return Image_; } set { Image_ = value; } }
    }
}
