using System.Text.Json;

namespace Pek.ExChangeRate.Tests;

public class ExChangeRateResultTests {
    [Fact]
    public void Check()
    {
        var json = @"{
            ""result"": ""success"",
            ""documentation"": ""https://example.com/doc"",
            ""terms_of_use"": ""https://example.com/terms"",
            ""time_last_update_unix"": 1735776001,
            ""time_last_update_utc"": ""2024-01-01T00:00:01Z"",
            ""time_next_update_unix"": 1735862401,
            ""time_next_update_utc"": ""2024-01-02T00:00:01Z"",
            ""base_code"": ""USD"",
            ""conversion_rates"": {
                ""EUR"": 0.85,
                ""GBP"": 0.75
            }
        }";

        var result = JsonSerializer.Deserialize<ExChangeRateResult>(json);
        Assert.NotNull(result);
        Assert.Equal("success", result.Result);
        Assert.Equal("https://example.com/doc", result.Documentation);
        Assert.Equal("https://example.com/terms", result.TermsOfUse);
        Assert.Equal(1735776001, result.TimeLastUpdateUnix);
    }
}
