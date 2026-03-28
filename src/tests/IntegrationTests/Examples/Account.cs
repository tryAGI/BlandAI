/*
order: 30
title: Account
slug: account

Retrieve account details and billing information.
*/

namespace BlandAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetAccountDetails()
    {
        using var client = GetAuthenticatedClient();

        //// Retrieve your Bland AI account details including status,
        //// billing information, and total call count.
        var account = await client.Account.GetAccountDetailsAsync();

        account.Should().NotBeNull();
        account.Status.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Account status: {account.Status}");
        Console.WriteLine($"Total calls: {account.TotalCalls}");

        if (account.Billing is not null)
        {
            Console.WriteLine($"Billing info available: yes");
        }
    }
}
