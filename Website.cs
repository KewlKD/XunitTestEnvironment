using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;


namespace WebParamTests
{
    public abstract class Website
    {
      
        public abstract By AcceptAllCoockiesId { get; }
        public abstract IWebElement AcceptAllCoockies { get; }
        public abstract IWebDriver Driver { get; internal set; }
        public virtual IWebElement Body

        {
            get
            {
                return Driver.FindElement(By.TagName("body"));
            }
        }

        }
    }


