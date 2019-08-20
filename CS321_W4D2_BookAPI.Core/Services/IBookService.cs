﻿using System.Collections.Generic;
using CS321_W4D2_BookAPI.Core.Models;

namespace CS321_W4D2_BookAPI.Core.Services
{
    public interface IBookService
    {
        // CRUDL - create (add), read (get), update, delete (remove), list

        // create
        Book Add(Book todo); 
        // read
        Book Get(int id);
        // update
        Book Update(Book todo); 
        // delete
        void Remove(Book todo);
        // list
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetBooksForAuthor(int id);
    }
}
