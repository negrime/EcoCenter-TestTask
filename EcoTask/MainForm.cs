using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EcoTask
{
    public partial class MainForm : Form
    {
        private Controller _controller = Controller.GetController(); // Контроллер 
        private BookStore _bs = new BookStore(); // Список книг
        
        private bool _isDocumentChanged = false; // Произошли ли изменение в таблице


        public MainForm()
        {
            Application.Idle += new EventHandler(delegate (object sender, EventArgs e)
            {
                UpdateUi(); // Постоянно проверям состояние формы, чтобы элементы ui были в корректном состоянии
            });

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDataGrid(); // Инициализируем таблицу
        }

        private void UpdateUi()
        {
            // Если никакая ячейка не выбрана - кнопка удалить не работает
            if (bookDataGridView.CurrentRow != null)
            {
                buttonDeleteNode.Enabled = true;
            }
            else
            {
                buttonDeleteNode.Enabled = false;
            }

            // Если таблица пустая - кнопка сохранить не работает
            if (bookDataGridView.Rows.Count != 0)
            {
                buttonSaveXML.Enabled = true;
            }
            else
            {
                buttonSaveXML.Enabled = false ;
            }

        }

        // Создание таблицы
        private void InitDataGrid()
        {
            DataGridViewColumn columnName = new DataGridViewColumn();
            columnName.HeaderText = "Книга" ; //текст в шапке
            columnName.Width = 200; // ширина колонки
            columnName.Name = "name"; // название колонки в коде
            columnName.CellTemplate = new DataGridViewTextBoxCell(); //тип  колонки

            var columnAuthor = new DataGridViewColumn();
            columnAuthor.HeaderText = "Автор";
            columnAuthor.Width = 200;
            columnAuthor.Name = "author";
            columnAuthor.CellTemplate = new DataGridViewTextBoxCell();

            var columnCategory = new DataGridViewColumn();
            columnCategory.HeaderText = "Категория";
            columnCategory.Width = 195;
            columnCategory.Name = "category";
            columnCategory.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn columnPrice = new DataGridViewColumn();
            columnPrice.HeaderText = "Цена";
            columnPrice.Name = "price";
            columnPrice.CellTemplate = new DataGridViewTextBoxCell();


            bookDataGridView.Columns.Add(columnName);
            bookDataGridView.Columns.Add(columnAuthor);
            bookDataGridView.Columns.Add(columnCategory);
            bookDataGridView.Columns.Add(columnPrice);
        }

        // Открытие XML файла
        private void ButtonOpenXML_Click(object sender, EventArgs e)
        {
            // Если в документе были не сохраненные изменения
            if (_isDocumentChanged)
            {
                // Спрашиваем пользователя
                if (MessageBox.Show($"Вы не сохранили изменения в текущем файле! Все равно открыть новый?", "Уведомление!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "XML files (*.xml)|*.xml";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Пробуем открыть xml файл
                try
                {
                    _bs = _controller.OpenXml(openFileDlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии файла {ex.Message}", 
                        "Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return;
                }

                // Чистим таблицу от старых записей
                bookDataGridView.Rows.Clear();
                // Инициализируем таблицу данными из файла 
                foreach (Book item in _bs)
                {
                    bookDataGridView.Rows.Add();
                    bookDataGridView["name", bookDataGridView.Rows.Count - 1].Value = item.Title;

                    foreach (var i in item.Authors)
                    {
                        bookDataGridView["author", bookDataGridView.Rows.Count - 1].Value += i;
                    }

                    bookDataGridView["price", bookDataGridView.Rows.Count - 1].Value = item.Price;
                    bookDataGridView["category", bookDataGridView.Rows.Count - 1].Value = item.Category;
                }
            }
        }

        // Сохранение в XML
        private void ButtonSaveXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "XML files (*.xml)|*.xml";
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                _controller.SaveXml(_bs, saveFileDlg.FileName);

                // Файл сохранили, значит свежих изменений в файле нет
                _isDocumentChanged = false;
            }
        }

        // Редактирование
        private void BookDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Если после редактирования в ячейке ничего нет, то дальше не идем
            if (bookDataGridView.CurrentCell.Value == null)
                return;

            int index = bookDataGridView.CurrentCell.RowIndex;
            Book book = _bs.GetElement(index);

            // Узнаем индекс ячейки, где произошло редактирование
            switch (e.ColumnIndex)
            {
                case 0:
                    book.Title = bookDataGridView.CurrentCell.Value.ToString();
                    break;
                case 1:
                    // Дергаем из строки авторов и конвертируем их в список с помощью регулярного выражения
                    book.Authors = Regex.Split(bookDataGridView.CurrentCell.Value.ToString().Trim(),
                        @"\s*(\w+;)\s*").ToList<String>();
                    // Избавляемся от пустых записей в списке
                    for (int i = 0; i < book.Authors.Count; i++)
                    {
                        if (book.Authors[i] == String.Empty)
                        {
                            book.Authors.Remove(book.Authors[i]);
                        }
                    }

                    break;
                case 2:
                    book.Category = bookDataGridView.CurrentCell.Value.ToString();
                    break;

                case 3:
                    try
                    {
                        book.Price = float.Parse(bookDataGridView.CurrentCell.Value.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("В поле \"Цена\" некорректное число!", "Ошибка!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        book.Price = 0;
                        bookDataGridView.CurrentCell.Value = 0;
                    }
                    break;
                default:
                    break;
            }

            // В таблице произошло изменение
            _isDocumentChanged = true;
        }

        // Удаление книги
        private void ButtonDeleteNode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Уведомление", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Удаляем книгу из списка и из таблицы
                _bs.RemoveAt(bookDataGridView.CurrentRow.Index);
                bookDataGridView.Rows.Remove(bookDataGridView.CurrentRow);
                _isDocumentChanged = true;
            }
        }

        // Добавление книги
        private void ButtonAddNode_Click(object sender, EventArgs e)
        {
            BookNodeForm bn = new BookNodeForm(_bs);
            bn.ShowDialog();
            if (bn.DialogResult == DialogResult.OK)
            {
                AddRow(_bs.GetElement(_bs.Size - 1));
                _isDocumentChanged = true;
            }
        }

        // Добавление строки с книгой
        private void AddRow(Book book)
        {
            string authors = default;
            foreach (var item in book.Authors)
            {
                authors += item;
            }
            bookDataGridView.Rows.Add(book.Title, authors, book.Category, book.Price);
        }


        // Отчет в HTML из XML
        private void ButtonSaveHTML_Click(object sender, EventArgs e)
        {
            // Сначала выбираем xml файл
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.FileName = "Выберите XML файл";
            openFileDlg.Filter = "XML files (*.xml)|*.xml";

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Затем выбираем куда будем сохранять отчет
                SaveFileDialog saveFileDlg = new SaveFileDialog();
                saveFileDlg.FileName = "Отчет";
                saveFileDlg.Filter = "HTML files (*.html)|*.html";

                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    _controller.XmlToHtml(openFileDlg.FileName, saveFileDlg.FileName);
                    // Открываем файл
                    Process.Start(saveFileDlg.FileName);
                }
            }
        }
    }
}

