﻿using System;
using System.Collections.Generic;

namespace CS321_W4D2_BookAPI.Core.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

