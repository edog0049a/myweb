using System.Web.Mvc;
using myweb.Models;
namespace myweb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new Context())
            {

                context.Employees.Add(new Employee()
                {
                    EmployeeNumber=6456,
                    User= new User ()
                    {
                        UserName="Edog0049a"
                    },
                    Profile= new Profile ()
                    {
                        Email="edog0049a@yahoo.com",
                        Address=new Address()
                        {
                            State="Ma"
                        }
                    },
                    Name = new Name()
                    {
                        FirstName = "Eli",
                        LastName = "Reid"
                    }
                });
                context.SaveChanges();
            }
            
            return View();
        }
    
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}