using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Lab8.store {
    internal class BookCollection {

        private List<Book> books;
        public BookCollection() {
            books = new List<Book>();
        }

        public void addBook (Book book) {
            books.Add(book);
        }

        public void removeBook (Book book) {
            books.Remove(book);
        }

        public void SortKatalog () {
            books.Sort();
        }

        public List<Book> getBooks () {
            return books;
        }

        public List<Book> FindBooksByPublishName(string publishName) {
            List<Book> foundBooks = books.FindAll(book => book.PublishName == publishName);
            return foundBooks;
        }

        public void writeCatalogToFile () {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (StreamWriter writer = new StreamWriter("books.xml")) {
                serializer.Serialize(writer, books);
            }
        }
        public List<Book> readCatalogFromFile () {
            try {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                using (StreamReader reader = new StreamReader("books.xml")) {
                    books = (List<Book>)serializer.Deserialize(reader);
                    return books;
                }
            } catch (Exception ex) {
                throw new FormatException("Invalid format");
            }          
        }

    }
}
