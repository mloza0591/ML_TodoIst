﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_TodoIst.src.code.control
{
    public class Button : ControlSelenium
    {
        public Button(By locator) : base(locator)
        {
        }
    }
}
