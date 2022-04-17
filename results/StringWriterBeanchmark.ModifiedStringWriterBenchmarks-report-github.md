``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)
Intel Core i5-7300HQ CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=7.0.100-preview.3.22179.4
  [Host]     : .NET 7.0.0 (7.0.22.17504), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.17504), X64 RyuJIT


```
|                                       Method |       Mean |      Error |     StdDev |  Gen 0 | Allocated |
|--------------------------------------------- |-----------:|-----------:|-----------:|-------:|----------:|
|         StringWriterWriteStringInterpolation |  38.124 ns |  0.8304 ns |  0.8528 ns | 0.0178 |      56 B |
|                      StringWriterWriteString |   9.947 ns |  0.0824 ns |  0.0688 ns |      - |         - |
|                        StringWriterWriteSpan |  10.425 ns |  0.0901 ns |  0.0799 ns |      - |         - |
|               StringWriterWriteStringBuilder |  18.198 ns |  0.1215 ns |  0.1136 ns |      - |         - |
|                        StringWriterWriteBool |  10.651 ns |  0.0472 ns |  0.0394 ns |      - |         - |
|                        StringWriterWriteByte |  12.040 ns |  0.3147 ns |  0.2790 ns |      - |         - |
|                         StringWriterWriteInt |  20.754 ns |  0.1533 ns |  0.1280 ns |      - |         - |
|                        StringWriterWriteLong |  47.405 ns |  0.3707 ns |  0.3286 ns |      - |         - |
|                        StringWriterWriteUInt |  23.550 ns |  0.5272 ns |  0.7217 ns |      - |         - |
|                       StringWriterWriteULong |  39.761 ns |  0.1112 ns |  0.1040 ns |      - |         - |
|                        StringWriterWriteChar |   6.749 ns |  0.1918 ns |  0.1794 ns |      - |         - |
|                   StringWriterWriteCharArray |  12.461 ns |  0.2994 ns |  0.2501 ns |      - |         - |
|              StringWriterWriteCharArrayChunk |  12.130 ns |  0.3039 ns |  0.4056 ns |      - |         - |
|                     StringWriterWriteDecimal | 117.122 ns |  2.4169 ns |  4.3581 ns |      - |         - |
|                      StringWriterWriteDouble | 193.187 ns |  3.7176 ns |  3.6512 ns |      - |         - |
|                       StringWriterWriteFloat | 156.453 ns |  3.1696 ns |  6.1068 ns |      - |         - |
|                      StringWriterWriteObject |  65.341 ns |  1.0348 ns |  0.8641 ns | 0.0408 |     128 B |
|                     StringWriterWriteFormat1 |  58.284 ns |  1.2231 ns |  2.8591 ns | 0.0102 |      32 B |
|                     StringWriterWriteFormat2 | 158.928 ns |  2.9878 ns |  2.6486 ns | 0.0176 |      56 B |
|                     StringWriterWriteFormat3 | 312.774 ns |  3.0781 ns |  2.5704 ns | 0.0277 |      88 B |
|                     StringWriterWriteFormat4 | 607.754 ns |  3.7974 ns |  3.5521 ns | 0.0534 |     168 B |
|     StringWriterWriteLineStringInterpolation |  40.241 ns |  0.4884 ns |  0.4329 ns | 0.0178 |      56 B |
|                  StringWriterWriteLineString |  14.759 ns |  0.3236 ns |  0.3027 ns |      - |         - |
|                    StringWriterWriteLineSpan |  17.359 ns |  0.4228 ns |  0.7731 ns |      - |         - |
|           StringWriterWriteLineStringBuilder |  26.404 ns |  0.5801 ns |  0.9850 ns |      - |         - |
|                    StringWriterWriteLineBool |  18.796 ns |  0.4389 ns |  0.4105 ns |      - |         - |
|                    StringWriterWriteLineByte |  22.986 ns |  0.4867 ns |  0.6329 ns |      - |         - |
|                     StringWriterWriteLineInt |  31.501 ns |  0.4972 ns |  0.4152 ns |      - |         - |
|                    StringWriterWriteLineLong |  65.247 ns |  0.5804 ns |  0.4846 ns |      - |         - |
|                    StringWriterWriteLineUInt |  33.774 ns |  0.3990 ns |  0.3537 ns |      - |         - |
|                   StringWriterWriteLineULong |  53.151 ns |  1.0591 ns |  0.9907 ns |      - |         - |
|                    StringWriterWriteLineChar |  15.487 ns |  0.2697 ns |  0.2252 ns |      - |         - |
|               StringWriterWriteLineCharArray |  23.183 ns |  0.5076 ns |  0.5213 ns |      - |         - |
|          StringWriterWriteLineCharArrayChunk |  21.177 ns |  0.2027 ns |  0.1693 ns |      - |         - |
|                 StringWriterWriteLineDecimal | 123.636 ns |  1.1039 ns |  0.9218 ns |      - |         - |
|                  StringWriterWriteLineDouble | 221.346 ns |  4.3684 ns |  5.2003 ns |      - |         - |
|                   StringWriterWriteLineFloat | 176.999 ns |  1.1321 ns |  1.0036 ns |      - |         - |
|                  StringWriterWriteLineObject |  80.296 ns |  0.9897 ns |  0.8774 ns | 0.0408 |     128 B |
|                 StringWriterWriteLineFormat1 |  74.787 ns |  1.5258 ns |  1.6959 ns | 0.0101 |      32 B |
|                 StringWriterWriteLineFormat2 | 163.317 ns |  1.1898 ns |  0.9936 ns | 0.0176 |      56 B |
|                 StringWriterWriteLineFormat3 | 330.836 ns |  3.9549 ns |  3.3025 ns | 0.0277 |      88 B |
|                 StringWriterWriteLineFormat4 | 638.085 ns | 11.5955 ns | 11.9077 ns | 0.0534 |     168 B |
|         StringWriterWriteReadOnlyMemoryAsync |  17.508 ns |  0.2187 ns |  0.2045 ns |      - |         - |
|          StringWriterWriteStringBuilderAsync |  19.682 ns |  0.1580 ns |  0.1401 ns |      - |         - |
|                   StringWriterWriteCharAsync |   8.878 ns |  0.2142 ns |  0.3862 ns |      - |         - |
|              StringWriterWriteCharArrayAsync |  14.094 ns |  0.2766 ns |  0.2452 ns |      - |         - |
|         StringWriterWriteCharArrayChunkAsync |  12.478 ns |  0.0495 ns |  0.0413 ns |      - |         - |
|                 StringWriterWriteStringAsync |  11.353 ns |  0.1005 ns |  0.0891 ns |      - |         - |
|     StringWriterWriteInterpolatedStringAsync |  38.526 ns |  0.7624 ns |  1.6248 ns | 0.0178 |      56 B |
|     StringWriterWriteLineReadOnlyMemoryAsync |  22.911 ns |  0.3824 ns |  0.3577 ns |      - |         - |
|      StringWriterWriteLineStringBuilderAsync |  28.699 ns |  0.5388 ns |  0.5292 ns |      - |         - |
|               StringWriterWriteLineCharAsync |  17.858 ns |  0.3917 ns |  0.5094 ns |      - |         - |
|          StringWriterWriteLineCharArrayAsync |  22.420 ns |  0.2846 ns |  0.2662 ns |      - |         - |
|     StringWriterWriteLineCharArrayChunkAsync |  22.025 ns |  0.4637 ns |  0.5155 ns |      - |         - |
|             StringWriterWriteLineStringAsync |  18.136 ns |  0.3880 ns |  0.4619 ns |      - |         - |
| StringWriterWriteLineInterpolatedStringAsync |  38.866 ns |  0.2962 ns |  0.2625 ns | 0.0178 |      56 B |
