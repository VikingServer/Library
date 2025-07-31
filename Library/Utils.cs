using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Utils
    {
        public static void LogOutOfAccount(Form form)
        {
            form.Close();
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.Show();
        }

        public static bool IsConnect()
        {
            if (DatabaseConnection.IsConnect())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к базе данных",
                                "Ошибка подключения",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
