using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace StringInterpolationPerformance
{
    class Program
    {
        static void Main(string[] args) => BenchmarkRunner.Run<StringFormatTest>();
    }

    public class StringFormatTest
    {
        private readonly string data1 = Guid.NewGuid().ToString();
        private readonly string data2 = Guid.NewGuid().ToString();
        private readonly string data3 = Guid.NewGuid().ToString();

        [Benchmark]
        public string StringFormat() => string.Format("test format{0}, {1}, {2}", data1, data2, data3); 

        [Benchmark]
        public string StringInterpolation() => ($"test format{data1}, {data2}, {data3}");

        [Benchmark]
        public string StringConcat() => "test format" + data1 + ", " + data2 + ", " + data3;

        [Benchmark]
        public string StringBuilder() => (new StringBuilder()).Append("test format")
		.Append(data1).Append(", ")
		.Append(data2).Append(", ")
		.Append(data3).ToString();
    }
}
