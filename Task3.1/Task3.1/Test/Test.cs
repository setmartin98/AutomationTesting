using NUnit.Framework;
using Task3._1.Main;
using Task3._1.Test.PO;
using Task3._1.Utilities;
using Task3._1.Utilities.FilesUtils;
namespace Task3._1.Test;

public class Tests : BaseTest
{
    [SetUp]
    public void Setup()
    {
        beforeStartTest();
    }

    [Test]
    public void TestScenario1()
    {
        var mainPage = new MainPage();
        Assert.IsTrue(mainPage.isMainPageOpen(), "Main Page is not open");
        BrowserUtilies.ScrollMid();
        mainPage.ClickAlertsFWButton();
        var alertsPage = new AlertsPage();
        Assert.IsTrue(alertsPage.isAlertsPageOpen(), "Alerts, Frame and Windows Page is not open");
        BrowserUtilies.ScrollMid();
        alertsPage.ClickAlertsMenuButton();
        BrowserUtilies.ScrollUp();
        Assert.IsTrue(alertsPage.isAlertsFormDisplayed(), "Alerts Form not displayed");
        alertsPage.ClickAlertButton();
        Assert.That(alertsPage.GetAlertBoxTest(), Is.EqualTo(jsonReader.getTestDataValue("alertBox")),
            "Alert is not displayed or is not showing the expected text");
        alertsPage.ClickAlertBoxOk();
        BrowserUtilies.switchToCurrentPage();
        Assert.IsFalse(alertsPage.isAlertBoxDisplayed(), "Alert Box is still open");
        alertsPage.ClickConfirmButton();
        Assert.That(alertsPage.GetConfirmAlertText(), Is.EqualTo(jsonReader.getTestDataValue("confirmAlertBox")), 
            "Alert is not displayed or is not showing the expected text");
        alertsPage.ClickConfirmAlertOk();
        Assert.IsFalse(alertsPage.isConfirmAlertDisplayed(), "Alert Box is still open");
        Assert.That(alertsPage.GetConfirmResultText, Is.EqualTo(jsonReader.getTestDataValue("confirmResult")), 
            "Text result is not displayed or is not equal to expected");
        alertsPage.ClickPromtButton();
        Assert.That(alertsPage.GetPromtAlertBoxText, Is.EqualTo(jsonReader.getTestDataValue("promtAlertBox")),
            "Alert is not displayed or not showing the expected text");
        alertsPage.TypeInPromtAlertBox();
        alertsPage.ClickPromtAlertOk();
        Assert.IsFalse(alertsPage.isPromtAlertDisplayed(),"Alert Box is still open");
        StringAssert.Contains(alertsPage.GetRandomText(), alertsPage.GetPromtResultText());
        Assert.Pass();
        
    }
    
    [Test]
    public void TestScenario2()
    {
        var mainPage = new MainPage();
        Assert.IsTrue(mainPage.isMainPageOpen(), "Main Page is not open");
        BrowserUtilies.ScrollMid();
        mainPage.ClickAlertsFWButton();
        var alertsPage = new AlertsPage();
        BrowserUtilies.ScrollDown();
        alertsPage.ClickNestedFramesButton();
        var nestedPage = new NestedFPage();
        Assert.IsTrue(nestedPage.isNestedPageOpen());
        BrowserUtilies.ScrollMid();
        BrowserUtilies.swithToFrame(nestedPage.GetParentID());
        Assert.That(nestedPage.GetParentLabelText, Is.EqualTo(jsonReader.getTestDataValue("parentLabel")),
            "Expected text and showed are not equals");
        BrowserUtilies.swithToFrameByWebElement(nestedPage.GetChildFrame());
        Assert.That(nestedPage.GetChildLabelText(), Is.EqualTo(jsonReader.getTestDataValue("childLabel")),
            "Expected text and showed are not equals");
        BrowserUtilies.switchToCurrentPage();
        BrowserUtilies.ScrollMid();
        nestedPage.ClickFrameButton();
        BrowserUtilies.ScrollUp();
        FramesPage framesPage = new FramesPage();
        Assert.IsTrue(framesPage.isFramesPageOpen(), "Frames Page is not open");
        BrowserUtilies.ScrollMid();
        Assert.That(framesPage.getFrame1Text(), Is.EqualTo(framesPage.getFrame2Text()));

    }

    [Test]
    public void TestScenario3()
    {
        var mainPage = new MainPage();
        Assert.IsTrue(mainPage.isMainPageOpen(), "Main Page is not open");
        BrowserUtilies.ScrollDown();
        mainPage.ClickElementsButton();
        var elementsPage = new ElementsPage();
        elementsPage.ClickWebTables();
        Assert.IsTrue(elementsPage.isWebTableFormOpen(), "Web Tables Form in Elements Page not visible");
        elementsPage.ClickAddButton();
        Assert.IsTrue(elementsPage.isRegistFormOpen(), "Registration Form not visible");
        elementsPage.introduceTestData(0);
        elementsPage.ClickSubmitButton();
        elementsPage.ClickAddButton();
        elementsPage.introduceTestData(1);
        elementsPage.ClickSubmitButton();
        BrowserUtilies.ScrollDown();
        Assert.IsFalse(elementsPage.isRegistFormStillOpen(), "Registration Form still visible");
        BrowserUtilies.ScrollMid();
        Assert.That(elementsPage.getFirstRowData(), Is.EqualTo(jsonReader.getUserData(0)),
            "Expected user data and actual user data are not equals");
        elementsPage.ClickDeleteButton();
        Assert.That(elementsPage.getFirstRowData(), Is.Not.EqualTo(jsonReader.getUserData(0)), "User has not been deleted");
    }
    
    [Test]
    public void TestScenario4()
    {
        var mainPage = new MainPage();
        Assert.IsTrue(mainPage.isMainPageOpen(), "Main Page is not open");
        BrowserUtilies.ScrollDown();
        mainPage.ClickAlertsFWButton();
        var alertsPage = new AlertsPage();
        BrowserUtilies.ScrollMid();
        alertsPage.ClickBrowserWindowButton();
        BrowserUtilies.ScrollUp();
        var browserWPage = new BrowserWindowsPage();
        Assert.IsTrue(browserWPage.isBrowserWindowPageOpen(), "Browser Form is not open");
        browserWPage.ClickNewTabButton();
        BrowserUtilies.switchToTab(1);
        Assert.IsTrue(browserWPage.isNewTabOpen(), "New tab is not opened");
        BrowserUtilies.closeCurrentTab();
        BrowserUtilies.switchToTab(0);
        Assert.IsTrue(browserWPage.isBrowserWindowPageOpen(), "Browser Form is not open");
        var linksPage = new LinksPage();
        linksPage.ClickElementsButton();
        BrowserUtilies.ScrollMid();
        linksPage.ClickLinksMenuButton();
        Assert.IsTrue(linksPage.isLinksPageOpen(), "Links Form is not open");    
        linksPage.ClickHomeButton();
        BrowserUtilies.switchToTab(1);
        Assert.IsTrue(mainPage.isMainPageOpen(),"Main Page by clickling Home button not opened");
        BrowserUtilies.switchToTab(0);
        Assert.IsTrue(linksPage.isLinksPageOpen(), "Links Form is not open");
        Logg.infoMessage("Finished");
    }
    
    [OneTimeTearDown]
    public void TearDown()
    {
        afterFinishingTest();
    }
}