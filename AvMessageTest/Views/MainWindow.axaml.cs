using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AvMessageTest.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoaded(RoutedEventArgs e)
        {
            WeakReferenceMessenger.Default.Register<MainWindow, FilePickerRequestMessage>(this, static (r, m) =>
            {
                m.Reply(HandleFilePickerRequestMessage(r, m.Options)); // Send the result back to the ViewModel
            });

            base.OnLoaded(e);
        }
        static async Task<IEnumerable<IStorageFile>> HandleFilePickerRequestMessage(MainWindow w, FilePickerOpenOptions o)
        {
            var ret = await w.StorageProvider.OpenFilePickerAsync(o);
            return ret;
        }
    }
}