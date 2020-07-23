using System.Text.Json.Serialization;

namespace BaGet.Protocol.Models
{
    /// <summary>
    /// A single package type from a <see cref="SearchResult"/>.
    /// 
    /// See https://docs.microsoft.com/en-us/nuget/api/search-query-service-resource#search-result
    /// </summary>
    public class SearchResultPackageType
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
