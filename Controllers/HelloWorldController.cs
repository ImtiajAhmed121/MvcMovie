﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name = "Imt, int numTimes = 4 )
        {
            return HtmlEncoder.Default.Encode($"Hello  {name},numTime is: {numTimes} ");
        }
    }
}