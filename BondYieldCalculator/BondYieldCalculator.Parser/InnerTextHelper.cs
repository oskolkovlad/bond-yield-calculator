namespace BondYieldCalculator.Parser
{
    using System.Globalization;

    internal static class InnerTextHelper
    {
        public static decimal ParseInnerText(this string value) => decimal.Parse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

        public static string? TrimInnerText(this string text) => text?.Trim('\n', '\t', '\r', ' ');

        public static string? TrimInnerTextWithPercent(this string text) => text?.Trim('\n', '\t', '\r', ' ', '%');

        public static string? TrimInnerTextWithRemoveWord(this string text, string word) => text?.Replace(word, "")?.Trim('\n', '\t', '\r', ' ');
    }
}
