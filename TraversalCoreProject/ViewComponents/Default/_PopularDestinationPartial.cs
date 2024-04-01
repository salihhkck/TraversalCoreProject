using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace TraversalCoreProject.Views.Default
{
    public class _PopularDestinationPartial: ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values=destinationManager.TGetList();
            return View(values);
        }
    }
}
