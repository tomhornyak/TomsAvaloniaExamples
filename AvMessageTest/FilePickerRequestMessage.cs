using CommunityToolkit.Mvvm.Messaging.Messages;
using Avalonia.Platform.Storage;
using System.Collections.Generic;
using System.Text;

namespace AvMessageTest
{
    public class FilePickerRequestMessage : AsyncRequestMessage<IEnumerable<IStorageFile>?>
    {
        public FilePickerOpenOptions Options { get; }
        public FilePickerRequestMessage(FilePickerOpenOptions options) => Options = options;
    }
}
