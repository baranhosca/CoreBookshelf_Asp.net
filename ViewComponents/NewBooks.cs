using Microsoft.AspNetCore.Mvc;
using CoreBookshelf.Models;

namespace CoreBookshelf.ViewComponents
{
    public class NewBooks : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var bookList = new List<Books_Database>
            {
                new Books_Database
                {
                    ID=6,
                    Book_Name="Fear",
                    Writer="Zweig"
                },
                new Books_Database
                {
                    ID=7,
                    Book_Name="Anna Karanina",
                    Writer="Tolstoy"
                }
            };
            return View(bookList);
        }
    }
}
