# FanControl.AsusWMI

Plugin for [FanControl](https://github.com/Rem0o/FanControl.Releases) providing access to Asus motherboard sensors using Asus WMI methods.

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
