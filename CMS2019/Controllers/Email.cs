﻿using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CMS2019.Controllers
{
    public class Email : Controller
    {

        public string Index()

        {
            string htmlContent = "Hi";
            var apiKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("xxxxxxxx@gmail.com", "Support");
            var to = new EmailAddress("sender@gmail.com");
            var plainTextContent = Regex.Replace(htmlContent, "<[^>]*>", "");
            var msg = MailHelper.CreateSingleEmail(from, to, "Hi", plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);

            return "Email Sent";
        }
    }
}
