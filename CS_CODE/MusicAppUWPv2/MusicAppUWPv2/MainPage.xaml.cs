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
using System.ComponentModel;
using MusicAppUWPv2.MusicDBService;





// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MusicAppUWPv2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void GetButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MusicDBServiceClient client = new MusicDBServiceClient();
                ViewModelClass model = new ViewModelClass();
                model.AddMethod = Add;
                model.ClearMethod = Clear;

                await client.ProcessRecordAsync(model);

                //IList<Owner> articleList = await client.QueryOwnerAsync();

                //set the result to UI
                //lvDataTemplates.ItemsSource = articleList;
            }
            catch //(Exception ex)
            {
                //NotifyUser(ex.Message);
            }
        }

        private void Clear()
        {
            lvDataTemplates.Items.Clear();
        }

        private void Add(object obj)
        {
            lvDataTemplates.Items.Add(obj);
        }
    }
}
