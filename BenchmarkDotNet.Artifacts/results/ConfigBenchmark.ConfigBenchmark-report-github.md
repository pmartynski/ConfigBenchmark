``` ini

BenchmarkDotNet=v0.13.2, OS=ubuntu 20.04
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2


```
|                  Method |      Mean |     Error |    StdDev |
|------------------------ |----------:|----------:|----------:|
|         AppSettingsJson | 24.087 μs | 0.4670 μs | 0.4587 μs |
| AppSettingsJsonConstant |  8.377 μs | 0.1296 μs | 0.1212 μs |
|                InMemory |  4.784 μs | 0.0948 μs | 0.1298 μs |
|                 EnvVars | 12.077 μs | 0.1370 μs | 0.1215 μs |
