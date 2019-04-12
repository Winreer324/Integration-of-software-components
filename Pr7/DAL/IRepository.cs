using System;
using System.Collections.Generic;

namespace Pr7
{
    interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> Get(); // получение всех объектов

        //Auto Get(int id); //получение гитары

        void Create(int id, string firma, string model, string number, double speed, double price);
        void Delete(int id);
        void Update(int id, string firma, string model, string number, double speed, double price);
    }
}