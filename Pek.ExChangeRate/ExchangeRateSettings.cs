using System.ComponentModel;

using NewLife.Configuration;

namespace Pek.ExChangeRate;

/// <summary>汇率设置</summary>
[DisplayName("汇率设置")]
[Config("ExChangeRate")]
public class ExChangeRateSettings : Config<ExChangeRateSettings>
{
    /// <summary>
    /// API访问密钥
    /// </summary>
    [Description("API访问密钥")]
    public String? APIKey { get; set; }
}
