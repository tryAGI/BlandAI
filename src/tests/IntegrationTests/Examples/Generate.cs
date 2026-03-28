/*
order: 10
title: Calls
slug: calls

List and retrieve details of AI phone calls.
*/

namespace BlandAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListCalls()
    {
        using var client = GetAuthenticatedClient();

        //// List recent phone calls made through your Bland AI account.
        //// Supports filtering by phone number, date range, completion status, and more.
        var response = await client.Calls.ListCallsAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Calls.Should().NotBeNull();

        Console.WriteLine($"Total calls: {response.TotalCount}");
        Console.WriteLine($"Calls returned: {response.Count}");
    }

    [TestMethod]
    public async Task ListActiveCalls()
    {
        using var client = GetAuthenticatedClient();

        //// Retrieve all currently active (in-progress) calls.
        //// This is useful for monitoring ongoing call campaigns.
        var response = await client.Calls.ListActiveCallsAsync();

        response.Should().NotBeNull();

        Console.WriteLine($"Active calls response: {response}");
    }
}
