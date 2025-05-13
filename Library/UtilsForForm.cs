using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class UtilsForForm
    {
        public static void LogOutOfAccount(Form form)
        {
            form.Close();
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.Show();
        }
    }
}
