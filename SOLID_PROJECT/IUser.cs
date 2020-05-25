using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PROJECT
{
    interface IUser
    {
        bool Login(string userName, string password);
        bool Register(string userName, string password, string emil);
    }

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
