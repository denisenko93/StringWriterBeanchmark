using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace StringWriterBeanchmark;

[MemoryDiagnoser]
public class ModifiedStringWriterBenchmarks
{
    private StringWriter stringWriter;
    private string str;
    private ReadOnlyMemory<char> readOnlyMemory;
    private StringBuilder childStringBuilder;
    private bool boolValue;
    private byte byteValue;
    private char charValue;
    private char[] charArray;
    private int intValue;
    private long longValue;
    private decimal decimalValue;
    private double doubleValue;
    private float floatValue;
    private Guid guidValue;

    [GlobalSetup]
    public void Setup()
    {
        stringWriter = new StringWriter();
        str = "Hello world";
        readOnlyMemory = str.AsMemory();
        childStringBuilder = new StringBuilder(str);
        boolValue = true;
        byteValue = 222;
        charValue = str[0];
        charArray = str.ToCharArray();
        decimalValue = 4851337.922008482m;
        doubleValue = (double)decimalValue;
        floatValue = (float)doubleValue;
        intValue = int.MaxValue;
        longValue = long.MinValue;
        guidValue = Guid.NewGuid();
    }

    [Benchmark]
    public TextWriter StringWriterWriteStringInterpolation()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write($"Hello {str}");

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteString()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(str);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteSpan()
    {
        stringWriter.GetStringBuilder().Clear();
        ReadOnlySpan<char> helloWorld = str;
        stringWriter.Write(helloWorld);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteStringBuilder()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(childStringBuilder);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteBool()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(boolValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteByte()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(byteValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteInt()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(intValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLong()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(longValue);

        return stringWriter;
    }


    [Benchmark]
    public TextWriter StringWriterWriteUInt()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write((uint)intValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteULong()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write((ulong)longValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteChar()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(charValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteCharArray()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(charArray);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteCharArrayChunk()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(charArray, 0, 10);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteDecimal()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(decimalValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteDouble()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(doubleValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteFloat()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(floatValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteObject()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write(guidValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteFormat1()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write("{0}", guidValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteFormat2()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write("{0}, {1}", guidValue, longValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteFormat3()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write("{0}, {1}, {2}", guidValue, longValue, decimalValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteFormat4()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.Write("{0}, {1}, {2}, {3}", guidValue, longValue, decimalValue, doubleValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineStringInterpolation()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine($"Hello {str}");

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineString()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(str);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineSpan()
    {
        stringWriter.GetStringBuilder().Clear();
        ReadOnlySpan<char> helloWorld = str;
        stringWriter.WriteLine(helloWorld);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineStringBuilder()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(childStringBuilder);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineBool()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(boolValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineByte()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(byteValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineInt()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(intValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineLong()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(longValue);

        return stringWriter;
    }


    [Benchmark]
    public TextWriter StringWriterWriteLineUInt()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine((uint)intValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineULong()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine((ulong)longValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineChar()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(charValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineCharArray()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(charArray);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineCharArrayChunk()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(charArray, 0, 10);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineDecimal()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(decimalValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineDouble()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(doubleValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineFloat()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(floatValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineObject()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine(guidValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineFormat1()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine("{0}", guidValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineFormat2()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine("{0}, {1}", guidValue, longValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineFormat3()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine("{0}, {1}, {2}", guidValue, longValue, decimalValue);

        return stringWriter;
    }

    [Benchmark]
    public TextWriter StringWriterWriteLineFormat4()
    {
        stringWriter.GetStringBuilder().Clear();
        stringWriter.WriteLine("{0}, {1}, {2}, {3}", guidValue, longValue, decimalValue, doubleValue);

        return stringWriter;
    }

    [Benchmark]
    public Task StringWriterWriteReadOnlyMemoryAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteAsync(readOnlyMemory);
    }

    [Benchmark]
    public Task StringWriterWriteStringBuilderAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteAsync(childStringBuilder);
    }

    [Benchmark]
    public Task StringWriterWriteCharAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteAsync(charValue);
    }

    [Benchmark]
    public Task StringWriterWriteCharArrayAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteAsync(charArray);
    }

    [Benchmark]
    public Task StringWriterWriteCharArrayChunkAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteAsync(charArray, 0, 10);
    }

    [Benchmark]
    public Task StringWriterWriteStringAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteAsync(str);
    }

    [Benchmark]
    public Task StringWriterWriteInterpolatedStringAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteAsync($"Hello {str}");
    }

    [Benchmark]
    public Task StringWriterWriteLineReadOnlyMemoryAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteLineAsync(readOnlyMemory);
    }

    [Benchmark]
    public Task StringWriterWriteLineStringBuilderAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteLineAsync(childStringBuilder);
    }

    [Benchmark]
    public Task StringWriterWriteLineCharAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteLineAsync(charValue);
    }

    [Benchmark]
    public Task StringWriterWriteLineCharArrayAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteLineAsync(charArray);
    }

    [Benchmark]
    public Task StringWriterWriteLineCharArrayChunkAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteLineAsync(charArray, 0, 10);
    }

    [Benchmark]
    public Task StringWriterWriteLineStringAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteLineAsync(str);
    }

    [Benchmark]
    public Task StringWriterWriteLineInterpolatedStringAsync()
    {
        stringWriter.GetStringBuilder().Clear();
        return stringWriter.WriteLineAsync($"Hello {str}");
    }
}