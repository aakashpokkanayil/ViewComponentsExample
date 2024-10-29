using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents
{
    public class GridViewComponent: ViewComponent // must inherit from ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(PersonsList personsList)
        {
            ViewBag.Grid = new PersonsList() //Creating viewbag in GridViewComponent
            { 
                Title = "Persons Details",
                persons = new List<Person>()
                { 
                    new Person()
                    {
                        Name="Aakash",
                        JobTitle="Sr.Engg"
                    },
                    new Person()
                    {
                        Name="Deva(Vavachi)",
                        JobTitle="HR"
                    },
                    new Person()
                    {
                        Name="Abhi",
                        JobTitle="Sr.Engg"
                    },
                    new Person()
                    {
                        Name="Shambu",
                        JobTitle="Sr.Engg"
                    }
                }
            };

            #region Creating Model for GridViewComponent
            //PersonsList personList= new PersonsList() //Creating Model for GridViewComponent
            //{
            //    Title = "Persons Details",
            //    persons = new List<Person>()
            //    {
            //        new Person()
            //        {
            //            Name="Aakash",
            //            JobTitle="Sr.Engg"
            //        },
            //        new Person()
            //        {
            //            Name="Deva(Vavachi)",
            //            JobTitle="HR"
            //        },
            //        new Person()
            //        {
            //            Name="Abhi",
            //            JobTitle="Sr.Engg"
            //        },
            //        new Person()
            //        {
            //            Name="Shambu",
            //            JobTitle="Sr.Engg"
            //        }
            //    }
            //};
            #endregion


            return View("GridViewComponent", personsList);
            // this invokes Partial View ,
            // default path: Views/Shared/Components/Grid{this class name}/{Viewname.cshtml}
            // default name of {Viewname.cshtml} is default.cshtml, but if we give custom name then
            // need to mention like this "return View("GridViewComponent");"
        }
    }
}
