using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Shared.Entities.Abstract;

namespace www.yasinkaya.org.Entities.Concrete
{
    public class Article : EntityBase, IEntity
    {
        /// <summary>
        /// Article Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Article Content
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Thumbnail
        /// </summary>
        public string Thumbnail { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Views Count
        /// </summary>
        public int ViewsCount { get; set; }
        /// <summary>
        /// Comment Count
        /// </summary>
        public int CommentCount { get; set; }
        /// <summary>
        /// Seo Author
        /// </summary>
        public string SeoAuthor { get; set; }
        /// <summary>
        /// Seo Description
        /// </summary>
        public string SeoDesc { get; set; }
        /// <summary>
        /// Seo Tags
        /// </summary>
        public string SeoTags { get; set; }
        /// <summary>
        /// Category Number
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Category
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// User Number
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// User
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Comments
        /// </summary>
        public ICollection<Comment> Comments { get; set; }
    }
}