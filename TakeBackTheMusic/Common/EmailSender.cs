using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TakeBackTheMusic
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Refer to https://docs.microsoft.com/en-us/dotnet/api/system.net.mail?view=netcore-2.2 for .Net.Mail namespace
            // Put message code here

            return Task.CompletedTask;
        }
    }
}
