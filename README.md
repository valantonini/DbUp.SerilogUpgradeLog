# DbUp.SerilogUpgradeLog

Serilog IUpgradeLog implementation


###Usage:

```c#
var upgrader =
     DeployChanges.To
         .SqlDatabase("")
         .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
         .LogToConsole()
         .LogTo(new SerilogUpgradeLogger())
         .Build();
```
