// See https://aka.ms/new-console-template for more information
using OCPEx2Initial;

Console.WriteLine("OCPExample2- OCPEx2Initial!");
Console.WriteLine("Filtering computer monitor example!");

// The idea here is 
// Let's imagine we have a task to write an application which give us all required information about computer monitors in our shop based on different criteria.
// We will introduce only two criteria here, the type of monitors and screen size.


// To Support this application, we have created two enum's and MonitorFilter and ComputerMonitor classes

// Here is our client logic.

var monitors = new List<ComputerMonitor>()
    { 
        new ComputerMonitor{ Name = "Samsung S345", Screen = Screen.CurvedScreen, MonitorType = MonitorType.OLED },
        new ComputerMonitor{ Name = "Philips P532", Screen = Screen.WideScreen, MonitorType = MonitorType.LCD },
        new ComputerMonitor{ Name = "LG L888", Screen = Screen.WideScreen, MonitorType = MonitorType.LED },
        new ComputerMonitor{ Name = "Samsung S999", Screen = Screen.WideScreen, MonitorType = MonitorType.OLED },
        new ComputerMonitor{ Name = "Dell D2J47", Screen = Screen.CurvedScreen, MonitorType = MonitorType.LCD },
    };

var filter = new MonitorFilter();

var lcdMonitors = filter.FilterByMonitorType(monitors, MonitorType.LCD);

Console.WriteLine("ALL LCD Monitors (This is our first requirement)");
Console.WriteLine("=================================================");
foreach (var monitor in lcdMonitors)
{
    Console.WriteLine($" Name: {monitor.Name}, Screen: {monitor.Screen}, Type: {monitor.MonitorType}");
}
Console.WriteLine("==================================================");

// Assume the above code is in our shop and we are using it for quite some time. 
// One day we got another requirement to filter it based on Screen

// So we have to add another FilterByScreen method into our MonitorFilter class ( This violates OCP )

// So now we modified the Computer Monitor class, and modifying our client code to add the new feature

var filterByCurvedScreen = filter.FilterByScreen(monitors, Screen.CurvedScreen);


Console.WriteLine("ALL CurvedScreen Monitors (This is our 2nd requirement)");
Console.WriteLine("=====================================================");

foreach (var monitor in filterByCurvedScreen)
{
    Console.WriteLine($" Name: {monitor.Name}, Screen: {monitor.Screen}, Type: {monitor.MonitorType}");
}
Console.WriteLine("=====================================================");

// This program works , but
// if you observe this program carefully , we have to modify the existing classes for any new requirement
// So in order to avoid modifying existing classes, we can rewrite this program in a different way

// Now look into OCPEx2Final project