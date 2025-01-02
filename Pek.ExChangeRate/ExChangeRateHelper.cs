using NewLife;

using Pek.Webs.Clients;

namespace Pek.ExChangeRate;

public class ExChangeRateHelper
{
    /// <summary>
    /// 获取结果
    /// </summary>
    /// <returns></returns>
    public static async Task<ExChangeRateResult> GetResult(String Code = "USD")
    {
        if (ExChangeRateSettings.Current.APIKey.IsNullOrWhiteSpace()) throw new ArgumentNullException(nameof(ExChangeRateSettings.Current.APIKey));

        var client = new WebClient<ExChangeRateResult>();

        var result = await client.Get($"https://v6.exchangerate-api.com/v6/{ExChangeRateSettings.Current.APIKey}/latest/{Code}")
            .Timeout(60000)
            .IgnoreSsl()
            .Retry(3)
            .WhenCatch<Exception>(ex =>
            {
                return ReturnAsDefautlResponse(ex.Message);
            })
            .ResultFromJsonAsync().ConfigureAwait(false);

        return result;
    }

    private static ExChangeRateResult ReturnAsDefautlResponse(String Message)
            => new()
            {
                Result = "error",
            };
}
