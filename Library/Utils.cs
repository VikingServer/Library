using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Utils
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

    public static class ControlExtensions
    {
        public static void ClearAllControls(this Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is DateTimePicker)
                {
                    var picker = (DateTimePicker)control;
                    picker.Value = DateTime.Now;
                    picker.Checked = false;
                }

                else if (control.HasChildren)
                    ClearAllControls(control);
            }
        }
    }
}
