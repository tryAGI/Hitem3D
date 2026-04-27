namespace Hitem3D.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static Hitem3DClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HITEM3D_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("HITEM3D_API_KEY environment variable is not found.");

        var client = new Hitem3DClient(apiKey);
        
        return client;
    }
}
