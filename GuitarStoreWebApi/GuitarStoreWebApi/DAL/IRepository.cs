using System;
using System.Collections.Generic;

namespace GuitarsProject.DAL
{
    interface IRepository<T> : IDisposable where T : class
    {
        List<T> Get(); // получение всех объектов
        Auto Get(int id); //получение гитары
        void Create(Auto auto); //создание
        bool Delete(int id); //удаление
        void Update(Auto Auto); //обновление
        bool IsExists(int id);
    }
}
