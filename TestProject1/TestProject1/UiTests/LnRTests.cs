using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.Actions;
namespace ThreeNineTests.UiTests
{
    internal class LnRTests:CoreTest
    {

        [Test]
        public void Login() {
            var driver = Open999();
            var user = GetUser(true);
            var topBarPanel = LogRegActions.Login(driver, user);

            Assert.IsTrue(topBarPanel.userNameButton.Displayed);
        }

    }
}

