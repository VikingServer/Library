using Library.Data;
using Library.Repositories;
using Library.Services;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Library
{
    public partial class LibrarianBookManagmentForm : Form
    {
        private int selectedBookId = -1;
        private readonly BookService _bookService;

        public LibrarianBookManagmentForm()
        {
            InitializeComponent();
            var options = new DbContextOptionsBuilder<LibraryContext>()
                .UseNpgsql(DatabaseConnection.СonnectionString)
                .Options;
            var context = new LibraryContext(options);
            _bookService = new BookService(new BookRepository(context));
            LoadAutoCompleteData();
            CheckConnection();
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

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
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

        private void CheckConnection()
        {
            if (DatabaseConnection.IsConnect())
                LoadBooksData();
        }

        private void LoadBooksData()
        {
            try
            {
                dataGridViewBooks.DataSource = _bookService.GetBooks();

                NameBook.DataPropertyName = "Название";
                Author.DataPropertyName = "Автор";
                PublishingHouse.DataPropertyName = "Издательство";
                YearPublication.DataPropertyName = "Год издания";
                ReadingRoom.DataPropertyName = "Читальный зал";
                Mark.DataPropertyName = "Статус";
                StartDate.DataPropertyName = "Дата выдачи";
                FinishDate.DataPropertyName = "Дата возврата";
                Reader.DataPropertyName = "Читатель";

                dataGridViewBooks.Columns["StartDate"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dataGridViewBooks.Columns["FinishDate"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

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
                _bookService.AddBook(
                    textBoxTitle.Text,
                    textBoxAuthor.Text,
                    textBoxPublisher.Text,
                    string.IsNullOrWhiteSpace(textBoxYear.Text) ? null : DateOnly.Parse($"{textBoxYear.Text}-01-01"),
                    textBoxReadingRoom.Text,
                    checkBoxIssued.Checked,
                    textBoxReader.Text,
                    IssueDateTimePicker.Checked ? DateOnly.FromDateTime(IssueDateTimePicker.Value) : null,
                    ReturnDateTimePicker.Checked ? DateOnly.FromDateTime(ReturnDateTimePicker.Value) : null);

                MessageBox.Show("Книга успешно добавлена!",
                                "Успех",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadBooksData();
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении книги: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите изменить данные книги?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _bookService.UpdateBook(
                    selectedBookId,
                    textBoxTitle.Text,
                    textBoxAuthor.Text,
                    textBoxPublisher.Text,
                    string.IsNullOrWhiteSpace(textBoxYear.Text) ? null : DateOnly.Parse($"{textBoxYear.Text}-01-01"),
                    textBoxReadingRoom.Text,
                    checkBoxIssued.Checked,
                    textBoxReader.Text,
                    IssueDateTimePicker.Checked ? DateOnly.FromDateTime(IssueDateTimePicker.Value) : null,
                    ReturnDateTimePicker.Checked ? DateOnly.FromDateTime(ReturnDateTimePicker.Value) : null);

                MessageBox.Show("Данные книги успешно обновлены!",
                                "Успех",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadBooksData();
                ClearFormFields();
                selectedBookId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении книги: {ex.Message}",
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

            if (MessageBox.Show("Вы уверены, что хотите удалить эту книгу? Это действие нельзя отменить.",
                                "Подтверждение удаления",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _bookService.DeleteBook(selectedBookId);
                MessageBox.Show("Книга успешно удалена!",
                                "Успех",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadBooksData();
                ClearFormFields();
                selectedBookId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении книги: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
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
            try
            {
                using (var context = new LibraryContext(new DbContextOptionsBuilder<LibraryContext>()
                    .UseNpgsql(DatabaseConnection.СonnectionString).Options))
                {
                    var readers = context.ReadersFullName
                        .Select(fn => $"{fn.LastName} {fn.Name} {fn.MiddleName}")
                        .ToList();
                    var readerSource = new AutoCompleteStringCollection();
                    readerSource.AddRange(readers.ToArray());
                    textBoxReader.AutoCompleteCustomSource = readerSource;
                    textBoxReader.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                    var rooms = context.ReadingRooms
                        .Select(rr => rr.Name)
                        .ToList();
                    var roomSource = new AutoCompleteStringCollection();
                    roomSource.AddRange(rooms.ToArray());
                    textBoxReadingRoom.AutoCompleteCustomSource = roomSource;
                    textBoxReadingRoom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке автодополнения: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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
                string title = selectedRow.Cells["NameBook"].Value.ToString();

                using (var context = new LibraryContext(new DbContextOptionsBuilder<LibraryContext>()
                    .UseNpgsql(DatabaseConnection.СonnectionString).Options))
                {
                    selectedBookId = context.Books
                        .Where(b => b.Title == title)
                        .Select(b => b.BookId)
                        .FirstOrDefault();
                }

                textBoxTitle.Text = title;
                textBoxAuthor.Text = selectedRow.Cells["Author"].Value.ToString();
                textBoxPublisher.Text = selectedRow.Cells["PublishingHouse"].Value?.ToString();
                textBoxYear.Text = selectedRow.Cells["YearPublication"].Value?.ToString();
                textBoxReadingRoom.Text = selectedRow.Cells["ReadingRoom"].Value.ToString();
                textBoxReader.Text = selectedRow.Cells["Reader"].Value?.ToString();
                checkBoxIssued.Checked = selectedRow.Cells["Mark"].Value.ToString() == "Выдана";

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

            foreach (DataGridViewRow row in dataGridViewBooks.Rows)
            {
                if (row.IsNewRow) continue;

                string rowTitle = row.Cells["NameBook"].Value?.ToString().Trim().ToLower() ?? "";
                string rowAuthor = row.Cells["Author"].Value?.ToString().Trim().ToLower() ?? "";
                string rowPublisher = row.Cells["PublishingHouse"].Value?.ToString().Trim().ToLower() ?? "";
                string rowYear = row.Cells["YearPublication"].Value?.ToString().Trim().ToLower() ?? "";
                string rowReadingRoom = row.Cells["ReadingRoom"].Value?.ToString().Trim().ToLower() ?? "";
                string rowReader = row.Cells["Reader"].Value?.ToString().Trim().ToLower() ?? "";
                string rowStatus = row.Cells["Mark"].Value?.ToString().Trim().ToLower() ?? "";
                string rowIssueDate = row.Cells["StartDate"].Value?.ToString().Trim().ToLower() ?? "";
                string rowReturnDate = row.Cells["FinishDate"].Value?.ToString().Trim().ToLower() ?? "";

                if ((!string.IsNullOrEmpty(title) && rowTitle.Contains(title)) ||
                    (!string.IsNullOrEmpty(author) && rowAuthor.Contains(author)) ||
                    (!string.IsNullOrEmpty(publisher) && rowPublisher.Contains(publisher)) ||
                    (!string.IsNullOrEmpty(year) && rowYear.Contains(year)) ||
                    (!string.IsNullOrEmpty(readingRoom) && rowReadingRoom.Contains(readingRoom)) ||
                    (!string.IsNullOrEmpty(reader) && rowReader.Contains(reader)) ||
                    (!string.IsNullOrEmpty(status) && rowStatus.Contains(status)) ||
                    (!string.IsNullOrEmpty(issueDate) && rowIssueDate.Contains(issueDate)) ||
                    (!string.IsNullOrEmpty(returnDate) && rowReturnDate.Contains(returnDate)))
                {
                    row.Selected = true;
                    dataGridViewBooks.CurrentCell = row.Cells[0];
                    found = true;
                    break;
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