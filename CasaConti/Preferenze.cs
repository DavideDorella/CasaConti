using CarListApp.Maui.ViewModels;
namespace CarListApp.Maui;

public class PreferenzePage : ContentPage
{
    public PreferenzePage(PreferenzeViewModel preferenzeViewModel)
    {

        var entryConto = new Entry();
        entryConto.SetBinding(Entry.TextProperty, preferenzeViewModel.Contopref);

        var but=new Button();
        but.HorizontalOptions=LayoutOptions.Center;
        but.VerticalOptions=LayoutOptions.Center;
        but.Command = preferenzeViewModel.SavePreferenzeCommand;

        Content = new VerticalStackLayout
        {

            Children = {
                new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Preferenze"
                
                },
                new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text ="Conto"},
               
                entryConto,
                
               but,
            }
            
            
        };

        BindingContext = preferenzeViewModel;

    }
}