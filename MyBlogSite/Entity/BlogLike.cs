﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyBlogSite.Entity.Abstract;

namespace MyBlogSite.Entity
{
    public class BlogLike : BaseEntity
    {
        [Required]
        [Column("email", TypeName = "nvarchar(255)")]
        public string Email { get; set; }
        [Required]
        [Column("blog_id")]
        public Guid BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
