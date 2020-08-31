using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Todo
    {
        public int id { get; set; }
        public string TextoItem { get; set; }

        public bool Marcado { get; set; }
    }
}