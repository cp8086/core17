using System.Collections.Generic;

namespace core17.Services
{
    public interface IRepostitory<T> where T:class
    {
        IEnumerable<T> Getall();

    }
}