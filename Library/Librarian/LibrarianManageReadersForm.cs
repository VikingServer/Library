using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibrarianManageReadersForm : Form
    {
        public Form Authorization;
        public LibrarianManageReadersForm()
        {
            InitializeComponent();
            Authorization = new AuthorizationForm();

            Utils.IsConnect();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianMenuForm menuLibrarian = new LibrarianMenuForm();
            menuLibrarian.Show();
        }

        private void btnBookOperations_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianBookManagmentForm bookManagmentForm = new LibrarianBookManagmentForm();
            bookManagmentForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Authorization.Show();
            Close();
        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            if (dataGridViewReaders.DataSource == null)
            {
                MessageBox.Show("Данные не загружены. Нажмите 'Обновить таблицу'.",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            SearhReader();
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            if (Utils.IsConnect())
                LoadReadersData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatronymic.Text) ||
                string.IsNullOrWhiteSpace(textBoxDocumentSeries.Text) ||
                string.IsNullOrWhiteSpace(textBoxDocumentNumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxIssuedBy.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Заполните все обязательные поля: Фамилия, Имя, Отчество, Серия, Номер, Кем выдан, Адрес регистрации",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            AddReader();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewReaders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите читателя для удаления.",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DeleteReader();
        }

        private void LoadReadersData()
        {
            try
            {
                string query = @"
                SELECT 
                    ч.idЧитателя AS ""idЧитателя"",
                    ф.Фамилия AS ""Фамилия"",
                    ф.Имя AS ""Имя"",
                    ф.Отчество AS ""Отчество"",
                    ч.НомерТелефона AS ""Номер телефона"",
                    пд.Серия AS ""Серия"",
                    пд.Номер AS ""Номер"",
                    пд.КемВыдан AS ""Кем выдан"",
                    TO_CHAR(пд.ДатаВыдачи, 'DD.MM.YYYY') AS ""Дата выдачи"",
                    пд.АдресРегистрации AS ""Адрес регистрации""
                FROM 
                    Читатели ч
                JOIN 
                    ФИОЧитатели ф ON ч.idЧитателя = ф.idЧитателя
                JOIN 
                    ПаспортныеДанныеЧитатели пд ON ч.idЧитателя = пд.idЧитателя
                ORDER BY 
                    ф.Фамилия, ф.Имя, ф.Отчество";

                DataTable readersData = DatabaseConnection.ExecuteQuery(query);

                if (readersData.Columns.Count == 0)
                {
                    MessageBox.Show("Запрос не вернул данных. Проверьте структуру таблиц 'Читатели', 'ФИОЧитатели' и 'ПаспортныеДанныеЧитатели'.",
                                    "Ошибка данных",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                dataGridViewReaders.DataSource = readersData;

                // Скрываем столбец idЧитателя в таблице
                dataGridViewReaders.Columns["idЧитателя"].Visible = false;

                dataGridViewReaders.Columns["LastName"].DataPropertyName = "Фамилия";
                dataGridViewReaders.Columns["FirstName"].DataPropertyName = "Имя";
                dataGridViewReaders.Columns["Patronymic"].DataPropertyName = "Отчество";
                dataGridViewReaders.Columns["Phone"].DataPropertyName = "Номер телефона";
                dataGridViewReaders.Columns["DocumentSeries"].DataPropertyName = "Серия";
                dataGridViewReaders.Columns["DocumentNumber"].DataPropertyName = "Номер";
                dataGridViewReaders.Columns["IssuedBy"].DataPropertyName = "Кем выдан";
                dataGridViewReaders.Columns["IssueDate"].DataPropertyName = "Дата выдачи";
                dataGridViewReaders.Columns["Address"].DataPropertyName = "Адрес регистрации";

                dataGridViewReaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewReaders.Columns["IssueDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных читателей: {ex.Message}\n" +
                                $"Позиция ошибки: {ex.ErrorCode}",
                                "Ошибка базы данных",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void AddReader()
        {
            try
            {
                using (var connection = new NpgsqlConnection(DatabaseConnection.СonnectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 1. Добавляем запись в таблицу Читатели (получаем новый idЧитателя)
                            string insertReaderQuery = @"
                                INSERT INTO Читатели (НомерТелефона)
                                VALUES (@Phone)
                                RETURNING idЧитателя;";

                            int readerId;
                            using (var command = new NpgsqlCommand(insertReaderQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(textBoxPhone.Text) ? DBNull.Value : textBoxPhone.Text);
                                readerId = Convert.ToInt32(command.ExecuteScalar());
                            }

                            // 2. Добавляем запись в таблицу ФИОЧитатели
                            string insertFIOQuery = @"
                                INSERT INTO ФИОЧитатели (idЧитателя, Фамилия, Имя, Отчество)
                                VALUES (@ReaderId, @LastName, @FirstName, @Patronymic);";

                            using (var command = new NpgsqlCommand(insertFIOQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ReaderId", readerId);
                                command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                                command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                                command.Parameters.AddWithValue("@Patronymic", textBoxPatronymic.Text);
                                command.ExecuteNonQuery();
                            }

                            // 3. Добавляем запись в таблицу ПаспортныеДанныеЧитатели
                            string insertPassportQuery = @"
                                INSERT INTO ПаспортныеДанныеЧитатели (idЧитателя, Серия, Номер, КемВыдан, ДатаВыдачи, АдресРегистрации)
                                VALUES (@ReaderId, @Series, @Number, @IssuedBy, @IssueDate, @Address);";

                            using (var command = new NpgsqlCommand(insertPassportQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ReaderId", readerId);
                                command.Parameters.AddWithValue("@Series", textBoxDocumentSeries.Text);
                                command.Parameters.AddWithValue("@Number", textBoxDocumentNumber.Text);
                                command.Parameters.AddWithValue("@IssuedBy", textBoxIssuedBy.Text);
                                command.Parameters.AddWithValue("@IssueDate", dateTimePicker1.Value);
                                command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                                command.ExecuteNonQuery();
                            }

                            // Фиксируем транзакцию
                            transaction.Commit();

                            MessageBox.Show("Читатель успешно добавлен!",
                                            "Успех",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            // Обновляем таблицу
                            LoadReadersData();

                            ClearFormFields();
                        }
                        catch (NpgsqlException ex) when (ex.SqlState == "23505")
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ошибка: читатель с таким id уже существует. Проверьте данные.",
                                            "Ошибка уникальности",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка при добавлении читателя: {ex.Message}",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxPatronymic.Clear();
            textBoxPhone.Clear();
            textBoxDocumentSeries.Clear();
            textBoxDocumentNumber.Clear();
            textBoxIssuedBy.Clear();
            textBoxAddress.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void DeleteReader()
        {
            int selectedRowIndex = dataGridViewReaders.SelectedRows[0].Index;
            int readerId = Convert.ToInt32(dataGridViewReaders.Rows[selectedRowIndex].Cells["idЧитателя"].Value);

            // Подтверждение удаления
            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить читателя с ID {readerId}?",
                                                  "Подтверждение удаления",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new NpgsqlConnection(DatabaseConnection.СonnectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 1. Удаляем из ФИОЧитатели
                            string deleteFIOQuery = @"
                            DELETE FROM ФИОЧитатели
                            WHERE idЧитателя = @ReaderId;";

                            using (var command = new NpgsqlCommand(deleteFIOQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ReaderId", readerId);
                                command.ExecuteNonQuery();
                            }

                            // 2. Удаляем из ПаспортныеДанныеЧитатели
                            string deletePassportQuery = @"
                            DELETE FROM ПаспортныеДанныеЧитатели
                            WHERE idЧитателя = @ReaderId;";

                            using (var command = new NpgsqlCommand(deletePassportQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ReaderId", readerId);
                                command.ExecuteNonQuery();
                            }

                            // 3. Удаляем из Читатели
                            string deleteReaderQuery = @"
                            DELETE FROM Читатели
                            WHERE idЧитателя = @ReaderId;";

                            using (var command = new NpgsqlCommand(deleteReaderQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ReaderId", readerId);
                                command.ExecuteNonQuery();
                            }

                            // Фиксируем транзакцию
                            transaction.Commit();

                            MessageBox.Show("Читатель успешно удален!",
                                            "Успех",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            // Обновляем таблицу
                            LoadReadersData();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка при удалении читателя: {ex.Message}",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void SearhReader()
        {
            DataTable dataTable = (DataTable)dataGridViewReaders.DataSource;
            string lastName = textBoxLastName.Text.Trim().ToLower();
            string firstName = textBoxFirstName.Text.Trim().ToLower();
            string patronymic = textBoxPatronymic.Text.Trim().ToLower();
            string phone = textBoxPhone.Text.Trim().ToLower();
            string series = textBoxDocumentSeries.Text.Trim().ToLower();
            string number = textBoxDocumentNumber.Text.Trim().ToLower();
            string issuedBy = textBoxIssuedBy.Text.Trim().ToLower();
            string address = textBoxAddress.Text.Trim().ToLower();
            string issueDate = dateTimePicker1.Checked ? dateTimePicker1.Value.ToString("dd.MM.yyyy").ToLower() : "";

            bool found = false;

            // Проходим по всем строкам таблицы
            foreach (DataGridViewRow row in dataGridViewReaders.Rows)
            {
                if (row.IsNewRow) continue; // Пропускаем новую строку

                string rowLastName = row.Cells["LastName"].Value?.ToString().Trim().ToLower() ?? "";
                string rowFirstName = row.Cells["FirstName"].Value?.ToString().Trim().ToLower() ?? "";
                string rowPatronymic = row.Cells["Patronymic"].Value?.ToString().Trim().ToLower() ?? "";
                string rowPhone = row.Cells["Phone"].Value?.ToString().Trim().ToLower() ?? "";
                string rowSeries = row.Cells["DocumentSeries"].Value?.ToString().Trim().ToLower() ?? "";
                string rowNumber = row.Cells["DocumentNumber"].Value?.ToString().Trim().ToLower() ?? "";
                string rowIssuedBy = row.Cells["IssuedBy"].Value?.ToString().Trim().ToLower() ?? "";
                string rowAddress = row.Cells["Address"].Value?.ToString().Trim().ToLower() ?? "";
                string rowIssueDate = row.Cells["IssueDate"].Value?.ToString().Trim().ToLower() ?? "";

                // Проверяем совпадение: условие игнорируется, если поле поиска пустое
                bool matches = true;
                if (!string.IsNullOrEmpty(lastName) && rowLastName.Contains(lastName)) matches = false;
                if (!string.IsNullOrEmpty(firstName) && rowFirstName.Contains(firstName)) matches = false;
                if (!string.IsNullOrEmpty(patronymic) && !rowPatronymic.Contains(patronymic)) matches = false;
                if (!string.IsNullOrEmpty(phone) && rowPhone.Contains(phone)) matches = false;
                if (!string.IsNullOrEmpty(series) && rowSeries.Contains(series)) matches = false;
                if (!string.IsNullOrEmpty(number) && rowNumber.Contains(number)) matches = false;
                if (!string.IsNullOrEmpty(issuedBy) && rowIssuedBy.Contains(issuedBy)) matches = false;
                if (!string.IsNullOrEmpty(address) && rowAddress.Contains(address)) matches = false;
                if (!string.IsNullOrEmpty(issueDate) && rowIssueDate.Contains(issueDate)) matches = false;

                if (matches)
                {
                    // Выделяем найденную строку
                    row.Selected = true;
                    dataGridViewReaders.CurrentCell = row.Cells[0]; // Устанавливаем текущую ячейку
                    found = true;
                    break; // Останавливаемся на первой найденной строке
                }
            }

            if (!found)
            {
                MessageBox.Show("Читатель с указанными данными не найден.",
                                "Результат поиска",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                dataGridViewReaders.ClearSelection(); // Снимаем выделение, если ничего не найдено
            }
        }
    }
}
