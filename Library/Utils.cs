using Library.Data;
using System.Data;

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

        public static string NormalizeField(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim().ToLower();
        }

        public static string NormalizeDateField(DateTimePicker picker, string format = "dd.MM.yyyy")
        {
            return picker.Checked ? picker.Value.ToString(format) : string.Empty;
        }

        public static bool MatchesAnyCriteria(DataRow row, Dictionary<string, string> criteria)
        {
            foreach (var criterion in criteria)
            {
                if (!string.IsNullOrEmpty(criterion.Value))
                {
                    string rowValue = NormalizeField(row.Field<string>(criterion.Key));
                    if (rowValue.Contains(criterion.Value))
                    {
                        return true;
                    }
                }
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
                    DateTimePicker? picker = (DateTimePicker)control;
                    picker.Value = DateTime.Now;
                    picker.Checked = false;
                }

                else if (control.HasChildren)
                    ClearAllControls(control);
            }
        }
    }
}
