using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoTask
{
    public partial class BookNodeForm : Form
    {
        // Список книг
        private BookStore _bk;

        // В конструкторе получаем ссылку на списк книг из главной формы
        public BookNodeForm(BookStore bk)
        {
            InitializeComponent();
            _bk = bk;
            
            // Устанавливаем текстовые поля с датой и ценой по умолчанию
            textBoxPrice.Text = "0";
            textBoxYear.Text = DateTime.Today.Year.ToString();
        }


        // Добавление книги
        private void ButtonAddNode_Click(object sender, EventArgs e)
        {

            Book book = new Book();

            book.Title = textBoxTitle.Text;
            book.Category = textBoxCategory.Text;

            try
            {
                book.Year = Int32.Parse(textBoxYear.Text);
                book.Price = float.Parse(textBoxPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                book.Price = 0;
            }


            book.Authors = Regex.Split(textBoxAuthor.Text.Trim(), @"\s*(\w+;)\s*").ToList<String>();
            for (int i = 0; i < book.Authors.Count; i++)
            {
                if (book.Authors[i] == String.Empty)
                {
                    book.Authors.Remove(book.Authors[i]);
                }
            }


            _bk.Add(book);
            this.DialogResult = DialogResult.OK;

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // В поля цены и даты можно вводить не все символы
        private void DigitKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.KeyChar = '\0';
            }
        }

        // Парсим книгу по ссылке на сайт лабиринта
        private void ButtonParse_Click(object sender, EventArgs e)
        {

            // Если у пользователя нет интернета, уведомим его об этом
            if (!IsConnectionAvailable("http://www.google.com"))
            {
                MessageBox.Show("Отсутствует подключение к сети интернет!",
    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Book book = new Book();

            try
            {
                MessageBox.Show("Пожалуйста, подождите!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                book = Controller.GetController().GetParseBook(textBoxLinkToParse.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-пошло не так. {ex.Message}",
"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Заполняем поля новой книгой
            textBoxTitle.Text = book.Title;
            textBoxAuthor.Text = book.Authors[0];
            textBoxCategory.Text = book.Category;
            textBoxYear.Text = book.Year.ToString();
            textBoxPrice.Text = book.Price.ToString();
        }

        // Проверка на наличие интернета
        public bool IsConnectionAvailable(string strServer)
        {
            try
            {
                HttpWebRequest reqFP = (HttpWebRequest)HttpWebRequest.Create(strServer);
                HttpWebResponse rspFP = (HttpWebResponse)reqFP.GetResponse();
                if (HttpStatusCode.OK == rspFP.StatusCode)
                {
                    rspFP.Close();
                    return true;
                }
                else
                {
                    rspFP.Close();
                    return false;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}

