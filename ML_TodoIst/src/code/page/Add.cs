using OpenQA.Selenium;
using ML_TodoIst.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_TodoIst.src.code.page
{
    public class Add
    {
        public TextBox name = new TextBox(By.Id("edit_project_modal_field_name"));

        //public Button anadir = new Button(By.XPath("//button/span[text()='Añadir']"));
        public Button anadir = new Button(By.XPath("//button[@type='submit']"));

    }
}
