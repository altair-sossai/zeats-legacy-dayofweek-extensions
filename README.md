<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-dayofweek-extensions

Extensions to solve common problems when using DayOfWeek

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-dayofweek-extensions?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=25&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.DayOfWeekExtensions.svg)](https://www.nuget.org/packages/Zeats.Legacy.DayOfWeekExtensions)

## Installation

```PM>
Install-Package Zeats.Legacy.DayOfWeekExtensions
```

## Extensions

### DayOfWeek.DayName()
Return Day name
```c#
DayOfWeek.Tuesday.DayName() /* return "Tuesday" - "en-us" */
DayOfWeek.Tuesday.DayName() /* return "Terça-feira" - "pt-br" */
```
---
