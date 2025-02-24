using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.AuthorDtos
{
    public class GetAuthorByBlogAuthorIdDto
    {
        public int blogID { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
        public int authorID { get; set; }
        public string authorName { get; set; }
    }
}
