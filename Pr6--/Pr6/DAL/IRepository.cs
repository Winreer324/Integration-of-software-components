using System;
using System.Collections.Generic;

namespace Pr6
{
    interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> Get(); // получение всех объектов

        Auto Get(int id); //получение гитары

        void Create(Auto auto);
        void Delete(int id);
        void Update(Auto auto);
    }
}