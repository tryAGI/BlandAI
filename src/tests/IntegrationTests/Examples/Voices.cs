/*
order: 20
title: Voices
slug: voices

List available AI voices for phone calls.
*/

namespace BlandAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListVoices()
    {
        using var client = GetAuthenticatedClient();

        //// List all available AI voices that can be used for phone calls.
        //// Each voice includes metadata like name, description, tags, and ratings.
        var voices = await client.Voices.ListVoicesAsync();

        voices.Should().NotBeNull();
        voices.Should().NotBeEmpty();

        Console.WriteLine($"Available voices: {voices.Count}");

        foreach (var voice in voices)
        {
            Console.WriteLine($"  Voice: {voice.Name} (ID: {voice.Id})");
            if (voice.Description is not null)
            {
                Console.WriteLine($"    Description: {voice.Description}");
            }
        }
    }
}
