``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)
Intel Core i5-7300HQ CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=7.0.100-preview.3.22179.4
  [Host]     : .NET 7.0.0 (7.0.22.17504), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.17504), X64 RyuJIT


```
|                                       Method |       Mean |      Error |     StdDev |     Median |  Gen 0 | Allocated |
|--------------------------------------------- |-----------:|-----------:|-----------:|-----------:|-------:|----------:|
|         StringWriterWriteStringInterpolation |  29.332 ns |  0.2795 ns |  0.2334 ns |  29.287 ns | 0.0179 |      56 B |
|                      StringWriterWriteString |   8.039 ns |  0.0609 ns |  0.0476 ns |   8.044 ns |      - |         - |
|                        StringWriterWriteSpan |  10.390 ns |  0.2828 ns |  0.3257 ns |  10.342 ns |      - |         - |
|               StringWriterWriteStringBuilder |  17.307 ns |  0.3148 ns |  0.2790 ns |  17.235 ns |      - |         - |
|                        StringWriterWriteBool |   9.624 ns |  0.2685 ns |  0.4100 ns |   9.400 ns |      - |         - |
|                        StringWriterWriteByte |  27.498 ns |  0.2067 ns |  0.1832 ns |  27.545 ns | 0.0102 |      32 B |
|                         StringWriterWriteInt |  40.762 ns |  0.8893 ns |  1.1872 ns |  40.286 ns | 0.0153 |      48 B |
|                        StringWriterWriteLong |  67.908 ns |  0.4741 ns |  0.4203 ns |  67.883 ns | 0.0204 |      64 B |
|                        StringWriterWriteUInt |  40.466 ns |  0.3774 ns |  0.3152 ns |  40.595 ns | 0.0153 |      48 B |
|                       StringWriterWriteULong |  63.227 ns |  1.3255 ns |  2.2146 ns |  62.054 ns | 0.0204 |      64 B |
|                        StringWriterWriteChar |   5.146 ns |  0.0912 ns |  0.0808 ns |   5.113 ns |      - |         - |
|                   StringWriterWriteCharArray |  12.499 ns |  0.1664 ns |  0.1556 ns |  12.520 ns |      - |         - |
|              StringWriterWriteCharArrayChunk |  11.320 ns |  0.1505 ns |  0.1407 ns |  11.297 ns |      - |         - |
|                     StringWriterWriteDecimal | 136.305 ns |  2.7478 ns |  2.4359 ns | 135.889 ns | 0.0176 |      56 B |
|                      StringWriterWriteDouble | 227.560 ns |  1.2109 ns |  0.9454 ns | 227.782 ns | 0.0176 |      56 B |
|                       StringWriterWriteFloat | 176.117 ns |  0.5909 ns |  0.5238 ns | 176.126 ns | 0.0126 |      40 B |
|                      StringWriterWriteObject |  75.887 ns |  1.5607 ns |  2.0835 ns |  75.829 ns | 0.0408 |     128 B |
|                     StringWriterWriteFormat1 | 125.454 ns |  2.4750 ns |  2.3151 ns | 126.322 ns | 0.0408 |     128 B |
|                     StringWriterWriteFormat2 | 232.236 ns |  4.6166 ns |  5.8385 ns | 231.430 ns | 0.0637 |     200 B |
|                     StringWriterWriteFormat3 | 386.059 ns |  6.7142 ns |  8.9632 ns | 382.854 ns | 0.0839 |     264 B |
|                     StringWriterWriteFormat4 | 679.722 ns | 12.2758 ns | 11.4828 ns | 676.576 ns | 0.1221 |     384 B |
|     StringWriterWriteLineStringInterpolation |  34.447 ns |  0.5718 ns |  0.5349 ns |  34.233 ns | 0.0178 |      56 B |
|                  StringWriterWriteLineString |  12.279 ns |  0.1643 ns |  0.1537 ns |  12.250 ns |      - |         - |
|                    StringWriterWriteLineSpan |  17.185 ns |  0.1061 ns |  0.0940 ns |  17.196 ns |      - |         - |
|           StringWriterWriteLineStringBuilder |  25.638 ns |  0.3945 ns |  0.3690 ns |  25.699 ns |      - |         - |
|                    StringWriterWriteLineBool |  18.262 ns |  0.0770 ns |  0.0682 ns |  18.251 ns |      - |         - |
|                    StringWriterWriteLineByte |  38.738 ns |  0.3652 ns |  0.3237 ns |  38.741 ns | 0.0102 |      32 B |
|                     StringWriterWriteLineInt |  51.606 ns |  0.5792 ns |  0.5135 ns |  51.491 ns | 0.0153 |      48 B |
|                    StringWriterWriteLineLong |  79.397 ns |  0.5831 ns |  0.5169 ns |  79.359 ns | 0.0204 |      64 B |
|                    StringWriterWriteLineUInt |  51.785 ns |  0.2442 ns |  0.2284 ns |  51.785 ns | 0.0153 |      48 B |
|                   StringWriterWriteLineULong |  75.548 ns |  1.5562 ns |  2.3765 ns |  75.014 ns | 0.0204 |      64 B |
|                    StringWriterWriteLineChar |  15.115 ns |  0.2090 ns |  0.1955 ns |  15.078 ns |      - |         - |
|               StringWriterWriteLineCharArray |  20.872 ns |  0.2745 ns |  0.2434 ns |  20.875 ns |      - |         - |
|          StringWriterWriteLineCharArrayChunk |  20.483 ns |  0.3426 ns |  0.3037 ns |  20.439 ns |      - |         - |
|                 StringWriterWriteLineDecimal | 143.557 ns |  1.4418 ns |  1.3487 ns | 143.393 ns | 0.0176 |      56 B |
|                  StringWriterWriteLineDouble | 242.508 ns |  1.3970 ns |  1.1665 ns | 242.660 ns | 0.0176 |      56 B |
|                   StringWriterWriteLineFloat | 192.983 ns |  3.8381 ns |  3.5901 ns | 193.535 ns | 0.0126 |      40 B |
|                  StringWriterWriteLineObject |  78.423 ns |  0.3183 ns |  0.2658 ns |  78.469 ns | 0.0408 |     128 B |
|                 StringWriterWriteLineFormat1 | 126.250 ns |  0.5309 ns |  0.4433 ns | 126.240 ns | 0.0408 |     128 B |
|                 StringWriterWriteLineFormat2 | 224.180 ns |  2.4989 ns |  2.3375 ns | 224.284 ns | 0.0637 |     200 B |
|                 StringWriterWriteLineFormat3 | 378.024 ns |  3.4733 ns |  2.9004 ns | 377.439 ns | 0.0839 |     264 B |
|                 StringWriterWriteLineFormat4 | 704.508 ns | 13.9087 ns | 22.0606 ns | 703.223 ns | 0.1221 |     384 B |
|         StringWriterWriteReadOnlyMemoryAsync |  16.411 ns |  0.3664 ns |  0.3598 ns |  16.314 ns |      - |         - |
|          StringWriterWriteStringBuilderAsync |  19.428 ns |  0.3374 ns |  0.2991 ns |  19.586 ns |      - |         - |
|                   StringWriterWriteCharAsync |   7.805 ns |  0.1833 ns |  0.1715 ns |   7.716 ns |      - |         - |
|              StringWriterWriteCharArrayAsync |  14.522 ns |  0.3170 ns |  0.3114 ns |  14.561 ns |      - |         - |
|         StringWriterWriteCharArrayChunkAsync |  14.004 ns |  0.3155 ns |  0.5848 ns |  13.999 ns |      - |         - |
|                 StringWriterWriteStringAsync |  10.187 ns |  0.2442 ns |  0.3730 ns |  10.233 ns |      - |         - |
|     StringWriterWriteInterpolatedStringAsync |  32.046 ns |  0.6764 ns |  1.5676 ns |  31.480 ns | 0.0179 |      56 B |
|     StringWriterWriteLineReadOnlyMemoryAsync |  23.130 ns |  0.2956 ns |  0.2765 ns |  23.137 ns |      - |         - |
|      StringWriterWriteLineStringBuilderAsync |  28.007 ns |  0.5988 ns |  0.6656 ns |  27.870 ns |      - |         - |
|               StringWriterWriteLineCharAsync |  15.986 ns |  0.1529 ns |  0.1430 ns |  15.972 ns |      - |         - |
|          StringWriterWriteLineCharArrayAsync |  22.444 ns |  0.2672 ns |  0.2500 ns |  22.390 ns |      - |         - |
|     StringWriterWriteLineCharArrayChunkAsync |  21.951 ns |  0.4612 ns |  0.3851 ns |  21.984 ns |      - |         - |
|             StringWriterWriteLineStringAsync |  14.779 ns |  0.3351 ns |  0.6995 ns |  14.471 ns |      - |         - |
| StringWriterWriteLineInterpolatedStringAsync |  36.365 ns |  0.7607 ns |  1.5880 ns |  36.329 ns | 0.0178 |      56 B |
