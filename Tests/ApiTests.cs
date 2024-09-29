using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.Playwright.NUnit;

namespace Task2.Tests;

[Parallelizable(ParallelScope.All)]
[TestFixture]
public class ApiTests : PageTest
{
    [Test]
    public async Task RegisterAUser()
    {
        //Arrange

        // All requests sent start with this API endpoint.
        var baseURL = await Playwright.APIRequest.NewContextAsync(new() { BaseURL = "https://reqres.in/api/" });

        // This is the request to GET user number 1
        var request = await baseURL.PostAsync("register", new()
        {
            DataObject = new
            {
                email = "eve.holt@reqres.in",
                password = "pistol"
            }
        });

        var response = request.JsonAsync().Result.Value;
        var response2 = request.JsonAsync().Result.GetValueOrDefault();

        //Assert

        //I decided to use FluentAssertions for these tests, to show C# versistilty
        using (new AssertionScope())
        {
            request.Status.Should().Be(200);

            response.Should().NotBeNull();
            response.Should().Be("{\"id\":4,\"token\":\"QpwL5tke4Pnpja7X4\"}");
        }
    }

    [Test]
    public async Task GetaUser()
    {
        //Arrange

        // All requests sent start with this API endpoint.
        var baseURL = await Playwright.APIRequest.NewContextAsync(new() { BaseURL = "https://reqres.in/api/" });

        // This is the request to GET user number 1
        var request = await baseURL.GetAsync("users/1");

        var response = request.JsonAsync().Result;

        //Assert
    }

    [Test]
    public async Task DeleteAUser()
    {
        //Arrange

        // All requests sent start with this API endpoint.
        var baseURL = await Playwright.APIRequest.NewContextAsync(new() { BaseURL = "https://reqres.in/api/" });

        // This is the request to GET user number 1
        var request = await baseURL.DeleteAsync("users/2");

        var response = request.Status;
        var response2 = request.StatusText;

        //Assert
    }
}