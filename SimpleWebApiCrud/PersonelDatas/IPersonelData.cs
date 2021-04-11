using SimpleWebApiCrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApiCrud.PersonelDatas
{
    public interface IPersonelData
    {
        List<Personel> GetPersonels();
        Personel GetPersonel(int id);
        Personel Add(Personel personel);
        Personel Update(Personel personel);
        void Delete(int id);
    }
}
