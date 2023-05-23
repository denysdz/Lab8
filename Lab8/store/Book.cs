using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.store {
    public class Book : IComparable {

        private static DateTime datatime;
        private String name;
        private String publishName;
        private DateTime date;
        private int pages;
        private double price;
        private bool hasDiscount = false;

        public Book() {}

        public Book (String name, String publishName, DateTime date, int pages, double price) {
            Name = name;
            PublishName = publishName;
            Date = date;
            Pages = pages;
            Price = price;
        }

        public String Name {
            get {
                return name;
            }
            set {
                if (value.Length == 0) {
                    throw new ArgumentException("Name cannot be empty");
                } else {
                    name = value;
                }
            }
        }

        public String PublishName {
            get {
                return publishName;
            }
            set {
                if (value.Length == 0) {
                    throw new ArgumentException("Publish name cannot be empty");
                } else {
                    publishName = value;
                }
            }
        }

        public DateTime Date {
            get { 
                return date;
            }
            set {
                date = value;
            }
        }

        public int Pages {
            get {
                return pages;
            }
            set {
                if (value < 1) {
                    throw new ArgumentException("Cannot be less then 1");
                } else {
                    pages = value;
                }
            }
        }

        public double Price {
            get {
                return price;
            }
            set {
                if (value < 0) {
                    throw new ArgumentException("Cannot be less then 0");
                } else {
                    price = value;
                }
            }
        }

        public void setDiscount (double currenPrice, double discount) {
            if ((DateTime.Now.Year - date.Year > 2) && !hasDiscount) {
                price = currenPrice - (currenPrice * discount);
                hasDiscount = true;
            }
        }

        public int CompareTo(object obj) {
            if (obj == null) return 1;
            if (obj is Book) {
                Book objBook = (Book)obj;
                return objBook.publishName.CompareTo(this.publishName);
            }
            else {
                throw new InvalidComObjectException("Invalid object book");
            }
        }

    }

}
