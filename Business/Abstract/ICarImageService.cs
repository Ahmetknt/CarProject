using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IResult Add(List<IFormFile> formFile, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(List<IFormFile> file, CarImage carImage);
    }
}
