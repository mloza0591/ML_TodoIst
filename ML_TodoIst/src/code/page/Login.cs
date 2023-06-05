using OpenQA.Selenium;
using ML_TodoIst.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_TodoIst.src.code.page
{
    public class Login
    {

        public TextBox email = new TextBox(By.XPath("//input[@type='email']"));
        public TextBox password = new TextBox(By.XPath("//input[@type='password']"));
        public Button iniciar = new Button(By.XPath("//button[@data-gtm-id='start-email-login']"));

    }
}
