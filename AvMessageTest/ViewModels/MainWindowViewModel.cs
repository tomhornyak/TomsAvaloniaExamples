using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Threading.Tasks;

namespace AvMessageTest.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {

        [RelayCommand]
        public async Task Click()
        {
            {
                var options = new FilePickerOpenOptions
                {
                    Title = "Select a File",
                    AllowMultiple = false,
                    FileTypeFilter =
                    [
                        new FilePickerFileType("Card Files")
                    {
                        Patterns = new[] { "*.ikx" }
                    },
                    new FilePickerFileType("All Files")
                    {
                        Patterns = new[] { "*.*" }
                    }
                    ]
                };

                // Send the request and wait for the result
                var files = await WeakReferenceMessenger.Default.Send(new FilePickerRequestMessage(options));
                if (files != null)
                {
                    foreach (var file in files)
                    {
                        // Do something with the selected file(s)
                        // like pass it to the model for processing or display the file in the UI.
                        System.Diagnostics.Debug.WriteLine($"Selected file: {file.TryGetLocalPath()}");
                    }
                }
            }
        }
    }
}
