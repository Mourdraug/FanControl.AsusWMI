# FanControl.AsusWMI [![Build status](https://ci.appveyor.com/api/projects/status/mc33hki902w421le?svg=true)](https://ci.appveyor.com/project/Mourdraug/fancontrol-asuswmi)

Plugin for [FanControl](https://github.com/Rem0o/FanControl.Releases) providing access to Asus motherboard sensors using Asus WMI methods.

## Installation

1. Download the latest binaries from [Releases](https://github.com/Mourdraug/FanControl.AsusWMI/releases)
2. Copy the FanControl.AsusWMI.dll into FanControl's "Plugins" folder.

## Compatibility 

I tested the plugin with the Asus Crosshair Hero VII (WiFi) motherboard, but it should work with any motherboard using ASUSHW v3 and possibly v2.
The ASUSHW version can be checked with simple Powershell script (ran as administrator):

```
$asushw = Get-CimInstance -Namespace root/wmi -ClassName ASUSHW
Invoke-CimMethod $asushw -MethodName sensor_get_version
```
This should print out similar output:
```
Data ReturnValue PSComputerName
---- ----------- --------------
   3        True
```
