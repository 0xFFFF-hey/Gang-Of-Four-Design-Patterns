using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        // String Current(); // PROBLEM: what if don't always wanna iterate over strings? E.g. Customers or integers.
        T Current(); // SOLUTION: Use a Generic type
    }
}
