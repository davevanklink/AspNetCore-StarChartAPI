using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context { get; set; }
        
        [Route("")]

        public CelestialObjectController(ApplicationDbContext context)
        {
            this._context = context;
        }
    }
}
