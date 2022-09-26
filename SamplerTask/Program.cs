using Sampler;
using SamplerTests;
using System.Text.Json;
using System.Text.Json.Serialization;

var jsonOptions = new JsonSerializerOptions();
jsonOptions.Converters.Add(new JsonStringEnumConverter());

Console.WriteLine("Test data:");
Console.WriteLine(JsonSerializer.Serialize(TestData.TestList, jsonOptions));

Console.WriteLine($"{Environment.NewLine}Sampled data:");

var validator = new DefaultSampler(new DefaultValidator(5));
DateTime startDate = new DateTime(2017, 01, 03, 00, 00, 00);
var sampledData = validator.Sample(startDate, TestData.TestList);

Console.WriteLine(JsonSerializer.Serialize(sampledData, jsonOptions));
Console.ReadLine();
