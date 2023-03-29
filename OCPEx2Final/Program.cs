// See https://aka.ms/new-console-template for more information
using OCPEx2Final;

Console.WriteLine("OCPEx2Final");

var monitors = new List<ComputerMonitor>()
    {
        new ComputerMonitor{ Name = "Samsung S345", Screen = Screen.CurvedScreen, MonitorType = MonitorType.OLED },
        new ComputerMonitor{ Name = "Philips P532", Screen = Screen.WideScreen, MonitorType = MonitorType.LCD },
        new ComputerMonitor{ Name = "LG L888", Screen = Screen.WideScreen, MonitorType = MonitorType.LED },
        new ComputerMonitor{ Name = "Samsung S999", Screen = Screen.WideScreen, MonitorType = MonitorType.OLED },
        new ComputerMonitor{ Name = "Dell D2J47", Screen = Screen.CurvedScreen, MonitorType = MonitorType.LCD },
    };

var filter = new MonitorFilter();
var lcdMonitors = filter.Filter(monitors, new MonitorTypeSpecification(MonitorType.LCD));
Console.WriteLine("All LCD monitors");
foreach (var monitor in lcdMonitors)
{
    Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.MonitorType}, Screen: {monitor.Screen}");
}