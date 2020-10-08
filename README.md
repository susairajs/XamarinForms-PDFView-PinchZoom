# XamarinForms PDFView PinchZoom

Checkout blog here https://xamarinmonkeys.blogspot.com/2020/06/xamarinforms-working-with-pdfview-and.html

## PDF Viewer
 
### The Problem(Android)
 
PDFView doesn't support the default webview in android xamarin forms.
 
### Solution
 
PDFView is the biggest issue in android webview. I solved this problem by using google drive viewer and google doc viewer there is another way to view pdf files using pdfjs. But pdfjs doesn't support pinch zoom.
 
https://github.com/mozilla/pdf.js/issues/2582
 
### Note
The pdf URL must be an extension, PDF, and public.

# Sample Results
## Android 
You can test Pinch zoom by emulator also use Shift + ctrl + Left click and mouse move

![alt text](https://1.bp.blogspot.com/-LsuqbMFeZk0/XueOlziUSoI/AAAAAAAAIms/IVp3oxLi8JgkX3fqmkyGUoIKZtdL0pmrQCK4BGAsYHg/s595/android.PNG)

## iOS 
Simulator also supports pinch-zoom use Alt + Left click and mouse move

![alt text](https://1.bp.blogspot.com/-YVX0tMESHHQ/XueOyogVlYI/AAAAAAAAIm8/wPZpYtGvrAUHUV-E576WySzyDfN3NoxMQCK4BGAsYHg/s600/ios.PNG)
 
