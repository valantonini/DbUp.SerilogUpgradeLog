# DbUp.SerilogUpgradeLog

Serilog IUpgradeLog implementation

###Installation
     Install-Package DbUp.SerilogUpgradeLogger

###Usage:

```c#
var upgrader =
     DeployChanges.To
         .SqlDatabase("")
         .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
         .LogToConsole()
         .LogToSerilog() //add this line
         .Build();
```
