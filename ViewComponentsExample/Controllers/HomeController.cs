using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            PersonsList personList = new PersonsList() //Creating Model for GridViewComponent
            {
                Title = "Persons Details1",
                persons = new List<Person>()
                {
                    new Person()
                    {
                        Name="Aakash1",
                        JobTitle="Sr.Engg"
                    },
                    new Person()
                    {
                        Name="Deva(Vavachi)1",
                        JobTitle="HR"
                    },
                    new Person()
                    {
                        Name="Abhi1",
                        JobTitle="Sr.Engg"
                    },
                    new Person()
                    {
                        Name="Shambu1",
                        JobTitle="Sr.Engg"
                    }
                }
            };
            return View(personList);
        }

        [Route("About")]
        public IActionResult About()
        {
            PersonsList personList = new PersonsList() //Creating Model for GridViewComponent
            {
                Title = "Persons Details2",
                persons = new List<Person>()
                {
                    new Person()
                    {
                        Name="Aakash2",
                        JobTitle="Sr.Engg"
                    },
                    new Person()
                    {
                        Name="Deva(Vavachi)2",
                        JobTitle="HR"
                    },
                    new Person()
                    {
                        Name="Abhi2",
                        JobTitle="Sr.Engg"
                    },
                    new Person()
                    {
                        Name="Shambu2",
                        JobTitle="Sr.Engg"
                    }
                }
            };
            return View(personList);
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("friends-list")]
        public IActionResult Get_Friends_List()
        {
            PersonsList personList = new PersonsList() //Creating Model for GridViewComponent
            {
                Title = "Persons Details2",
                persons = new List<Person>()
                {
                    new Person()
                    {
                        Name="Aakash2",
                        JobTitle="Sr.Engg"
                    },
                    new Person()
                    {
                        Name="Deva(Vavachi)2",
                        JobTitle="HR"
                    },
                    new Person()
                    {
                        Name="Abhi2",
                        JobTitle="Sr.Engg"
                    },
                    new Person()
                    {
                        Name="Shambu2",
                        JobTitle="Sr.Engg"
                    }
                }
            };
            return ViewComponent("Grid", new { personsList = personList });

        }

    }
}
