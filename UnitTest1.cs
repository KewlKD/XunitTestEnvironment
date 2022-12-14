using Npgsql;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebParamTests.Websites;


namespace WebParamTests
{
    public class ParameterTest
    {
        String fornavn = "Kyle";
        String surnavn = "Dudley";
        String phoneNum = "71828537";
        String email = "kb@gmail.com";
        String address = "12 D Street";
        
        [Fact]
        public void LoanApplication()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
           
            driver.Navigate().GoToUrl(Configuration.loanPage);
            driver.Manage().Window.Maximize();

            var registrationPage = new RegistrationPage(driver);

            registrationPage.LoanFornavn.SendKeys(fornavn);
            registrationPage.LoanSurnavn.SendKeys(surnavn);
            registrationPage.LoanNumber.SendKeys(phoneNum);
            registrationPage.LoanEmail.SendKeys(email);
            registrationPage.LoanAdd.SendKeys(address);
        }

        public static IEnumerable<object[]> PositiveUserRegistrationTestData()
        {
            var Name = new List<string>() { "Kyle" };
            var Surnavn = new List<string>() { "Dudley" };
            var PhoneNumber = new List<string>() { "4540567564" };
            var Email = new List<string>() { "kyle@ck.dk"};
            foreach (string name in Name)
            {
                foreach (string surname in Surnavn)
                {
                    foreach (string phoneNumber in PhoneNumber)
                    {
                        foreach (string email in Email)
                        {
                            yield return new object[] { name, surname, phoneNumber, email };
                        }
                    }
                }
            }
        }

        [Theory]
        [MemberData(nameof(PositiveUserRegistrationTestData))]
        public void PositiveUserRegistrationTest(string name, string surname, string phoneNumber, string email)
        {
            IWebDriver driver;
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(Configuration.regPage);
            driver.Manage().Window.Maximize();

            var registrationPage = new RegistrationPage(driver);
            // Act
            registrationPage.Name.SendKeys(name);
            registrationPage.Surname.SendKeys(surname);
            registrationPage.Phone.SendKeys(phoneNumber);
            registrationPage.Email.SendKeys(email);
        }

        [Fact]
        public void CheckIfStudentsWithDupicateIdNumbersExist()
        {
            var studentIds = new List<string>();
            using (var conn = new NpgsqlConnection(Configuration.DbConnString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM student GROUP BY studentid HAVING COUNT(*) > 2";
                var command = new NpgsqlCommand(query, conn);
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    long numberOfDuplicateStudents = dr.GetInt64(0);
                    //Assert
                    Assert.Equal(0, numberOfDuplicateStudents);
                }
            }
        }

        [Fact]
        public void TestThatIndicatesUnpaidSubscriberExists()
        {
            var studentIds = new List<string>();
            using (var conn = new NpgsqlConnection(Configuration.DbConnStringSub))
            {
                conn.Open();
                string query = @"SELECT customerfirstname,customerlastname FROM customers WHERE subscriptionpaid = FALSE";
                var command = new NpgsqlCommand(query, conn);
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                   string subscribersThatHaveNotPaid = dr.GetString(0);
                   bool allsubscriberspaid = true;
                   string subscribersThatHavePaid = allsubscriberspaid.ToString();
                   //Assert
                   Assert.False(subscribersThatHaveNotPaid.Equals(subscribersThatHavePaid));
                    
                }
            }
        }

        [Fact]
        public void TestThatVerifiesAllCustomersAreOver15()
        {
            var studentIds = new List<string>();
            using (var conn = new NpgsqlConnection(Configuration.DbConnStringSub))
            {
                conn.Open();
                string query = @"SELECT COUNT(*)FROM customers WHERE age < 15";
                var command = new NpgsqlCommand(query, conn);
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    int subscribersUnder15 = dr.GetInt32(0);
                    //Assert
                    Assert.Equal(0, subscribersUnder15);

                }
            }
        }
           
        }
       

    }
