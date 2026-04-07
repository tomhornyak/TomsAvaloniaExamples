# AvCanvasTest

This repository contains 3 solutions.

1. CanvasTest is a modified demo from AvaloniaUI placing and moving shapes on a canvas. Click "Add Tile" to add a tile and "Move Tile" to move it.
2. CanvasTest2 is an example placing and moving 2 different types of controls. Clicking the buttons works as above. Note, the ICustomControl cannot be referenced in the in the .axaml, it needs a class that is an ICustomControl. LaurentInSeattle helped me with this one.
3. AvMessageTest is an example of an MVVM pattern to have the view request a file name from the viewmmodel, which requests the view to open the StorageProvider.OpenFilePickerAsync and pass the file information back to the viewmodel. Which can then be passed to the model. It is an example of using async messaging from the community mvvm package. I cold not find a working example, so with the help of the fine folks in the Avaloina discussion group (especially MattKatz6), I wrote a working example.
