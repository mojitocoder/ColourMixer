using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ColourMixer
{
	public partial class Mixer : ContentPage
	{
		public Mixer()
		{
			InitializeComponent();
			boxViewColour.Color = Color.Black;
		}

		public void OnColourSliderChanged(Object sender, EventArgs e)
		{
			var red = sliderRed.Value;
			var green = sliderGreen.Value;
			var blue = sliderBlue.Value;
			boxViewColour.Color = Color.FromRgb(red, green, blue);
		}
	}
}
