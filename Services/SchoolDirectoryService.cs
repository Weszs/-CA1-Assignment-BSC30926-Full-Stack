using System.Net.Http.Json;
using EdutotsSchools.Models;

namespace EdutotsSchools.Services;

public sealed class SchoolDirectoryService(HttpClient httpClient)
{
    public async Task<IReadOnlyList<School>> GetSchoolsAsync(CancellationToken cancellationToken = default)
    {
        var schools = await httpClient.GetFromJsonAsync<List<School>>(string.Empty, cancellationToken);
        return schools ?? [];
    }
}