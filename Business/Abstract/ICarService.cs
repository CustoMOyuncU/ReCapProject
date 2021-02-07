﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Delete(Car car);
        void Update(Car car);
        void Add(Car car);
        Car GetById(int id);
        List<CarDetailDto> GetCarDetails();
    }
}
