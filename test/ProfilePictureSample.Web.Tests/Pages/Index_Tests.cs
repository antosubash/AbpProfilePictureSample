using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ProfilePictureSample.Pages
{
    public class Index_Tests : ProfilePictureSampleWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
