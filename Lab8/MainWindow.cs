using Lab8.store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8 {
    public partial class Form1 : Form {

        private BookCollection bookCollection;

        public Form1() {
            InitializeComponent();
            bookCollection = new BookCollection();
        }

        private void addBookBtn_Click(object sender, EventArgs e) {
            errorText.Text = "";
            try {
                DateTime selectedDate = dateTimePicker.Value;
                string formattedDate = string.Format("1/1/{0}", selectedDate.Year);
                if (editPages.Text.Length > 0 && editPrice.Text.Length > 0) {
                    double price = Double.Parse(editPrice.Text.ToString());
                    int pages = Int32.Parse(editPages.Text.ToString());
                    Book book = new Book(editName.Text.ToString(), editPublishName.Text.ToString(), selectedDate, pages, price);
                    bookCollection.addBook(book);
                    displayBook(bookCollection.getBooks(), tempCatalogBox);
                } else {
                    throw new ArgumentException("Pages and Price cannot be empty!");
                }
            } catch (ArgumentException arg) {
                errorText.Text = arg.Message;
            } catch (FormatException ex) {
                errorText.Text = ex.Message;
            }
        }

     

        private void sortBtn_Click(object sender, EventArgs e) {
            if (bookCollection.getBooks().Count > 0) {
                bookCollection.SortKatalog();
                displayBook(bookCollection.getBooks(), tempCatalogBox);
            }
        }

        private void displayBook (List<Book> books, ListBox box) {
            box.Items.Clear();
            foreach (Book book in books) {
                box.Items.Add("Book name: " + book.Name);
                box.Items.Add("Publish name: " + book.PublishName);
                box.Items.Add("Publish year: " + book.Date.Year.ToString());
                box.Items.Add("Pages: " + book.Pages);
                box.Items.Add("Price: " + book.Price);
            }
        }

        private void discountBtn_Click(object sender, EventArgs e) {
            foreach (Book book in bookCollection.getBooks()) {
                book.setDiscount(book.Price, 0.25);
            }
            displayBook(bookCollection.getBooks(), tempCatalogBox);
        }

        private void writeBtn_Click(object sender, EventArgs e) {
            if (bookCollection.getBooks().Count > 0) {
                bookCollection.writeCatalogToFile();
                MessageBox.Show("Catalog saved successfully!", "Success", MessageBoxButtons.OK);
            }
        }

        private void readBtn_Click(object sender, EventArgs e) {
            try {
                displayBook(bookCollection.readCatalogFromFile(), fileBox);
            } catch (FormatException ex) {
                MessageBox.Show(ex.Message.ToString(), "Error!", MessageBoxButtons.OK);
            }
        }

        private void editFind_TextChanged(object sender, EventArgs e) {
            if (editFind.Text.Length > 0) {
                List<Book> findedBooks = bookCollection.FindBooksByPublishName(editFind.Text.ToString());
                countTxt.Text = "Знайдено: " + findedBooks.Count.ToString();
                displayBook(findedBooks, resultBox);
            }
        }

    }
}
