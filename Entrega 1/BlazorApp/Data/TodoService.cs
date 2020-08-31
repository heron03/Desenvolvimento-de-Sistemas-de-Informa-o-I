using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class TodoService
    {
        public Task<List<Todo>> GetTodos()
        {
            var list = new Todo[]
            {
                new Todo
                {
                    id = 1,
                    TextoItem = "This is the first item",
                    Marcado = true,
                },

               new Todo
                {
                    id = 2,
                    TextoItem = "This is the second item",
                    Marcado = false,
                }
            };

            return Task.FromResult(list.ToList());

        }
    }
}