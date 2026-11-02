# AdminSpec (CounterStrikeSharp)

Small plugin to add "!spec" (css_spec) for admins.

- Uses "@css/ban" to allow or disallow command usage.
- Only the user can send himself to spec, can't be used to send someone else.

## Prerequisites

- CounterStrikeSharp version 1.0.378 or later.
- .NET 10 SDK.
- .NET 10 compiler like Visual Studio Community 2026.

## Building with Visual Studio

1. Clone the project.
2. Open "AdminSpec.slnx" or "AdminSpec.csproj" with Visual Studio.
3. Set build config to "Release" if needed.
4. Build

Files should appear in "Release/AdminSpec/" or "bin/Release/net10.0/".

## Building with dotnet in CLI
```bash
dotnet build AdminSpec.csproj -c Release
```

## Installation
### After building
Build the plugin using the previous section.

Put the AdminSpec.dll and AdminSpec.deps.json here :
```text
game/csgo/addons/counterstrikesharp/plugins/AdminSpec/
```

### Via downloaded release
Download the release [here](https://github.com/Cyrathec/AdminSpec/releases/latest)

Put  AdminSpec.zip here :
```text
game/csgo/addons/counterstrikesharp/plugins/
```

Unzip the file :
```bash
unzip AdminSpec.zip
```

Load the plugin with  :
```text
css_plugins load AdminSpec
```

Or restart the server

## Permissions

The plugins only allows players with "@css/ban" permission to execute the command. This is made so Admins can join spectators and investigate a potential cheater.
