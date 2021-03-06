﻿using NewsPortal.Domain.Entities.Articles;
using NewsPortal.Domain.Entities.Common;
 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsPortal.Domain.Entitites.Articles
{
    [Table("Articles")]
    public class Article : AuditedEntity
    {
        public Article()
        {
            ArticleComments = new HashSet<ArticleComment>();
            ArticleLikes = new HashSet<ArticleLike>();
        }
        public bool Published { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string ShortContent { get; set; }
        public string LongContent { get; set; }
        public string Tags { get; set; }
        public ArticleType ArticleType { get; set; }
        public virtual ICollection<ArticleComment> ArticleComments { get; set; }
        public virtual ICollection<ArticleLike> ArticleLikes { get; set; }

        
    }
}
