using System;

public static partial class Extensions
{
    /// <summary>
    /// 因为数据库不允许为空，则会自动赋默认值1751或1905
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    public static bool IsNull(this DateTime @this)
    {
        return @this == null || @this.Year <= 1905;
    }
}
