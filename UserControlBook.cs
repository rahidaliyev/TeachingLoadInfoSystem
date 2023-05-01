﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;

namespace TeachingLoadInfoSystem
{
    public partial class UserControlBook : UserControl
    {
        public Book Books { get; set; } = new Book();
        public List<Book> BookList { get; set; } = new List<Book>();
        IBookServices _bookServices;
        TLDbContext db = new TLDbContext();
        public UserControlBook(TLDbContext db)
        {
            InitializeComponent();
            this.db = db;
            _bookServices = new BookServices(new Repository<Book>(db));
            layoutControl1.AutoScroll = false;
        }
        public UserControlBook(TLDbContext db, Book books)
        {
            this.db = db;
            Books = books;
            InitializeComponent();
            _bookServices = new BookServices(new Repository<Book>(db));
            layoutControl1.AutoScroll = false;
            LoadBooks();
        }
        public void LoadBooks()
        {
            if (Books != null)
            {
                bookNameTxt.Text = Books.BookName;
                isTextBookCheck.Checked = Books.IsTextBook;
            }
        }

        private void bookNameTxt_EditValueChanged(object sender, EventArgs e)
        {
            Books.BookName = bookNameTxt.Text;
        }

        private void isTextBookCheck_CheckedChanged(object sender, EventArgs e)
        {
            Books.IsTextBook = isTextBookCheck.Checked;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            if (Books.ID != 0)
            {
                _bookServices.DeleteBook(Books.ID);
                BookList.Remove(Books);
            }
            else if (Books != null)
            {
                BookList.Remove(Books);
            }
        }
    }
}
