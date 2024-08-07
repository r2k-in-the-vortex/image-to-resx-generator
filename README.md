# code snippet for generating resx string out of image

e.g.

```xml
  <data name="happy" type="System.Drawing.Bitmap, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
    <value>
        /9j/4AAQSkZJRgABAQEA.....
    </value>
  </data>
  ```

# build command 

& "C:/Program Files (x86)/Microsoft Visual Studio/2022/BuildTools/MSBuild/Current/Bin/MSBuild.exe" .\resximagetest.csproj