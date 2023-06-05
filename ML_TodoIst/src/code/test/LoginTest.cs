using OpenQA.Selenium;
using ML_TodoIst.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;

namespace ML_TodoIst.src.code.test
{
    [TestClass]
    public class LoginTest : TestBase
    {
        Home home = new Home();
        Login login = new Login();
        MainPage mainPage = new MainPage();
        Add add = new Add();
        Edit edit = new Edit();

        [TestMethod]
        public void VerifyTheLoginIsSuccessfuly2()
        {
            home.inisesion.Click();
            
            login.email.SetText("mloza693@gmail.com");
            login.password.SetText("LEnovo2023-+");
            login.iniciar.Click();
            mainPage.addproy.Click();
            Thread.Sleep(1000);
            add.name.SetText("miguel");
            Thread.Sleep(1000);
            add.anadir.Click();
            Thread.Sleep(1000);
            //verification creacion proyecto
            Assert.IsTrue(mainPage.ProjectNameIsDisplayed("miguel"), "ERROR!The project was not created");
            Thread.Sleep(1000);
            mainPage.masaccionesproy.Click();
            Thread.Sleep(1000);
            mainPage.editproy.Click();
            Thread.Sleep(1000);
            edit.nameedit.SetText("migueleditado");
            Thread.Sleep(1000);
            edit.guardar.Click();
            Thread.Sleep(1000);
            //verification edicion proyecto
            Assert.IsTrue(mainPage.ProjectNameIsEdited("migueleditado"), "ERROR!The project was not edited");
            Thread.Sleep(1000);
            mainPage.selecproy.Click();
            Thread.Sleep(1000);
            mainPage.opcionesproy.Click();
            Thread.Sleep(1000);
            mainPage.elimproy.Click();
            Thread.Sleep(1000);
            //session.Session.Instance().GetBrowser().SwitchTo().ActiveElement(); 
            mainPage.eliminar.Click();
            Thread.Sleep(1000);
            //verification eliminacion proyecto
            Assert.IsFalse(mainPage.ProjectNameIsDisplayed("miguel"), "ERROR!The project was not deleted");
            Thread.Sleep(1000);

        }

    }
}
