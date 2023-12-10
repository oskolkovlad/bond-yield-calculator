namespace BondYieldCalculator.Parser
{
    using BondYieldCalculator.Entities;
    using HtmlAgilityPack;

    internal abstract class HtmlBondParser
    {
        #region Protected Members

        protected abstract BondInfo? GetBondInfo(HtmlDocument document);

        protected async Task<BondInfo?> ParseAsync(string? url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return null;
            }

            var htmlContent = await GetHtmlContentAsync(url).ConfigureAwait(false);
            if (string.IsNullOrEmpty(htmlContent))
            {
                return null;
            }

            var document = new HtmlDocument();

            try
            {
                document.LoadHtml(htmlContent);

                var boundInfo = GetBondInfo(document);
                if (boundInfo is not null)
                {
                    boundInfo.Link = url;
                }

                return boundInfo;
            }
            catch (Exception)
            {
                // TODO: log errors.
            }

            return null;
        }

        #endregion Protected Members

        #region Private Members

        private static async Task<string?> GetHtmlContentAsync(string url)
        {
            try
            {
                using var handler = new HttpClientHandler();
                using var httpClient = new HttpClient(handler);
                using var response = await httpClient.GetAsync(url).ConfigureAwait(false);
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        return null;
                    }

                    var htmlContent = await response.Content.ReadAsStringAsync();
                    return htmlContent;
                }
            }
            catch (Exception exception)
            {
                // TODO: log errors.
            }

            return null;
        }

        #endregion Private Members
    }
}
