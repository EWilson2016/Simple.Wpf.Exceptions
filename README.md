# Simple.Wpf.Exceptions

[![Build status](https://ci.appveyor.com/api/projects/status/72staf3ivfet3699?svg=true)](https://ci.appveyor.com/project/oriches/simple-wpf-exceptions)

As with all my 'important' stuff it builds using the amazing [AppVeyor](https://ci.appveyor.com/project/oriches/simple-wpf-exceptions).

The app is skinned using [Mah Apps](http://mahapps.com/).

This isn't a definitive guide or 'proper' way to do exception handling in a WPF application (if there is one), it's my way of dealing with unhandled exceptions, it is *my opinion* :)

To many times I come across WPF applications which have either no or incomplete exception handling - typically observed as an application that just terminates unexpectedly without giving the user any info about why it crashed, and no easy way to report what happened to first line IT support.

In my opinion when an unhandled exception occurs, an application should do the following:

* Show the exception message (not the full stack info),
* Offer the user the explicit opportunity to copy the message (for us in an email conversation with support),
* Easy access to the log file folder (makes it easier to attach log file to any email conversation with support),
* Opportunity to terminates the application,
* Opportunity to restart the application,
* Opportunity to continue with current session of the application - obivously this mean possible invalid state etc.

This approach now targets version 4.6.1 of the Mircosoft .Net framework. This means any unhandled exceptions generated by the TPL & Rx will be propergated to the UI from the finalizer thread when ever the GC runs - this means there is a delay between propergation and observation of any exception.
