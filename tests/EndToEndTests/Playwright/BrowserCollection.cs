using Xunit;

namespace Microsoft.eShopWeb.EndToEndTests.Playwright;

/// <summary>
/// One browser and one web app process per test run. Every Playwright test class
/// joins this collection so the fixtures are shared instead of being created per
/// class, which would start several web apps on the same hard-coded port.
/// </summary>
[CollectionDefinition(Name)]
public sealed class BrowserCollection : ICollectionFixture<BrowserFixture>
{
    public const string Name = "Browser";
}
