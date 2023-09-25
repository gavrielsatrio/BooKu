using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKu.Models
{
    public class MockupBook
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FirstPublished { get; set; }

        public List<MockupAuthor> BookAuthors { get; set; }
        public List<string> BookSubjects { get; set; }
        public List<string> BookCovers { get; set; }
    }
}
