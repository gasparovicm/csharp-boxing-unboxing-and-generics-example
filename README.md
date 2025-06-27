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

## Example Results for .NET 8

### 1. Object and Long Comparison

#### 1.1 Long Counter
- Cycle for `int.MaxValue`
- `longCounter = longCounter + 1;`
- **Time:** `00:00:00.5092826`

#### 1.2 Object Cast to Long
- `objectCounter = ((long)objectCounter) + 1;`
- **Time:** `00:00:06.2129234`

#### 1.3 Results
- `00:00:00.5092826` vs `00:00:06.2129234`
> **Conclusion:**  
  _The first method is **12.2 times faster** than the second._

### 2. Object, Cast, and Dynamic Object

- Cycle for `int.MaxValue`

#### 2.1 Direct Property
- `myClass.MyProperty1 = i;`

#### 2.2 Instance - Cast, Then Property
- `((Class1)myObject).MyProperty1 = i;`

#### 2.3 Dynamic Object, Property
- `myDynamic.MyProperty1 = i;`

#### 2.4 Results
- Direct property: `00:00:00.4678579`
- Cast then property: `00:00:00.5564897`
- Dynamic property: `00:00:07.3568084`

> **Conclusion:**  
> Using `dynamic` is significantly slower. Please use `dynamic` only when truly needed.
