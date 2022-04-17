using BenchmarkDotNet.Running;
using StringWriterBeanchmark;

BenchmarkRunner.Run(typeof(Program).Assembly);