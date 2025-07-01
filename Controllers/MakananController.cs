using dietapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dietapp.Controllers
{
    public class MakananController
    {
        private readonly MakananModel _model;

        public MakananController()
        {
            _model = new MakananModel();
        }

        public List<Makanan> AmbilSemuaData()
        {
            return _model.GetAll();
        }

        public void TambahData(Makanan makanan)
        {
            _model.Insert(makanan);
        }

        public void PerbaruiData(Makanan makanan)
        {
            _model.Update(makanan);
        }

        public void HapusData(int id)
        {
            _model.Delete(id);
        }
    }
}
