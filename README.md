# PORTABLE Registrator
### for Windows 7+

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

Have fun and enjoy.


#### CREDITS:

###### App Icon:
https://iconarchive.com/show/3d-bluefx-desktop-icons-by-wallpaperfx/Usb-icon.html
Backlink: http://www.wallpaperfx.com

###### Inspired by:
https://www.winhelponline.com/blog/register-firefox-portable-with-default-programs-in-vista/
