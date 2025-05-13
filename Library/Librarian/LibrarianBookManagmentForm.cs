using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class LibrarianBookManagmentForm : Form
    {
        private int selectedBookId = -1;

        public LibrarianBookManagmentForm()
        {
            InitializeComponent();
            LoadAutoCompleteData();

            if (DatabaseConnection.IsConnect())
            {
                LoadBooksData();
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к базе данных",
                "Ошибка подключения",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            IssueDateTimePicker.ShowCheckBox = true;
            ReturnDateTimePicker.ShowCheckBox = true;
            IssueDateTimePicker.Checked = false;
            ReturnDateTimePicker.Checked = false;
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianManageReadersForm form6 = new LibrarianManageReadersForm();
            form6.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianMenuForm menuLibrarian = new LibrarianMenuForm();
            menuLibrarian.Show();
        }

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            // Проверяем, загружены ли данные
            if (dataGridViewBooks.DataSource == null)
            {
                MessageBox.Show("Данные не загружены. Нажмите 'Загрузить таблицу'.",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            SearchBook();
        }

        private void LoadBooksData()
        {
            try
            {
                string query = @"
                    SELECT 
                    k.Название AS ""Название"",
                    ka.Автор AS ""Автор"",
                    чз.Название AS ""Читальный зал"",
                    k.Издательство AS ""Издательство"",
                    TO_CHAR(k.ГодИздания, 'YYYY') AS ""Год издания"",
                    CASE 
                        WHEN km.Метка = 'Выдана' THEN 'Выдана'
                        ELSE 'Доступна'
                    END AS ""Статус"",
                    TO_CHAR(ko.ДатаВыдачи, 'DD.MM.YYYY') AS ""Дата выдачи"",
                    TO_CHAR(ko.ДатаВозврата, 'DD.MM.YYYY') AS ""Дата возврата"",
                    CASE 
                        WHEN km.Метка = 'Выдана' THEN 
                            COALESCE(ф.Фамилия || ' ' || LEFT(ф.Имя, 1) || '. ' || LEFT(ф.Отчество, 1) || '.', '')
                        ELSE ''
                    END AS ""Читатель""
                FROM 
                    Книги k
                JOIN 
                    КнигиИАвтор ka ON k.idКниги = ka.idКниги
                JOIN 
                    ЧитальныйЗалИКниги чзик ON k.idКниги = чзик.idКниги
                JOIN 
                    ЧитальныеЗалы чз ON чзик.idЧитальногоЗала = чз.idЧитальногоЗала
                LEFT JOIN 
                    КнигиМетка km ON k.idКниги = km.idКниги
                LEFT JOIN
                    Книгооборот ko ON k.idКниги = ko.idКниги
                LEFT JOIN
                    ЧитателиИКниги чк ON k.idКниги = чк.idКниги
                LEFT JOIN
                    Читатели ч ON чк.idЧитателя = ч.idЧитателя
                LEFT JOIN
                    ФИОЧитатели ф ON ч.idЧитателя = ф.idЧитателя
                ORDER BY 
                    k.Название";

                DataTable booksData = DatabaseConnection.ExecuteQuery(query);
                NameBook.DataPropertyName = "Название";
                Author.DataPropertyName = "Автор";
                PublishingHouse.DataPropertyName = "Издательство";
                YearPublication.DataPropertyName = "Год издания";
                ReadingRoom.DataPropertyName = "Читальный зал";
                Mark.DataPropertyName = "Статус";
                StartDate.DataPropertyName = "Дата выдачи";
                FinishDate.DataPropertyName = "Дата возврата";
                Reader.DataPropertyName = "Читатель";

                dataGridViewBooks.DataSource = booksData;

                // Настройка форматирования
                dataGridViewBooks.Columns["StartDate"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dataGridViewBooks.Columns["FinishDate"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                // Условное форматирование для статуса
                var statusColumn = dataGridViewBooks.Columns["Mark"];

                // Специальный стиль для выданных книг
                dataGridViewBooks.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == dataGridViewBooks.Columns["Mark"].Index && e.Value != null)
                    {
                        if (e.Value.ToString() == "Выдана")
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.Font = new Font(dataGridViewBooks.Font, FontStyle.Bold);
                            e.CellStyle.BackColor = Color.LightPink;
                        }
                        else
                        {
                            e.CellStyle.ForeColor = Color.Green;
                            e.CellStyle.BackColor = Color.LightGreen;
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            if (DatabaseConnection.IsConnect())
            {
                LoadBooksData();
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к базе данных",
                "Ошибка подключения",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка обязательных полей
                if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                    string.IsNullOrWhiteSpace(textBoxReadingRoom.Text))
                {
                    MessageBox.Show("Заполните обязательные поля: Название, Автор, Читальный зал",
                                  "Ошибка",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // Получаем ID читального зала
                int readingRoomId = GetReadingRoomId(textBoxReadingRoom.Text);
                if (readingRoomId == -1)
                {
                    MessageBox.Show("Читальный зал не найден!");
                    return;
                }

                using (var connection = new NpgsqlConnection(DatabaseConnection.СonnectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 1. Вставляем запись в ЧитальныйЗалИКниги
                            string insertRoomBookQuery = @"
                        INSERT INTO ЧитальныйЗалИКниги (idЧитальногоЗала)
                        VALUES (@RoomId)
                        RETURNING idКниги;";

                            int bookId;
                            using (var command = new NpgsqlCommand(insertRoomBookQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@RoomId", readingRoomId);
                                bookId = Convert.ToInt32(command.ExecuteScalar());
                            }

                            // 2. Добавляем книгу
                            string insertBookQuery = @"
                        INSERT INTO Книги (idКниги, Название, Издательство, ГодИздания)
                        VALUES (@BookId, @Title, @Publisher, @Year);";

                            object yearValue = DBNull.Value;
                            if (!string.IsNullOrWhiteSpace(textBoxYear.Text))
                            {
                                if (int.TryParse(textBoxYear.Text, out int year))
                                {
                                    yearValue = new DateTime(year, 1, 1);
                                }
                                else
                                {
                                    MessageBox.Show("Некорректный формат года издания",
                                                  "Ошибка",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            using (var command = new NpgsqlCommand(insertBookQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", bookId);
                                command.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                                command.Parameters.AddWithValue("@Publisher",
                                    string.IsNullOrWhiteSpace(textBoxPublisher.Text) ?
                                    DBNull.Value : textBoxPublisher.Text);
                                command.Parameters.AddWithValue("@Year", yearValue);
                                command.ExecuteNonQuery();
                            }

                            // 3. Добавляем автора
                            string insertAuthorQuery = @"
                        INSERT INTO КнигиИАвтор (idКниги, Автор)
                        VALUES (@BookId, @Author);";

                            using (var command = new NpgsqlCommand(insertAuthorQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", bookId);
                                command.Parameters.AddWithValue("@Author", textBoxAuthor.Text);
                                command.ExecuteNonQuery();
                            }

                            // 4. Если книга выдана, добавляем запись о выдаче
                            if (checkBoxIssued.Checked)
                            {
                                int readerId = GetReaderId(textBoxReader.Text);
                                if (readerId == -1)
                                {
                                    MessageBox.Show("Читатель не найден",
                                                  "Ошибка",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Warning);
                                    return;
                                }

                                // 4.1. Добавляем запись о выдаче
                                string insertIssueQuery = @"
                            INSERT INTO Книгооборот (idКниги, ДатаВыдачи, ДатаВозврата)
                            VALUES (@BookId, @IssueDate, @ReturnDate);";

                                if (IssueDateTimePicker.Checked && ReturnDateTimePicker.Checked && ReturnDateTimePicker.Value < IssueDateTimePicker.Value)
                                {
                                    MessageBox.Show("Дата возврата не может быть раньше даты выдачи",
                                                  "Ошибка",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Warning);
                                    return;
                                }

                                object issueDate = IssueDateTimePicker.Checked ? IssueDateTimePicker.Value : DBNull.Value;
                                object returnDate = ReturnDateTimePicker.Checked ? ReturnDateTimePicker.Value : DBNull.Value;

                                using (var command = new NpgsqlCommand(insertIssueQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@BookId", bookId);
                                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
                                    command.ExecuteNonQuery();
                                }

                                // 4.2. Связываем книгу с читателем
                                string insertReaderQuery = @"
                            INSERT INTO ЧитателиИКниги (idКниги, idЧитателя)
                            VALUES (@BookId, @ReaderId);";

                                using (var command = new NpgsqlCommand(insertReaderQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@BookId", bookId);
                                    command.Parameters.AddWithValue("@ReaderId", readerId);
                                    command.ExecuteNonQuery();
                                }

                                // 4.3. Обновляем метку книги
                                string updateMarkQuery = @"
                            INSERT INTO КнигиМетка (idКниги, Метка)
                            VALUES (@BookId, 'Выдана')
                            ON CONFLICT (idКниги) DO UPDATE SET Метка = 'Выдана';";

                                using (var command = new NpgsqlCommand(updateMarkQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@BookId", bookId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Если книга не выдана, устанавливаем метку "Нет"
                                string updateMarkQuery = @"
                            INSERT INTO КнигиМетка (idКниги, Метка)
                            VALUES (@BookId, 'Нет')
                            ON CONFLICT (idКниги) DO UPDATE SET Метка = 'Нет';";

                                using (var command = new NpgsqlCommand(updateMarkQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@BookId", bookId);
                                    command.ExecuteNonQuery();
                                }
                            }

                            // Фиксируем транзакцию
                            transaction.Commit();

                            MessageBox.Show("Книга успешно добавлена!",
                                          "Успех",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);

                            // Обновляем таблицу
                            LoadBooksData();

                            // Очищаем поля формы
                            ClearFormFields();
                        }
                        catch (NpgsqlException ex) when (ex.SqlState == "23505")
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ошибка: книга с таким ID уже существует. Попробуйте снова.",
                                          "Ошибка уникальности",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка при добавлении книги Skype: {ex.Message}",
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

        private int GetReadingRoomId(string roomName)
        {
            string query = "SELECT idЧитальногоЗала FROM ЧитальныеЗалы WHERE Название = @Name";
            var parameter = new NpgsqlParameter("@Name", roomName);

            object result = DatabaseConnection.ExecuteScalar(query, new NpgsqlParameter[] { parameter });
            return result != null ? Convert.ToInt32(result) : -1;
        }

        private int GetReaderId(string readerName)
        {
            if (string.IsNullOrWhiteSpace(readerName)) return -1;

            string[] names = readerName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (names.Length < 2) return -1;

            string query = @"
                SELECT ч.idЧитателя 
                FROM Читатели ч
                JOIN ФИОЧитатели ф ON ч.idЧитателя = ф.idЧитателя
                WHERE ф.Фамилия = @LastName AND ф.Имя LIKE @FirstName || '%'";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@LastName", names[0]),
                new NpgsqlParameter("@FirstName", names[1])
            };

            object result = DatabaseConnection.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }

        private void ClearFormFields()
        {
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxPublisher.Clear();
            textBoxYear.Clear();
            textBoxReadingRoom.Clear();
            textBoxReader.Clear();
            checkBoxIssued.Checked = false;
            IssueDateTimePicker.Checked = false;
            ReturnDateTimePicker.Checked = false;
            ReturnDateTimePicker.Checked = false;
        }

        private void СheckBoxIssued_CheckedChanged(object sender, EventArgs e)
        {
            ReturnDateTimePicker.Enabled = checkBoxIssued.Checked;
            textBoxReader.Enabled = checkBoxIssued.Checked;

            if (!checkBoxIssued.Checked)
            {
                ReturnDateTimePicker.Value = DateTime.Now.AddDays(14);
                textBoxReader.Clear();
            }
        }

        private void LoadAutoCompleteData()
        {
            // Для читателей
            string readersQuery = "SELECT Фамилия || ' ' || Имя || ' ' || Отчество AS ФИО FROM ФИОЧитатели";
            DataTable readers = DatabaseConnection.ExecuteQuery(readersQuery);

            var readerSource = new AutoCompleteStringCollection();
            foreach (DataRow row in readers.Rows)
            {
                readerSource.Add(row["ФИО"].ToString());
            }
            textBoxReader.AutoCompleteCustomSource = readerSource;
            textBoxReader.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            // Для читальных залов
            string roomsQuery = "SELECT Название FROM ЧитальныеЗалы";
            DataTable rooms = DatabaseConnection.ExecuteQuery(roomsQuery);

            var roomSource = new AutoCompleteStringCollection();
            foreach (DataRow row in rooms.Rows)
            {
                roomSource.Add(row["Название"].ToString());
            }
            textBoxReadingRoom.AutoCompleteCustomSource = roomSource;
            textBoxReadingRoom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void TextBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                selectedBookId = -1;
                ClearFormFields();
                return;
            }

            try
            {
                var selectedRow = dataGridViewBooks.SelectedRows[0];
                // Получаем idКниги через запрос, так как он не отображается в таблице
                string title = selectedRow.Cells["NameBook"].Value.ToString();
                string query = @"
            SELECT k.idКниги
            FROM Книги k
            WHERE k.Название = @Title";
                var parameter = new NpgsqlParameter("@Title", title);
                selectedBookId = Convert.ToInt32(DatabaseConnection.ExecuteScalar(query, new NpgsqlParameter[] { parameter }));

                // Загружаем данные в поля формы
                textBoxTitle.Text = title;
                textBoxAuthor.Text = selectedRow.Cells["Author"].Value.ToString();
                textBoxPublisher.Text = selectedRow.Cells["PublishingHouse"].Value?.ToString();
                textBoxYear.Text = selectedRow.Cells["YearPublication"].Value?.ToString();
                textBoxReadingRoom.Text = selectedRow.Cells["ReadingRoom"].Value.ToString();
                textBoxReader.Text = selectedRow.Cells["Reader"].Value?.ToString();
                checkBoxIssued.Checked = selectedRow.Cells["Mark"].Value.ToString() == "Выдана";

                // Устанавливаем даты выдачи и возврата
                IssueDateTimePicker.Checked = !string.IsNullOrEmpty(selectedRow.Cells["StartDate"].Value?.ToString());
                if (IssueDateTimePicker.Checked)
                {
                    IssueDateTimePicker.Value = DateTime.Parse(selectedRow.Cells["StartDate"].Value.ToString());
                }

                ReturnDateTimePicker.Checked = !string.IsNullOrEmpty(selectedRow.Cells["FinishDate"].Value?.ToString());
                if (ReturnDateTimePicker.Checked)
                {
                    ReturnDateTimePicker.Value = DateTime.Parse(selectedRow.Cells["FinishDate"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных книги: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                selectedBookId = -1;
                ClearFormFields();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите изменить данные книги?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            EditData();
        }

        private void EditData()
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Выберите книгу для редактирования",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Проверка обязательных полей
                if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                    string.IsNullOrWhiteSpace(textBoxReadingRoom.Text))
                {
                    MessageBox.Show("Заполните обязательные поля: Название, Автор, Читальный зал",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Получаем ID читального зала
                int readingRoomId = GetReadingRoomId(textBoxReadingRoom.Text);
                if (readingRoomId == -1)
                {
                    MessageBox.Show("Читальный зал не найден!",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = new NpgsqlConnection(DatabaseConnection.СonnectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 1. Обновляем данные в таблице Книги
                            string updateBookQuery = @"
                        UPDATE Книги
                        SET Название = @Title, Издательство = @Publisher, ГодИздания = @Year
                        WHERE idКниги = @BookId;";

                            object yearValue = DBNull.Value;
                            if (!string.IsNullOrWhiteSpace(textBoxYear.Text))
                            {
                                if (int.TryParse(textBoxYear.Text, out int year))
                                {
                                    yearValue = new DateTime(year, 1, 1);
                                }
                                else
                                {
                                    MessageBox.Show("Некорректный формат года издания",
                                                    "Ошибка",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            using (var command = new NpgsqlCommand(updateBookQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);
                                command.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                                command.Parameters.AddWithValue("@Publisher",
                                    string.IsNullOrWhiteSpace(textBoxPublisher.Text) ? DBNull.Value : textBoxPublisher.Text);
                                command.Parameters.AddWithValue("@Year", yearValue);
                                command.ExecuteNonQuery();
                            }

                            // 2. Обновляем автора
                            string updateAuthorQuery = @"
                        UPDATE КнигиИАвтор
                        SET Автор = @Author
                        WHERE idКниги = @BookId;";

                            using (var command = new NpgsqlCommand(updateAuthorQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);
                                command.Parameters.AddWithValue("@Author", textBoxAuthor.Text);
                                command.ExecuteNonQuery();
                            }

                            // 3. Обновляем читальный зал
                            string updateRoomQuery = @"
                        UPDATE ЧитальныйЗалИКниги
                        SET idЧитальногоЗала = @RoomId
                        WHERE idКниги = @BookId;";

                            using (var command = new NpgsqlCommand(updateRoomQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);
                                command.Parameters.AddWithValue("@RoomId", readingRoomId);
                                command.ExecuteNonQuery();
                            }

                            // 4. Обновляем статус выдачи
                            if (checkBoxIssued.Checked)
                            {
                                int readerId = GetReaderId(textBoxReader.Text);
                                if (readerId == -1)
                                {
                                    MessageBox.Show("Читатель не найден",
                                                    "Ошибка",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Warning);
                                    return;
                                }

                                // 4.1. Обновляем или вставляем запись в Книгооборот
                                string upsertIssueQuery = @"
                            INSERT INTO Книгооборот (idКниги, ДатаВыдачи, ДатаВозврата)
                            VALUES (@BookId, @IssueDate, @ReturnDate)
                            ON CONFLICT (idКниги)
                            DO UPDATE SET ДатаВыдачи = @IssueDate, ДатаВозврата = @ReturnDate;";

                                if (IssueDateTimePicker.Checked && ReturnDateTimePicker.Checked && ReturnDateTimePicker.Value < IssueDateTimePicker.Value)
                                {
                                    MessageBox.Show("Дата возврата не может быть раньше даты выдачи",
                                                    "Ошибка",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Warning);
                                    return;
                                }

                                object issueDate = IssueDateTimePicker.Checked ? IssueDateTimePicker.Value : DBNull.Value;
                                object returnDate = ReturnDateTimePicker.Checked ? ReturnDateTimePicker.Value : DBNull.Value;

                                using (var command = new NpgsqlCommand(upsertIssueQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@BookId", selectedBookId);
                                    command.Parameters.AddWithValue("@IssueDate", issueDate);
                                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
                                    command.ExecuteNonQuery();
                                }

                                // 4.2. Обновляем или вставляем связь с читателем
                                string upsertReaderQuery = @"
                            INSERT INTO ЧитателиИКниги (idКниги, idЧитателя)
                            VALUES (@BookId, @ReaderId)
                            ON CONFLICT (idКниги)
                            DO UPDATE SET idЧитателя = @ReaderId;";

                                using (var command = new NpgsqlCommand(upsertReaderQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@BookId", selectedBookId);
                                    command.Parameters.AddWithValue("@ReaderId", readerId);
                                    command.ExecuteNonQuery();
                                }

                                // 4.3. Обновляем метку
                                string updateMarkQuery = @"
                            INSERT INTO КнигиМетка (idКниги, Метка)
                            VALUES (@BookId, 'Выдана')
                            ON CONFLICT (idКниги)
                            DO UPDATE SET Метка = 'Выдана';";

                                using (var command = new NpgsqlCommand(updateMarkQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@BookId", selectedBookId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Если книга не выдана, удаляем записи из Книгооборот и ЧитателиИКниги
                                string deleteIssueQuery = @"
                            DELETE FROM Книгооборот WHERE idКниги = @BookId;
                            DELETE FROM ЧитателиИКниги WHERE idКниги = @BookId;";

                                using (var command = new NpgsqlCommand(deleteIssueQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@BookId", selectedBookId);
                                    command.ExecuteNonQuery();
                                }

                                // Устанавливаем метку "Нет"
                                string updateMarkQuery = @"
                            INSERT INTO КнигиМетка (idКниги, Метка)
                            VALUES (@BookId, 'Нет')
                            ON CONFLICT (idКниги)
                            DO UPDATE SET Метка = 'Нет';";

                                using (var command = new NpgsqlCommand(updateMarkQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@BookId", selectedBookId);
                                    command.ExecuteNonQuery();
                                }
                            }

                            // Фиксируем транзакцию
                            transaction.Commit();

                            MessageBox.Show("Данные книги успешно обновлены!",
                                            "Успех",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            // Обновляем таблицу
                            LoadBooksData();

                            // Очищаем поля формы
                            ClearFormFields();
                            selectedBookId = -1;
                        }
                        catch (NpgsqlException ex) when (ex.SqlState == "23505")
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ошибка: книга с таким названием или ID уже существует.",
                                            "Ошибка уникальности",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка при обновлении книги: {ex.Message}",
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Выберите книгу для удаления",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Подтверждение удаления
            if (MessageBox.Show("Вы уверены, что хотите удалить эту книгу? Это действие нельзя отменить.",
                                "Подтверждение удаления",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            DeleteBook();
        }

        private void DeleteBook()
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
                            string deleteReaderBookQuery = @"
                                DELETE FROM ЧитателиИКниги
                                WHERE idКниги = @BookId;";

                            using (var command = new NpgsqlCommand(deleteReaderBookQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);
                                command.ExecuteNonQuery();
                            }

                            string deleteCirculationQuery = @"
                                DELETE FROM Книгооборот
                                WHERE idКниги = @BookId;";

                            using (var command = new NpgsqlCommand(deleteCirculationQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);
                                command.ExecuteNonQuery();
                            }

                            string deleteMarkQuery = @"
                                DELETE FROM КнигиМетка
                                WHERE idКниги = @BookId;";

                            using (var command = new NpgsqlCommand(deleteMarkQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);
                                command.ExecuteNonQuery();
                            }

                            string deleteAuthorQuery = @"
                                DELETE FROM КнигиИАвтор
                                WHERE idКниги = @BookId;";

                            using (var command = new NpgsqlCommand(deleteAuthorQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);
                                command.ExecuteNonQuery();
                            }

                            string deleteBookQuery = @"
                                DELETE FROM Книги
                                WHERE idКниги = @BookId;";

                            using (var command = new NpgsqlCommand(deleteBookQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);
                                command.ExecuteNonQuery();
                            }

                            string deleteRoomBookQuery = @"
                                DELETE FROM ЧитальныйЗалИКниги
                                WHERE idКниги = @BookId;";

                            using (var command = new NpgsqlCommand(deleteRoomBookQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);
                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Книга успешно удалена!",
                                            "Успех",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            LoadBooksData();
                            ClearFormFields();
                            selectedBookId = -1;
                        }
                        catch (NpgsqlException ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка при удалении книги: {ex.Message}",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Общая ошибка: {ex.Message}",
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

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void SearchBook()
        {
            DataTable dataTable = (DataTable)dataGridViewBooks.DataSource;
            string title = textBoxTitle.Text.Trim().ToLower();
            string author = textBoxAuthor.Text.Trim().ToLower();
            string publisher = textBoxPublisher.Text.Trim().ToLower();
            string year = textBoxYear.Text.Trim().ToLower();
            string readingRoom = textBoxReadingRoom.Text.Trim().ToLower();
            string reader = textBoxReader.Text.Trim().ToLower();
            string status = checkBoxIssued.Checked ? "выдана" : "";
            string issueDate = IssueDateTimePicker.Checked ? IssueDateTimePicker.Value.ToString("dd.MM.yyyy") : "";
            string returnDate = ReturnDateTimePicker.Checked ? ReturnDateTimePicker.Value.ToString("dd.MM.yyyy") : "";

            bool found = false;

            // Проходим по всем строкам таблицы
            foreach (DataGridViewRow row in dataGridViewBooks.Rows)
            {
                if (row.IsNewRow) continue; // Пропускаем новую строку

                string rowTitle = row.Cells["NameBook"].Value?.ToString().Trim().ToLower() ?? "";
                string rowAuthor = row.Cells["Author"].Value?.ToString().Trim().ToLower() ?? "";
                string rowPublisher = row.Cells["PublishingHouse"].Value?.ToString().Trim().ToLower() ?? "";
                string rowYear = row.Cells["YearPublication"].Value?.ToString().Trim().ToLower() ?? "";
                string rowReadingRoom = row.Cells["ReadingRoom"].Value?.ToString().Trim().ToLower() ?? "";
                string rowReader = row.Cells["Reader"].Value?.ToString().Trim().ToLower() ?? "";
                string rowStatus = row.Cells["Mark"].Value?.ToString().Trim().ToLower() ?? "";
                string rowIssueDate = row.Cells["StartDate"].Value?.ToString().Trim().ToLower() ?? "";
                string rowReturnDate = row.Cells["FinishDate"].Value?.ToString().Trim().ToLower() ?? "";

                // Проверяем совпадение по любому непустому полю
                if ((!string.IsNullOrEmpty(title) && rowTitle.Contains(title)) ||
                    (!string.IsNullOrEmpty(author) && rowAuthor.Contains(author)) ||
                    (!string.IsNullOrEmpty(publisher) && rowPublisher.Contains(publisher)) ||
                    (!string.IsNullOrEmpty(year) && rowYear.Contains(year)) ||
                    (!string.IsNullOrEmpty(readingRoom) && rowReadingRoom.Contains(readingRoom)) ||
                    (!string.IsNullOrEmpty(reader) && rowReader.Contains(reader)) ||
                    (!string.IsNullOrEmpty(status) && rowStatus.Contains(status)) ||
                    (!string.IsNullOrEmpty(issueDate) && rowIssueDate.Contains(issueDate)) &&
                    (!string.IsNullOrEmpty(returnDate) && rowReturnDate.Contains(returnDate)))
                {
                    // Выделяем найденную строку
                    row.Selected = true;
                    dataGridViewBooks.CurrentCell = row.Cells[0]; // Устанавливаем текущую ячейку
                    found = true;
                    break; // Останавливаемся на первой найденной строке
                }
            }

            if (!found)
            {
                MessageBox.Show("Книга с указанными данными не найдена.",
                                "Результат поиска",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                dataGridViewBooks.ClearSelection();
            }
        }
    }
}
