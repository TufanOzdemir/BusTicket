namespace Tufan.Common.Const
{
    public class ConstVariables
    {
        public struct Logging
        {
            public const string ConfigPath = @"App_Config\nlog.config";
        }

        public struct Caching
        {
            public const string CommonCacheConfigurationKey = "CommonCache";
            public const string LongDurationMemoryConfigurationKey = "LongDurationCache";
            public const string SmallDurationCacheConfigurationKey = "SmallDurationCache";
        }
    }
}