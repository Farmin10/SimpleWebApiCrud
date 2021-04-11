using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApiCrud.Model;
using SimpleWebApiCrud.PersonelDatas;

namespace SimpleWebApiCrud.Controllers
{
    
    [ApiController]
    public class PersonelsController : ControllerBase
    {
        private  IPersonelData _personelData;
        public PersonelsController(IPersonelData personelData)
        {
            _personelData = personelData;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAll()
        {
            return Ok(_personelData.GetPersonels());
        }


        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetById(int id)
        {
           var value= _personelData.GetPersonel(id);
            if (value!=null)
            {
                return Ok(value);
            }
            return NotFound();
        }



        [HttpPost]
        [Route("api/[controller]/{add}")]
        public IActionResult Add(Personel personel)
        {
            var data= _personelData.Add(personel);
            return Ok();
        }




        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
           _personelData.Delete(id);
            return Ok();
        }



        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Update(int id,Personel personel)
        {
            var result= _personelData.GetPersonel(id);
            personel.Id = result.Id;
            _personelData.Update(personel);
            return Ok();
        }
    }
}
