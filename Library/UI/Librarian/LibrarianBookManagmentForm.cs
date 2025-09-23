using Library.Data;
using Library.Repositories;
using Library.Services;
using Library.UI;
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

            InitializeForm();
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
                BookInUI bookUI = new(textBoxTitle.Text,
                                      textBoxAuthor.Text,
                                      textBoxPublisher.Text,
                                      string.IsNullOrWhiteSpace(textBoxYear.Text) ? null : DateOnly.Parse($"{textBoxYear.Text}-01-01"),
                                      textBoxReadingRoom.Text,
                                      checkBoxIssued.Checked,
                                      textBoxReader.Text,
                                      IssueDateTimePicker.Checked ? DateOnly.FromDateTime(IssueDateTimePicker.Value) : null,
                                      ReturnDateTimePicker.Checked ? DateOnly.FromDateTime(ReturnDateTimePicker.Value) : null);

                _bookService.AddBook(bookUI);

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
                BookInUI bookUI = new(textBoxTitle.Text,
                                      textBoxAuthor.Text,
                                      textBoxPublisher.Text,
                                      string.IsNullOrWhiteSpace(textBoxYear.Text) ? null : DateOnly.Parse($"{textBoxYear.Text}-01-01"),
                                      textBoxReadingRoom.Text,
                                      checkBoxIssued.Checked,
                                      textBoxReader.Text,
                                      IssueDateTimePicker.Checked ? DateOnly.FromDateTime(IssueDateTimePicker.Value) : null,
                                      ReturnDateTimePicker.Checked ? DateOnly.FromDateTime(ReturnDateTimePicker.Value) : null);

                _bookService.UpdateBook(selectedBookId, bookUI);

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

        private void btnClearField_Click(object sender, EventArgs e)
        {
            this.ClearAllControls();
            selectedBookId = -1;
        }

        private void InitializeForm()
        {
            IssueDateTimePicker.ShowCheckBox = true;
            ReturnDateTimePicker.ShowCheckBox = true;
            IssueDateTimePicker.Checked = false;
            ReturnDateTimePicker.Checked = false;

            LoadAutoCompleteData();
            CheckConnection();
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

        private void CheckConnection()
        {
            if (DatabaseConnection.IsConnect())
                LoadBooksData();
        }

        private void LoadBooksData()
        {
            try
            {
                var books = _bookService.GetBooks();

                dataGridViewBooks.Columns.Clear();
                dataGridViewBooks.AutoGenerateColumns = false;

                var columns = new[]
                {
                    new DataGridViewTextBoxColumn { Name = "NameBook", HeaderText = "Название", DataPropertyName = "Название" },
                    new DataGridViewTextBoxColumn { Name = "Author", HeaderText = "Автор", DataPropertyName = "Автор" },
                    new DataGridViewTextBoxColumn { Name = "PublishingHouse", HeaderText = "Издательство", DataPropertyName = "Издательство" },
                    new DataGridViewTextBoxColumn { Name = "YearPublication", HeaderText = "Год издания", DataPropertyName = "Год издания" },
                    new DataGridViewTextBoxColumn { Name = "ReadingRoom", HeaderText = "Читальный зал", DataPropertyName = "Читальный зал" },
                    new DataGridViewTextBoxColumn { Name = "Mark", HeaderText = "Статус", DataPropertyName = "Статус" },
                    new DataGridViewTextBoxColumn { Name = "StartDate", HeaderText = "Дата выдачи", DataPropertyName = "Дата выдачи" },
                    new DataGridViewTextBoxColumn { Name = "FinishDate", HeaderText = "Дата возврата", DataPropertyName = "Дата возврата" },
                    new DataGridViewTextBoxColumn { Name = "Reader", HeaderText = "Читатель", DataPropertyName = "Читатель" }
                };

                dataGridViewBooks.Columns.AddRange(columns);

                dataGridViewBooks.DataSource = books;

                dataGridViewBooks.Columns["StartDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewBooks.Columns["FinishDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridViewBooks.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == dataGridViewBooks.Columns["Mark"]?.Index && e.Value != null)
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
                MessageBox.Show($"Ошибка при загрузке таблицы: {ex.Message}",
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
                DataGridViewRow selectedRow = dataGridViewBooks.SelectedRows[0];

                string title = selectedRow.Cells["NameBook"].Value?.ToString() ?? "";
                string author = selectedRow.Cells["Author"].Value?.ToString() ?? "";
                string publisher = selectedRow.Cells["PublishingHouse"].Value?.ToString() ?? "";
                string year = selectedRow.Cells["YearPublication"].Value?.ToString() ?? "";
                string readingRoom = selectedRow.Cells["ReadingRoom"].Value?.ToString() ?? "";
                string reader = selectedRow.Cells["Reader"].Value?.ToString() ?? "";
                string mark = selectedRow.Cells["Mark"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(title))
                {
                    selectedBookId = -1;
                    FillFormFields(title, author, publisher, year, readingRoom, reader, mark, selectedRow);
                    return;
                }

                using (var context = new LibraryContext(new DbContextOptionsBuilder<LibraryContext>()
                    .UseNpgsql(DatabaseConnection.СonnectionString).Options))
                {
                    selectedBookId = context.Books
                        .Where(b => b.Title == title)
                        .Select(b => b.BookId)
                        .FirstOrDefault();
                }

                FillFormFields(title, author, publisher, year, readingRoom, reader, mark, selectedRow);
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

        private void FillFormFields(string title, string author, string publisher, string year, string readingRoom, string reader, string mark, DataGridViewRow selectedRow)
        {
            textBoxTitle.Text = title;
            textBoxAuthor.Text = author;
            textBoxPublisher.Text = publisher;
            textBoxYear.Text = year;
            textBoxReadingRoom.Text = readingRoom;
            textBoxReader.Text = reader;
            checkBoxIssued.Checked = mark == "Выдана";

            string startDateStr = selectedRow.Cells["StartDate"].Value?.ToString() ?? "";
            IssueDateTimePicker.Checked = !string.IsNullOrEmpty(startDateStr);
            if (IssueDateTimePicker.Checked)
            {
                if (DateTime.TryParse(startDateStr, out DateTime startDate))
                    IssueDateTimePicker.Value = startDate;
                else
                    IssueDateTimePicker.Value = DateTime.Now;
            }

            string finishDateStr = selectedRow.Cells["FinishDate"].Value?.ToString() ?? "";
            ReturnDateTimePicker.Checked = !string.IsNullOrEmpty(finishDateStr);
            if (ReturnDateTimePicker.Checked)
            {
                if (DateTime.TryParse(finishDateStr, out DateTime finishDate))
                    ReturnDateTimePicker.Value = finishDate;
                else
                    ReturnDateTimePicker.Value = DateTime.Now;
            }
        }

        private void SearchBook()
        {
            try
            {
                var dataTable = (DataTable)dataGridViewBooks.DataSource;
                var searchCriteria = new Dictionary<string, string>
                {
                    { "Название", Utils.NormalizeField(textBoxTitle.Text) },
                    { "Автор", Utils.NormalizeField(textBoxAuthor.Text) },
                    { "Издательство", Utils.NormalizeField(textBoxPublisher.Text) },
                    { "Год издания", Utils.NormalizeField(textBoxYear.Text) },
                    { "Читальный зал", Utils.NormalizeField(textBoxReadingRoom.Text) },
                    { "Читатель", Utils.NormalizeField(textBoxReader.Text) },
                    { "Статус", checkBoxIssued.Checked ? "выдана" : "" },
                    { "Дата выдачи", Utils.NormalizeDateField(IssueDateTimePicker) },
                    { "Дата возврата", Utils.NormalizeDateField(ReturnDateTimePicker) }
                };

                var foundRow = dataTable.AsEnumerable().FirstOrDefault(row =>
                {
                    return Utils.MatchesAnyCriteria(row, searchCriteria);
                });

                if (foundRow != null)
                {
                    var index = dataTable.Rows.IndexOf(foundRow);
                    dataGridViewBooks.Rows[index].Selected = true;
                    dataGridViewBooks.CurrentCell = dataGridViewBooks.Rows[index].Cells[0];
                }
                else
                {
                    MessageBox.Show("Книга с указанными данными не найдена.",
                                    "Результат поиска",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске книги: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                dataGridViewBooks.ClearSelection();
            }
        }
    }
}