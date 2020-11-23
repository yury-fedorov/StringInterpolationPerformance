# StringInterpolationPerformance

String Interpolation vs String Format, String Concat and String Builder performance benchmarks

## How to run the test
```
dotnet run -c Release
```

## Summary
### .NET 5
```
BenchmarkDotNet=v0.12.1, OS=macOS 11.0.1 (20B29) [Darwin 20.1.0]
Intel Core i7-6567U CPU 3.30GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |     Mean |   Error |  StdDev |
|-------------------- |---------:|--------:|--------:|
|        StringFormat | 178.8 ns | 2.57 ns | 2.41 ns |
| StringInterpolation | 101.4 ns | 1.43 ns | 1.20 ns |
|        StringConcat | 101.2 ns | 1.04 ns | 0.92 ns |
|       StringBuilder | 250.4 ns | 4.00 ns | 3.54 ns |

### .NET Core 3.1
```

BenchmarkDotNet=v0.12.1, OS=macOS 11.0.1 (20B29) [Darwin 20.1.0]
Intel Core i7-6567U CPU 3.30GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|              Method |     Mean |   Error |  StdDev |
|-------------------- |---------:|--------:|--------:|
|        StringFormat | 232.4 ns | 4.69 ns | 5.21 ns |
| StringInterpolation | 112.5 ns | 2.26 ns | 2.41 ns |
|        StringConcat | 110.8 ns | 1.25 ns | 1.11 ns |
|       StringBuilder | 249.5 ns | 4.25 ns | 3.77 ns |
