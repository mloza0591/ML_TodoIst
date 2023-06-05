using OpenQA.Selenium;
using ML_TodoIst.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_TodoIst.src.code.page
{
    public class Home
    {

        public Button inisesion = new Button(By.XPath("//li/a[@href='/auth/login']"));

    }
}
