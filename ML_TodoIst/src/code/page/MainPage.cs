using OpenQA.Selenium;
using ML_TodoIst.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace ML_TodoIst.src.code.page
{
    public  class MainPage
    {
        public Button addproy = new Button(By.XPath("//button[@aria-label='Añadir proyecto']"));
        public Button masaccionesproy = new Button(By.XPath("//div[a[contains(@aria-label,'miguel')]]/span/div/button[@type='button']"));
        public Button editproy = new Button(By.XPath("//div[text()='Editar proyecto']"));
        public Button selecproy = new Button(By.XPath("//div[a[contains(@aria-label,'miguel')]]"));
        public Button opcionesproy = new Button(By.XPath("//button[@aria-label='Menú de opciones del proyecto']"));
        public Button elimproy = new Button(By.XPath("//div[text()='Eliminar proyecto']"));
        public Button eliminar = new Button(By.XPath("//button[@type='submit']"));

        public Boolean ProjectNameIsDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("//div[a[contains(@aria-label,'"+nameValue+"')]]"));
            return nameProject.IsControlDisplayed();
        }

        public Boolean ProjectNameIsEdited(String nameValue)
        {
            Label nameProject = new Label(By.XPath("//div[a[contains(@aria-label,'" + nameValue + "')]]"));
            return nameProject.IsControlDisplayed();
        }

    }
}
