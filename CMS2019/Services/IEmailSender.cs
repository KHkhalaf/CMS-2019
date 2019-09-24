using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS2019.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendEmailAsync(string v1, string v2);
    }
}
