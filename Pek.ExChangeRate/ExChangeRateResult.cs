using System.Text.Json.Serialization;

namespace Pek.ExChangeRate;

public class ExChangeRateResult
{
    /// <summary>
    /// 成功为success
    /// </summary>
    [JsonPropertyName("result")]
    public String? Result { get; set; }

    /// <summary>
    /// 获取或设置文档链接。
    /// </summary>
    [JsonPropertyName("documentation")]
    public String? Documentation { get; set; }

    /// <summary>
    /// 获取或设置使用条款链接。
    /// </summary>
    [JsonPropertyName("terms_of_use")]
    public String? TermsOfUse { get; set; }

    /// <summary>
    /// 获取或设置上次更新时间的 Unix 时间戳。
    /// </summary>
    [JsonPropertyName("time_last_update_unix")]
    public Int64 TimeLastUpdateUnix { get; set; }

    /// <summary>
    /// 获取或设置上次更新时间的 UTC 时间。
    /// </summary>
    [JsonPropertyName("time_last_update_utc")]
    public String? TimeLastUpdateUtc { get; set; }

    /// <summary>
    /// 获取或设置下次更新时间的 Unix 时间戳
    /// </summary>
    [JsonPropertyName("time_next_update_unix")]
    public Int64 TimeNextUpdateUnix { get; set; }

    /// <summary>
    /// 获取或设置下次更新时间的 UTC 时间
    /// </summary>
    [JsonPropertyName("time_next_update_utc")]
    public String? TimeNextUpdateUtc { get; set; }

    /// <summary>
    /// 获取或设置基础货币代码
    /// </summary>
    [JsonPropertyName("base_code")]
    public String? BaseCode { get; set; }

    /// <summary>
    /// 获取或设置货币转换率的字典。
    /// 键为货币代码，值为对应的转换率。
    /// </summary>
    [JsonPropertyName("conversion_rates")]
    public IDictionary<String, Decimal>? ConversionRates { get; set; }
}
