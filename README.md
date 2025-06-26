# C# Boxing/Unboxing and Generics Example

This repository contains two versions of the same C# demonstration project showing performance differences between boxing/unboxing operations and different object handling approaches.

## Projects

### CsharpBoxingUnboxingAndGenericsExample (.NET Framework 4.5.2)
The original project targeting .NET Framework 4.5.2:
- Uses traditional MSBuild project format
- Includes `App.config` for runtime configuration
- Includes `Properties/AssemblyInfo.cs` for assembly metadata
- Requires Windows and .NET Framework to build and run

### CsharpBoxingUnboxingAndGenericsExample.Net8 (.NET 8)
Modern version targeting .NET 8:
- Uses SDK-style project format
- Cross-platform compatible
- Assembly metadata defined in the project file
- No `App.config` needed

## Building and Running

### .NET Framework 4.5.2 Version (Windows only)
```bash
cd CsharpBoxingUnboxingAndGenericsExample
msbuild CsharpBoxingUnboxingAndGenericsExample.sln
# or open in Visual Studio and build
```

### .NET 8 Version (Cross-platform)
```bash
cd CsharpBoxingUnboxingAndGenericsExample.Net8
dotnet build
dotnet run
```

## What the Program Demonstrates

Both versions run the same performance tests comparing:
1. **Object vs Long comparison**: Shows the performance impact of boxing/unboxing value types
2. **Object vs Class comparison**: Demonstrates performance differences between:
   - Direct class access
   - Casting from object
   - Dynamic typing

The program outputs timing information showing how different approaches to object handling affect performance.