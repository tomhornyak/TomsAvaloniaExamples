# AvCanvasTest
This repository contains 2 solutions.
1. CanvasTest is a modified demo from AvaloniaUI.
2. CanvasTest2 is an example of what I am tring to achive.

I have encountered the following issues.
1. The Tiles added in the view model constructor Do not appear, althoughg the Accerate Developer tools shows the itemes in the list. Also, clicking the "Get Canvas" button will show that the canvas has the tiles as children.
2. Clicking the add and move butons don't diplay anything either. But again the Tile is on the canvas.
3. All the change events seems to be filing properly.

Have I discovered a bug or limitation of AvaloniaUI? Or am I doing something wrong?
I am porting a WPF app that has no problems displaying contorls on a canvas.
Also note, previously my app manipulating the canvas directly. But then I drank the Kool-Aid(r) and decided to use the MVVM approach as it made testing easier.
