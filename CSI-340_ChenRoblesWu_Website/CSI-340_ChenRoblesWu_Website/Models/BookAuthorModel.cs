﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public class BookAuthorModel
    {
        public int bookId { get; set; }

        public int Id { get; set; }

        public int AuthorId { get; set; }

        public AuthorModel AuthorModel { get; set; }

        public BookModel BookModel { get; set; }
    }
}
