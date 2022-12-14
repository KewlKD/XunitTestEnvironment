using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebParamTests
{
    
    public class Configuration
    {
        
        public static string loanPage  = "";
        public static string regPage = "https://auth.webrick.dk/UserRegistration/RegisterUser?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dwebrick-pkce-client%26redirect_uri%3Dhttps%253A%252F%252Fwebrick.dk%252Foidc-handler%252Fsignin%26response_type%3Dcode%26scope%3Dopenid%2520profile%2520webrick_api%26state%3D15ee9765477846298c0f5ddc312b6b52%26code_challenge%3DF3erOD1d7ligV9O14rJRu9yanE-EVo7N_ZaK_rPMgRM%26code_challenge_method%3DS256%26response_mode%3Dquery/";
        public static string DbConnString = "Host=localhost;Username=postgres;Password=;Database=testdb";
        public static string DbConnStringSub = "Host=localhost;Username=postgres;Password=;Database=Subscribers";
        public static string url = "";

    }
}
