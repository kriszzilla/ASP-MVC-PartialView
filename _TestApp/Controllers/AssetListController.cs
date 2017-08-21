using _TestApp.Infra;
using _TestApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _TestApp.Controllers
{
    public class AssetListController : Controller
    {
        DataContext context;

        public AssetListController()
        {
            this.context = new DataContext(Connections.connection);
        }


        // GET: AssetList
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ListOfBooks(int varID, string varDescription)
        {
            IList<Book> AllBooks = context.GetTable<Book>().ToArray();
            return PartialView(AllBooks.Where(x => x.BookId.ToString().Contains(varID.ToString()) && x.Description.Contains(varDescription) ));
        }

        public PartialViewResult ListOfPens(int varID, string varDescription)
        {
            IList<Pen> AllPens = context.GetTable<Pen>().ToArray();
            return PartialView(AllPens.Where(x => x.PenId.ToString().Contains(varID.ToString()) && x.Description.Contains(varDescription)));
        }

        public PartialViewResult ListOfToys(int varID, string varDescription)
        {
            IList<Toy> AllToys = context.GetTable<Toy>().ToArray();
            return PartialView(AllToys.Where(x => x.ToyId.ToString().Contains(varID.ToString()) && x.Description.Contains(varDescription)));
        }

    }
}