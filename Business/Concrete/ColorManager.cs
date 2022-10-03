using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            if (color.ColorName.Length > 2)
            {
                _colorDal.Add(color);
            }
            else
            {
                Console.WriteLine("Renk için en az 2 karakter girilmeli");
            }
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
    }
}
