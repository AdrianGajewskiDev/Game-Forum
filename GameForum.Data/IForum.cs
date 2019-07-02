using GameForum.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForum.Data
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
    }
}
