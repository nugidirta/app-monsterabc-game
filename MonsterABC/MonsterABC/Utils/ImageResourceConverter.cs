using System;
using Xamarin.Forms;

namespace MonsterABC.Utils
{
	public class ImageResourceConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return ImageSource.FromResource("MonsterABC.Images." + (value ?? ""));
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}