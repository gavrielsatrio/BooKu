using BooKu.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooKu
{
    public partial class MainForm : Form
    {
        private const int PER_PAGE_ITEM_COUNT = 8;
        private int totalPageCount = 0;
        private int previousCorrectPageNumber = 1;

        private BooKuEntities db = new BooKuEntities();

        // Mockup data

        //private List<MockupBook> allBookList = new List<MockupBook>()
        //{
        //    new MockupBook()
        //    {
        //        ID = 1,
        //        Title = "Learn Anything From Home",
        //        Description = "Description 1",
        //        FirstPublished = 2000,
        //        BookAuthors = new List<MockupAuthor>()
        //        {
        //            new MockupAuthor()
        //            {
        //                ID = 1,
        //                Name = "Gavriel",
        //                Bio = "Gavriel's bio",
        //                BirthDate = new DateTime(2003, 12, 18)
        //            }
        //        },
        //        BookSubjects = new List<string>()
        //        {
        //            "Learning",
        //            "Studying",
        //            "Exploring"
        //        },
        //        BookCovers = new List<string>()
        //        {
        //            "1-1.jpg",
        //            "1-2.jpg"
        //        }
        //    },
        //    new MockupBook()
        //    {
        //        ID = 2,
        //        Title = "Don't Learn Anything",
        //        Description = "Description 2",
        //        FirstPublished = 1989,
        //        BookAuthors = new List<MockupAuthor>()
        //        {
        //            new MockupAuthor()
        //            {
        //                ID = 2,
        //                Name = "Satrio",
        //                Bio = "Satrio's bio",
        //                BirthDate = new DateTime(2003, 12, 18)
        //            }
        //        },
        //        BookSubjects = new List<string>()
        //        {
        //            "Positive Vibes",
        //            "Nervousness",
        //            "Stablizer"
        //        },
        //        BookCovers = new List<string>()
        //        {
        //            "2-1.png",
        //            "2-2.jpg",
        //            "2-3.jpg"
        //        }
        //    }
        //};

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Translating raw data to database queries
            //var bookListFile = File.ReadAllText(Application.StartupPath + "/BookList.txt");
            //var bookLines = bookListFile.Split('\n');

            //var bookSubjectFile = File.ReadAllText(Application.StartupPath + "/BookSubjects.txt");
            //var subjectLines = bookSubjectFile.Split('\n');

            //var bookList = new List<Book>();
            //var authorList = new List<Author>();

            //var authorsQuery = new StringBuilder();
            //var booksQuery = new StringBuilder();
            //var bookAuthorsQuery = new StringBuilder();
            //var bookSubjectsQuery = new StringBuilder();
            //var bookCoversQuery = new StringBuilder();

            //for (int i = 0; i < bookLines.Length; i++)
            //{
            //    var bookLine = bookLines[i];
            //    var subjectLine = subjectLines[i];

            //    var bookString = bookLine.Substring(4);
            //    var subjectString = subjectLine.Substring(4);

            //    var bookTitle = bookString.Split('+')[0].Trim().Replace("'", "''");
            //    var bookDescription = bookString.Split('+')[2].Trim().Replace("'", "''");
            //    var bookFirstPublish = bookString.Split('+')[1].Trim().Replace("'", "''");

            //    bookList.Add(new Book
            //    {
            //        ID = bookList.Count + 1,
            //        Title = bookTitle,
            //        Description = bookDescription,
            //        FirstPublished = int.Parse(bookFirstPublish)
            //    });
            //    booksQuery.AppendLine($"INSERT INTO [Book] ([Title], [Description], [FirstPublished]) VALUES ('{bookTitle}', '{bookDescription}', '{bookFirstPublish}');");

            //    var bookID = bookList.FirstOrDefault(x => x.Title == bookTitle).ID;

            //    var bookAuthors = bookString.Split('+')[3].Split('(')[1].Split(')')[0].Split(',');
            //    for (int j = 0; j < bookAuthors.Length; j++)
            //    {
            //        var authorName = bookAuthors[j].Trim().Replace("'", "''");
            //        var authorBio = bookLine.Split('+')[4 + (j * 2)].Trim().Replace("'", "''");
            //        var authorBirthDate = bookLine.Split('+')[5 + (j * 2)].Trim().Replace("'", "''");

            //        if (authorList.Where(x => x.Name == authorName).Count() == 0)
            //        {
            //            authorList.Add(new Author
            //            {
            //                ID = authorList.Count + 1,
            //                Name = authorName,
            //                Bio = authorBio,
            //                BirthDate = DateTime.Parse(authorBirthDate)
            //            });

            //            authorsQuery.AppendLine($"INSERT INTO [Author] ([Name], [Bio], [BirthDate]) VALUES ('{authorName}', '{authorBio}', '{authorBirthDate}');");
            //        }

            //        var authorID = authorList.FirstOrDefault(x => x.Name == authorName).ID;
            //        bookAuthorsQuery.AppendLine($"INSERT INTO [BookAuthors] ([BookID], [AuthorID]) VALUES ('{bookID}', '{authorID}');");
            //    }

            //    var bookSubjects = subjectString.Split(',');
            //    for (int j = 0; j < bookSubjects.Length; j++)
            //    {
            //        bookSubjectsQuery.AppendLine($"INSERT INTO [BookSubjects] ([BookID], [Subject]) VALUES ('{bookID}', '{bookSubjects[j].Trim().Replace("'", "''")}');");
            //    }

            //    var bookCovers = Directory.GetFiles(Application.StartupPath + "/BookCovers", $"{bookID}-*", SearchOption.TopDirectoryOnly);
            //    for (int j = 0; j < bookCovers.Length; j++)
            //    {
            //        bookCoversQuery.AppendLine($"INSERT INTO [BookCovers] ([BookID], [ImagePath]) VALUES ('{bookID}', '{Path.GetFileName(bookCovers[j].Trim())}');");
            //    }
            //}


            //File.WriteAllText(Application.StartupPath + "/BooksQuery.txt", booksQuery.ToString());
            //File.WriteAllText(Application.StartupPath + "/AuthorsQuery.txt", authorsQuery.ToString());
            //File.WriteAllText(Application.StartupPath + "/BookAuthorsQuery.txt", bookAuthorsQuery.ToString());
            //File.WriteAllText(Application.StartupPath + "/BookSubjectsQuery.txt", bookSubjectsQuery.ToString());
            //File.WriteAllText(Application.StartupPath + "/BookCoversQuery.txt", bookCoversQuery.ToString());


            LoadData();
        }

        private void LoadData()
        {
            var query = db.Books.ToList();

            if(txtTitle.Text != "")
            {
                query = query.Where(x => x.Title.ToLower().Contains(txtTitle.Text.ToLower())).ToList();
            }

            if(txtAuthor.Text != "")
            {
                query = query.Where(x => x.BookAuthors.Where(y => y.Author.Name.ToLower().Contains(txtAuthor.Text.ToLower())).Count() > 0).ToList();
            }

            if(txtSubject.Text != "")
            {
                query = query.Where(x => x.BookSubjects.Where(y => y.Subject.ToLower().Contains(txtSubject.Text.ToLower())).Count() > 0).ToList();
            }

            totalPageCount = (int)Math.Ceiling((double)query.Count / PER_PAGE_ITEM_COUNT);
            lblPageCount.Text = "of " + totalPageCount.ToString();
            lblBookCount.Text = query.Count.ToString() + " Books found";

            dgvBookList.DataSource = query.OrderBy(x => x.Title).Select(x => new
            {
                x.ID,
                x.Title,
                Authors = string.Join(", ", x.BookAuthors.Select(y => y.Author.Name).ToArray())
            }).Skip((int.Parse(txtPageNumber.Text) - 1) * PER_PAGE_ITEM_COUNT).Take(PER_PAGE_ITEM_COUNT).ToList();

            dgvBookList.Columns["ID"].Visible = false;

            panelBookDetail.Controls.Clear();
        }

        private void btnPrevBookList_Click(object sender, EventArgs e)
        {
            var currentPageNumber = int.Parse(txtPageNumber.Text);
            if (currentPageNumber - 1 >= 1)
            {
                txtPageNumber.Text = (currentPageNumber - 1).ToString();
                LoadData();
            }
        }

        private void btnNextBookList_Click(object sender, EventArgs e)
        {
            var currentPageNumber = int.Parse(txtPageNumber.Text);
            if (currentPageNumber + 1 <= totalPageCount)
            {
                txtPageNumber.Text = (currentPageNumber + 1).ToString();
                LoadData();
            }
        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                panelBookDetail.Controls.Clear();

                var bookID = int.Parse(dgvBookList.CurrentRow.Cells["ID"].Value.ToString());
                var selectedBook = db.Books.Where(x => x.ID == bookID).FirstOrDefault();

                var bookDetailCard = new BookDetailCard(selectedBook)
                {
                    Dock = DockStyle.Fill
                };
                panelBookDetail.Controls.Add(bookDetailCard);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtPageNumber_TextChanged(object sender, EventArgs e)
        {
            if(txtPageNumber.Text == "")
            {
                return;
            }

            if(txtPageNumber.Text.All(char.IsDigit))
            {
                int inputtedNumber = int.Parse(txtPageNumber.Text);
                if(inputtedNumber <= 0)
                {
                    inputtedNumber = 1;
                }
                else if(inputtedNumber > totalPageCount)
                {
                    inputtedNumber = totalPageCount;
                }

                previousCorrectPageNumber = inputtedNumber;
                txtPageNumber.Text = inputtedNumber.ToString();
                LoadData();
            }
            else
            {
                txtPageNumber.Text = previousCorrectPageNumber.ToString();
            }
        }
    }
}
