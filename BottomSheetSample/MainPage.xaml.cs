using Syncfusion.Maui.Toolkit.BottomSheet;

namespace BottomSheetSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ViewForecast_Clicked(object sender, EventArgs e)
        {
            weatherBottomSheet.IsOpen = true;
        }

        private void WeatherBottomSheet_StateChanged( object sender, StateChangedEventArgs e)
        {
            forecastDetails.IsVisible = e.NewState == BottomSheetState.FullExpanded;
        }
    }
}
