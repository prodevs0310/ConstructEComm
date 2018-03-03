﻿
namespace ConstructEComm.Core.Extensions
{
    public static class CommonExtensions
    {
        public static bool IsNullOrDefault<T>(this T? value) where T : struct
        {
            return default(T).Equals(value.GetValueOrDefault());
        }
    }
}
