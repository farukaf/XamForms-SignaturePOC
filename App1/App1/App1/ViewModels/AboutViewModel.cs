using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            //https://github.com/INHack20/Iconize
            GridList = new ObservableCollection<ItemGrid>()
            {
                new ItemGrid()
                {
                    Title = "Um bom titulo aqui",
                    Icon = "fas-address-card"
                },
                new ItemGrid()
                {
                    Title = "Cartão de Crédito",
                    Icon = "fas-credit-card",
                },
                new ItemGrid()
                {
                    Title = "Editar",
                    Icon = "fas-edit",
                },
                new ItemGrid()
                {
                    Title = "Um bom titulo aqui",
                    Icon = "fas-address-card"
                },
                new ItemGrid()
                {
                    Title = "Cartão de Crédito",
                    Icon = "fas-credit-card",
                },
                new ItemGrid()
                {
                    Title = "Editar",
                    Icon = "fas-edit",
                },
                new ItemGrid()
                {
                    Title = "Editar",
                    Icon = "fas-edit",
                },
            };

        }

        public ObservableCollection<ItemGrid> GridList { get; set; }

        public ICommand OpenWebCommand { get; }
    }

    public class ItemGrid
    {
        public ItemGrid()
        {
            TapCommand = new Command(async () =>
            {
                await Task.Delay(1);
                Console.WriteLine(Title);
            });
        }
        public string Icon { get; set; }
        public string Title { get; set; }

        public ICommand TapCommand { get; }
    }
}