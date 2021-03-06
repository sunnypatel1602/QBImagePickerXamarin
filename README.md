# QBImagePickerXamrin

Objective-C Version : https://github.com/questbeat/QBImagePicker

A clone of UIImagePickerController with multiple selection support.


## Features

- Allows multiple selection of photos and videos
- Fast and memory-efficient scrolling
- Provides similar user interface to the built-in image picker
- Customizable (grid size, navigation message, etc.)
- Supports both portrait mode and landscape mode
- Compatible with iPhone 6/6Plus, and iPad


## Example

	QBImagePickerController imagePickerController = new QBImagePickerController();
	imagePickerController.Delegate = new PickerDelegate(imagePickerController);
	imagePickerController.AllowsMultipleSelection = true;
	imagePickerController.MaximumNumberOfSelection = 6;
	imagePickerController.ShowsNumberOfSelectedAssets = true;
	this.PresentViewController(imagePickerController, true, null);



## License

Copyright (c) 2016 Sunny Patel

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
