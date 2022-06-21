using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace RHerber.Common.Utilities
{
    public static class UtilityFunctions
    {
        public static string GetSourceName(
            [CallerFilePath]
            string sourceFilePath = "",
            [CallerMemberName]
            string memberName = "")
        {
            var sourceName = string.Empty;
            if (!string.IsNullOrWhiteSpace(sourceFilePath))
            {
                sourceName = sourceFilePath.Contains('\\')
                    ? sourceFilePath.Split('\\').Last().Split('.').First()
                    : sourceFilePath.Split('/').Last().Split('.').First();
            }

            return $"{sourceName}.{memberName}";
        }

        public static string GetControllerName<T>()
        {
            var typeName = typeof(T).Name;
            var splitOn = "Controller";

            if (typeName == null || !typeName.EndsWith(splitOn, StringComparison.Ordinal))
            {
                throw new ArgumentException($"Controllers must end with 'Controller'. {typeName} does not.", nameof(T));
            }

            return typeName.Split(splitOn).First();
        }
    }
}