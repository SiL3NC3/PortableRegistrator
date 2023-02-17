# PORTABLE Registrator
### for Windows 7, 8, 10 (untested 11)

Also got into trouble using your favorite browser or mail program on a pendrive?
Then this one is for you!

Easily register any portable app as a default program in Windows.
This will allow you to directly open weblinks (http/https URLs) with the portable browser of your choice. 

![image](https://user-images.githubusercontent.com/694970/156938629-9d0bb3b4-bd23-4fda-84b4-df909e410f28.png)

### Configuration

On the first start a configuration file is being generated to provide default settings for the AppTypes.

The default available AppType are:

```
<?xml version="1.0"?>
<Configuration xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <AppTypes>
    <AppType>
      <Name>Web-Browser</Name>
      <OpenParameters>-url "%1"</OpenParameters>
      <FileAssociations>
        <string>.htm</string>
        <string>.html</string>
        <string>.shtml</string>
        <string>.xht</string>
        <string>.xhtml</string>
      </FileAssociations>
      <URLAssociations>
        <string>http</string>
        <string>https</string>
        <string>ftp</string>
      </URLAssociations>
    </AppType>
    <AppType>
      <Name>Mail-Program</Name>
      <OpenParameters>"%1"</OpenParameters>
      <FileAssociations>
        <string>.xpi</string>
        <string>.eml</string>
        <string>.msg</string>
        <string>.ics</string>
        <string>.mbox</string>
      </FileAssociations>
      <URLAssociations>
        <string>mailto</string>
      </URLAssociations>
    </AppType>
  </AppTypes>
</Configuration>
```

To be as flexible as possible, you can extend any kind of application within the configuration file.
For any app specific needs, others than browser or mail, try adding a new "AppType" section there.

Example:
```
<?xml version="1.0"?>
<Configuration xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <AppTypes>
  
    ... (other AppType elements)
    
    <AppType>
      <Name>Image-Viewer</Name>                           <--- 1.
      <OpenParameters>-parameter "%1"</OpenParameters>    <--- 2. 
      <FileAssociations>
        <string>.jpg</string>                             <--- 3.
        <string>.gif</string>
        <string>...</string>
      </FileAssociations>
      <URLAssociations>
        <string>view</string>                             <--- 4.
      </URLAssociations>
    </AppType>
    
  </AppTypes>
</Configuration>
```
1. Name the new AppType
2. Set the supported open parameter of the program ("%1" passes the parameter to the portable executable)
3. Register all file associations
4. Register all URL associations, if not needed remove the lines inbetween

At best copy a full AppType section and edit it to your needs.

Possibly not every software will work, but give it a shot and share your experience.

You can use the ADD Button to easily add new Program-Types.
After manual editing the Reset-Button will now also reloads the Configuration file and repopulate the Program-Types.

Have fun and enjoy.


#### CREDITS:

###### App Icon:
https://iconarchive.com/show/3d-bluefx-desktop-icons-by-wallpaperfx/Usb-icon.html
Backlink: http://www.wallpaperfx.com

###### Inspired by:
https://www.winhelponline.com/blog/register-firefox-portable-with-default-programs-in-vista/
