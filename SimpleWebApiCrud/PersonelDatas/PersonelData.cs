using SimpleWebApiCrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApiCrud.PersonelDatas
{
    public class PersonelData:IPersonelData
    {
        List<Personel> ModelState = new List<Personel>()
        {
            new Personel()
            {
                 Id=1,Name="Farmin",Address="Qusar"
            },
            new Personel()
            {
                 Id=2,Name="Murad",Address="Quba"
            },
            new Personel()
            {
                 Id=3,Name="Feqan",Address="Xudat"
            }
        };

        public Personel Add(Personel personel)
        {
            ModelState.Add(personel);
            return personel;
        }

        public void Delete(int id)
        {
            var result = ModelState.FirstOrDefault(x=>x.Id==id);
            ModelState.Remove(result);
        }

        public Personel GetPersonel(int id)
        {
            return ModelState.SingleOrDefault(x=>x.Id==id);
        }

        public List<Personel> GetPersonels()
        {
            return ModelState;
        }

        public Personel Update(Personel personel)
        {
            var result = GetPersonel(personel.Id);
            result.Name = personel.Name;
            result.Address = personel.Address;
            return result;
        }
    }
}
