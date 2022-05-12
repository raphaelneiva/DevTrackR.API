using System.Collections.Generic;
using DevTrackR.API.Entities;
using DevTrackR.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevTrackR.API.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackageController : ControllerBase
    {
        //Get api/packages
        [HttpGet]
        public IActionResult GetAll(){
            var packages = new List<Package>{
                new Package("Pacote 1", 0.8M),
                new Package("Pacote 2", 1.1M)
            };

            return Ok(packages);
        }
        //Get api/packages/1234-5678-9000
        [HttpGet("{code}")]
        public IActionResult GetByCode(string code){
            var package = new Package("Pacote 2", 1.1M);

            return Ok();
        }
        //Post api/packages
        [HttpPost]
        public IActionResult Post(AddPackageInputModel model){
            var package = new Package(model.Title, model.Weigth);   

            return Ok();
        }
        // POST api/packages/1234/5678-9000/updates
        [HttpPost("{code}/updates")]
        public IActionResult PostUpdate(string code, AddPackageUpdateModel model){
            var package = new Package("Pacote 1", 1.2M);

            package.AddUpdate(model.Status, model.Delivered);

            return Ok();

        }


    }
}