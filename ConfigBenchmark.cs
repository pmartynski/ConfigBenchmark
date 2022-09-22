using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Configuration;

namespace ConfigBenchmark;

public class ConfigBenchmark
{
	[Benchmark]
	public void AppSettingsJson()
	{
		var config = new ConfigurationBuilder()
			.AddJsonFile("./appsettings.json")
			.Build();
		BindAndCheck(config);
	}

	[Benchmark]
	public void AppSettingsJsonConstant()
	{
		using var x = new MemoryStream(ConfigDefaults.JsonConfig);
		var config = new ConfigurationBuilder()
			.AddJsonStream(x)
			.Build();
		BindAndCheck(config);
	}

	[Benchmark]
	public void InMemory()
	{
		var config = new ConfigurationBuilder()
			.AddInMemoryCollection(ConfigDefaults.Defaults)
			.Build();
		BindAndCheck(config);
	}

	[Benchmark]
	public void EnvVars()
	{
		var config = new ConfigurationBuilder()
			.AddEnvironmentVariables()
			.Build();
		BindAndCheck(config);
	}

	private static void BindAndCheck(IConfiguration config)
	{
		var outer = config.GetSection("OuterSection").Get<OuterSection>();
		Debug.Assert(outer?.InnerSection?.Key == 1);
	}
}

class OuterSection
{
	public InnerSection InnerSection { get; set; } = null!;
}

class InnerSection
{
	public int Key { get; set; }
}