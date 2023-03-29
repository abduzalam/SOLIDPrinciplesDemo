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