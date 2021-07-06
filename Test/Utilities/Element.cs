using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Test.Utilities
{
    class Element
    {

        //Trail and Treats
        public static By demoSelector = By.XPath("//*[@id=\"cgp_overlay2\"]/div/div/div[1]/div/nav/div[1]/div[2]/div/div[2]/div/ul/li[3]");
        public static By iframeSelector = By.XPath("//*[@id=\"cgp_overlay3\"]/div/div/div[2]/div/iframe");
        public static By gameCanvaSelector = By.XPath("//*[@id=\"gameCanvas\"]");
        public static By spinSelector = By.Id("spin_button");

        //LogIn
        public static By usernameSelector = By.Id("rlLoginUsername");
        public static By passwordSelector = By.Id("rlLoginPassword");
        public static By submitSelector = By.Id("rlLoginSubmit");
        public static By closePopUpSelector = By.ClassName("cy-modal-x-button");

        //Home 
        public static By userSelector = By.ClassName("profile-name");
        public static By searchGameSelector = By.ClassName("cy-game-search-input");
        public static By gameSearched = By.XPath("//*[@id=\"orbit-container\"]/div[5]/nav/div[1]/div[1]/div/div/span[1]/ul/li/a/span");

        public static By application = By.XPath("//nav[@class='md-nav']//a[contains(.,'Our Application')]");

    }
}
