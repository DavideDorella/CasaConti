using CarListApp.Maui.ViewModels;

namespace CarListApp.Maui;

public class PreferenzePage : ContentPage
{
    public PreferenzePage(PreferenzeViewModel preferenzeViewModel)
    {
        Content = new VerticalStackLayout
        {
            Children = {
                new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Preferenze"
                }
            }
        };

        BindingContext = preferenzeViewModel;

    }
}