echo off
cls
cd /d %~dp0

echo Building Release 'PortableRegistrator' ...
echo ----------------------------------------------
echo.

md RELEASE
cp PortableRegistrator\bin\Release\PortableRegistrator.exe RELEASE
cp PortableRegistrator\bin\Release\ReleaseNotes.txt RELEASE
cp PortableRegistratorCLI\bin\Release\PortableRegistratorCLI.exe RELEASE
