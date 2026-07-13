# How-to-Handle-Events-in-.NET-MAUI-Bottom-Sheet
This repository provides a sample that demonstrates how to handle events in the Syncfusion® .NET MAUI Bottom Sheet.

**Handle Events in the .NET MAUI Bottom Sheet**

The .NET MAUI Bottom Sheet provides several events that allow you to respond to user interactions and state changes. These events help you customize the behavior of the Bottom Sheet when it is opened, closed, dragged, or when its state changes.

The following example demonstrates how to subscribe to and handle the StateChanged event of the Bottom Sheet.

**XAML**
```
<bottomSheet:SfBottomSheet
x:Name="weatherBottomSheet"
StateChanged="WeatherBottomSheet_StateChanged">

<bottomSheet:SfBottomSheet.Content>
        <Button Text="View Forecast"
                Clicked="ViewForecast_Clicked"
                HorizontalOptions="Center"
                VerticalOptions="Center"/>
</bottomSheet:SfBottomSheet.Content>
<bottomSheet:SfBottomSheet.BottomSheetContent>

        <VerticalStackLayout
        Padding="20"
        Spacing="15">

            <!-- Header -->
            <Label Text="Today's Weather"
               FontSize="22"
               FontAttributes="Bold"
               HorizontalOptions="Center"/>

            <!-- Summary -->
            <Label Text="" FontFamily="MauiMaterialAssets"
               FontSize="50"
               HorizontalOptions="Center"/>

            <Label Text="28°C"
               FontSize="36"
               FontAttributes="Bold"
               HorizontalOptions="Center"/>

            <Label Text="Sunny"
               FontSize="18"
               HorizontalOptions="Center"/>

            <Label Text="Pull up for more details"
               TextColor="Gray"
               HorizontalOptions="Center"/>

            <!-- Detailed Forecast -->
            <Border x:Name="forecastDetails"
                IsVisible="False"
                Stroke="#E0E0E0"
                StrokeShape="RoundRectangle 12"
                Padding="15">

                <VerticalStackLayout Spacing="10">

                    <Grid ColumnDefinitions="*,Auto">
                        <Label Text="Humidity" />
                        <Label Grid.Column="1"
                           Text="65%" />
                    </Grid>

                    <Grid ColumnDefinitions="*,Auto">
                        <Label Text="Wind Speed" />
                        <Label Grid.Column="1"
                           Text="12 km/h" />
                    </Grid>

                    <Grid ColumnDefinitions="*,Auto">
                        <Label Text="UV Index" />
                        <Label Grid.Column="1"
                           Text="High" />
                    </Grid>

                    <Grid ColumnDefinitions="*,Auto">
                        <Label Text="Rain Chance" />
                        <Label Grid.Column="1"
                           Text="10%" />
                    </Grid>

                </VerticalStackLayout>

            </Border>

        </VerticalStackLayout>

    </bottomSheet:SfBottomSheet.BottomSheetContent>

</bottomSheet:SfBottomSheet>
```

 **C#:**

```
private void ViewForecast_Clicked(object sender, EventArgs e)
{
    weatherBottomSheet.IsOpen = true;
}

private void WeatherBottomSheet_StateChanged( object sender, StateChangedEventArgs e)
{
    forecastDetails.IsVisible = e.NewState == BottomSheetState.FullExpanded;
}
```

