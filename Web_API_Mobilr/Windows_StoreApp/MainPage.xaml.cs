using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows_StoreApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GetAllClick(object sender, RoutedEventArgs e)
        {
            var phones = await PhonesClient.GetAllAsync();
            phonesList.ItemsSource = phones;
        }

        private void NewClick(object sender, RoutedEventArgs e)
        {
            phoneDetails.ConfigureForNewItem();
        }

        private async void QueryClick(object sender, RoutedEventArgs e)
        {
            var phones = await PhonesClient.QueryAsync(manufacturerQuery.Text);
            phonesList.ItemsSource = phones;
        }

        private void PhoneSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            if (phonesList.SelectedItem == null)
                return;

            var phone = phonesList.SelectedItem as Phone;
            phoneDetails.ConfigureForUpdate(phone);
        }

        private async void PhoneSaved(object sender, PhoneStateChangedEventArgs e)
        {
            if (phoneDetails.IsNewItem)
                await PhonesClient.SaveAsync(e.Item);
            else
                await PhonesClient.UpdateAsync(e.Item);
            phonesList.SelectedIndex = -1;
            GetAllClick(null, null);
        }

        private async void PhoneDeleted(object sender, PhoneStateChangedEventArgs e)
        {
            await PhonesClient.DeleteAsync(e.Item.Id);
            phonesList.SelectedIndex = -1;
            GetAllClick(null, null);
        }
    }
}
