using BooKu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooKu
{
    public partial class BookDetailCard : UserControl
    {
        private Book book;
        private int currentBookCoversIndex = 0;

        public BookDetailCard(Book selectedBook)
        {
            InitializeComponent();

            this.book = selectedBook;
        }

        private void BookDetailCard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = book.Title;
            lblAuthor.Text = "by " + string.Join(", ", book.BookAuthors.Select(x => x.Author.Name).ToArray());
            lblFirstPublished.Text = "first published: " + book.FirstPublished;
            txtDescValue.Text = book.Description;
            txtSubjectValue.Text = string.Join("; ", book.BookSubjects.Select(x => x.Subject).ToArray());

            LoadBookCovers();
        }

        private void LoadBookCovers()
        {
            picBoxBookCovers.Image = null;
            picBoxBookCovers.ImageLocation = Application.StartupPath + "/BookCovers/" + book.BookCovers.ToList()[currentBookCoversIndex].ImagePath;
        }

        private void btnPrevBookCovers_Click(object sender, EventArgs e)
        {
            if(currentBookCoversIndex - 1 < 0)
            {
                currentBookCoversIndex = book.BookCovers.Count - 1;
            }
            else
            {
                currentBookCoversIndex--;
            }

            LoadBookCovers();
        }

        private void btnNextBookCovers_Click(object sender, EventArgs e)
        {
            if(currentBookCoversIndex + 1 > book.BookCovers.Count - 1)
            {
                currentBookCoversIndex = 0;
            }
            else
            {
                currentBookCoversIndex++;
            }
            
            LoadBookCovers();
        }
    }
}
