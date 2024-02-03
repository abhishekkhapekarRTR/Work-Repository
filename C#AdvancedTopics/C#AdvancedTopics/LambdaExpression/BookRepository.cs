using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedTopics.LambdaExpression
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "Title 1", Price = 50},
                new Book() { Title = "Title 2", Price = 150},
                new Book() { Title = "Title 3", Price = 250},
                new Book() { Title = "C#", Price = 10},
                new Book() { Title = "ASP.NET MVC", Price = 25},
                new Book() { Title = "Azure Cloud", Price = 47}
            };
        }
    }
}
