using OpenQA.Selenium;
using System.Collections.Generic;


namespace WebParamTests.Websites
{
    public class RegistrationPage : Website
    {
        public override IWebDriver Driver { get; internal set; }

        public override IWebElement AcceptAllCoockies
        {
            get
            {
                return Driver.FindElement(AcceptAllCoockiesId);
            }
        }

        public override By AcceptAllCoockiesId
        {
            get
            {
                return By.XPath(@"//*[@id=""coiPage-1""]/div[2]/div[1]/button[3]");
            }
        }
       

        public static By ByLoanFornavn => By.XPath(@"//*[@id=""__next""]/div/div/div[2]/div/div/div/div[2]/div/form/div[3]/div[1]/div/div/div/div/div/div/input");
        public IWebElement LoanFornavn => Driver.FindElement(ByLoanFornavn);
        public static By ByLoanSurnavn => By.XPath(@"//*[@id=""__next""]/div[1]/div/div[2]/div/div/div/div[2]/div/form/div[3]/div[2]/div/div/div/div/div/div/input");
        public IWebElement LoanSurnavn => Driver.FindElement(ByLoanSurnavn);
        public static By ByLoanNumber => By.XPath(@"//*[@id=""__next""]/div[1]/div/div[2]/div/div/div/div[2]/div/form/div[3]/div[3]/div/div/div/div/div/div/input");
        public IWebElement LoanNumber => Driver.FindElement(ByLoanNumber);
        public static By ByLoanEmail => By.XPath(@"//*[@id=""__next""]/div[1]/div/div[2]/div/div/div/div[2]/div/form/div[3]/div[4]/div/div/div/div/div/div/input");
        public IWebElement LoanEmail => Driver.FindElement(ByLoanEmail);
        public static By ByLoanAdd => By.XPath(@"//*[@id=""__next""]/div[1]/div/div[2]/div/div/div/div[2]/div/form/div[3]/div[5]/div/div/div/div/div/div/input");
        public IWebElement LoanAdd => Driver.FindElement(ByLoanAdd);

        public static By ByName => By.XPath(@"//*[@id=""name""]");
        public IWebElement Name => Driver.FindElement(ByName);
        public static By BySurname => By.XPath(@"//*[@id=""surname""]");
        public IWebElement Surname => Driver.FindElement(BySurname);
        public static By ByPhone => By.XPath(@"//*[@id=""phone""]");
        public IWebElement Phone => Driver.FindElement(ByPhone);
        public static By ByEmail => By.XPath(@"//*[@id=""email""]");
        public IWebElement Email => Driver.FindElement(ByEmail);
                                               
        public static By BySearch => By.XPath(@"//*[@id=""appendedInputButtons""]");
        public IWebElement Search => Driver.FindElement(BySearch);
                                                        
        public static By BySearchbutton => By.XPath(@" //*[@id=""search""]/form/div/button");
        public IWebElement Searchbutton => Driver.FindElement(BySearchbutton);

        public static By ByChooseVinyl => By.XPath(@"//*[@id=""search""]/form/div/div/ul/li[4]/a");
        public IWebElement ChooseVinyl => Driver.FindElement(ByChooseVinyl);

        public static By ByChooseFormat => By.XPath(@"//*[@id=""search""]/form/div/div/button");
        public IWebElement ChooseFormat => Driver.FindElement(ByChooseFormat);
        

        public RegistrationPage(IWebDriver driver)
        {
            Driver = driver;
        }


    }
}
