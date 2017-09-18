# WinSerWat
A configurable library for monitoring and controlling a Windows service using a windows system tray icon.

## Features
Using the provided "ServiceMonitorIcon" short for "Windows Service Monitor Icon" project one can quickly customize a Windows service tray icon for monitoring a Windows service configurable through the app configuration file "ServiceMonitorIcon.exe.config" in the "Bin" directory.  Additionaly should one opt for a more custom tailored solution there's the "WinSerWat" nuget package which should allow a developer to completely overhaul the icon and menu generated.

## Status
I think it works but my own testing has been extremely minimal.

## Wishlist
If I continue to work on this project I would like to implement the following features
* Document Code
* Write a wrapper class for the ServiceController class
* Reduce dependencies for a consumer of the library
* Add support to monitor regular windows processes
* Write basic instructions on custom WinSerWat ServiceWatchers
* Write basic instructions on how to properly consume the ServierWatcher in a custom application

## Credit

This project uses images obtained by the https://thenounproject.com, more specific license information can be found in the "licenses.txt" file in the "Icons" directory under "Source".