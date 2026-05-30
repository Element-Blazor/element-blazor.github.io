using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Element.ClientRender.Model
{
    public sealed class NuGetPackageStatus
    {
        private const string RegistrationUrl = "https://api.nuget.org/v3/registration5-semver1/element/index.json";

        public string Version { get; private set; } = "2.14.0-alpha.1";

        public long Downloads { get; private set; }

        public string PackageUrl { get; private set; } = "https://www.nuget.org/packages/Element/";

        public string DownloadsText => Downloads <= 0 ? "统计中" : Downloads.ToString("N0");

        public static async Task<NuGetPackageStatus> LoadAsync(HttpClient httpClient, CancellationToken cancellationToken = default)
        {
            var status = new NuGetPackageStatus();

            try
            {
                var registration = await httpClient.GetFromJsonAsync<NuGetRegistration>(RegistrationUrl, cancellationToken);
                var latest = registration?.Items?
                    .SelectMany(page => page.Items ?? Array.Empty<NuGetRegistrationLeaf>())
                    .Where(item => item.CatalogEntry != null)
                    .OrderBy(item => item.CatalogEntry.Published)
                    .LastOrDefault();

                if (latest?.CatalogEntry == null)
                {
                    return status;
                }

                status.Version = latest.CatalogEntry.Version ?? status.Version;
                status.Downloads = latest.PackageContent?.Downloads ?? 0;
                status.PackageUrl = $"https://www.nuget.org/packages/Element/{status.Version}";
            }
            catch
            {
                return status;
            }

            return status;
        }

        private sealed class NuGetRegistration
        {
            [JsonPropertyName("items")]
            public NuGetRegistrationPage[] Items { get; set; }
        }

        private sealed class NuGetRegistrationPage
        {
            [JsonPropertyName("items")]
            public NuGetRegistrationLeaf[] Items { get; set; }
        }

        private sealed class NuGetRegistrationLeaf
        {
            [JsonPropertyName("catalogEntry")]
            public NuGetCatalogEntry CatalogEntry { get; set; }

            [JsonPropertyName("packageContent")]
            public NuGetPackageContent PackageContent { get; set; }
        }

        private sealed class NuGetCatalogEntry
        {
            [JsonPropertyName("version")]
            public string Version { get; set; }

            [JsonPropertyName("published")]
            public DateTimeOffset Published { get; set; }
        }

        private sealed class NuGetPackageContent
        {
            [JsonPropertyName("downloads")]
            public long Downloads { get; set; }
        }
    }
}
