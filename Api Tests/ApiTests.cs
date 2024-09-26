using Microsoft.Playwright.NUnit;
using NUnit.Framework.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PlaywrightApiTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ApiTests : PageTest
{

    //public async void Login()
    //{

    //}

    //[Test]
    //public async Task ValidLogin()
    //{
    //    //Arrange
    //    Login();

    //    //Assert
    //    await Expect(Page).ToHaveURLAsync("https://www.saucedemo.com/inventory.html");
    //    await Expect(Page).ToHaveTitleAsync("Swag Labs");

    //    await Expect(Page.Locator("[data-test=\"title\"]")).ToHaveTextAsync("Products");
    //    await Expect(Page.Locator("[data-test=\"inventory-item-description\"]")).ToHaveCountAsync(6);
    //    await Expect(Page.Locator("[data-test=\"inventory-item-name\"]")).ToContainTextAsync(new string[] { "Sauce Labs Backpack", "Sauce Labs Bike Light", "Sauce Labs Bolt T-Shirt", "Sauce Labs Fleece Jacket", "Sauce Labs Onesie", "Test.allTheThings() T-Shirt (Red)" });
    //    await Expect(Page.Locator("[data-test=\"inventory-item-desc\"]")).ToContainTextAsync(new string[] { "carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.", "A red light isn't the desired state in testing but it sure helps when riding your bike at night. Water-resistant with 3 lighting modes, 1 AAA battery included.", "Get your testing superhero on with the Sauce Labs bolt T-shirt. From American Apparel, 100% ringspun combed cotton, heather gray with red bolt.", "It's not every day that you come across a midweight quarter-zip fleece jacket capable of handling everything from a relaxing day outdoors to a busy day at the office.", "Rib snap infant onesie for the junior automation engineer in development. Reinforced 3-snap bottom closure, two-needle hemmed sleeved and bottom won't unravel.", "This classic Sauce Labs t-shirt is perfect to wear when cozying up to your keyboard to automate a few tests. Super-soft and comfy ringspun combed cotton." });
    //    await Expect(Page.Locator("[data-test=\"inventory-item-price\"]")).ToContainTextAsync(new string[] { "$29.99", "$9.99", "$15.99", "$49.99", "7.99", "$15.99" });
    //}
}