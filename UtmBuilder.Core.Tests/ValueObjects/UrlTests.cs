using Utm.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests {

    private const string InvalidUrl = "URL inválida";
    private const string ValidUrl = "https://amazon.com.br";

    [TestMethod]
    [TestCategory("URL")]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShoulReturnExceptionWhenUrlIsInvalid() {
        new Url(InvalidUrl);
    }

    [TestMethod]
    [TestCategory("URL")]
    public void ShoulNotReturnExceptionWhenUrlIsValid() {
        new Url(ValidUrl);
        Assert.IsTrue(true);
    }
}
