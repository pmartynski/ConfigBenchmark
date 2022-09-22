using System.Text;

namespace ConfigBenchmark;

public static class ConfigDefaults
{
	public static readonly IDictionary<string, string> Defaults;
	public static readonly byte[] JsonConfig;

	static ConfigDefaults()
	{
		Defaults = new Dictionary<string, string>
		{
			["OuterSection:InnerSection:Key"] = "1"
		};

		JsonConfig = Encoding.UTF8.GetBytes(
@"{
  ""OuterSection"": 
  {
  	""InnerSection"": 
	{
		""Key"": 1
	}
  }
}");
	}
}