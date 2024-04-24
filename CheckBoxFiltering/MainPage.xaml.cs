using System.Globalization;
using System.Reflection;

namespace CheckBoxFiltering
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (brown.IsChecked == true)
                brown.IsChecked = false;
            else
                brown.IsChecked = true;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            if (green.IsChecked == true)
                green.IsChecked = false;
            else
                green.IsChecked = true;
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            if (red.IsChecked == true)
                red.IsChecked = false;
            else
                red.IsChecked = true;
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            if (sandal.IsChecked == true)
                sandal.IsChecked = false;
            else
                sandal.IsChecked = true;
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            if (violet.IsChecked == true)
                violet.IsChecked = false;
            else
                violet.IsChecked = true;
        }
    }


    public class SfImageSourceConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            string text = value as string;
            return ImageSource.FromResource(typeof(SfImageSourceConverter).GetTypeInfo().Assembly.GetName().Name + ".Resources.Images." + text, typeof(SfImageSourceConverter).GetTypeInfo().Assembly);
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
