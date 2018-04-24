using System;
using System.Collections.Generic;
using System.Text;

namespace finalconsoleapp
{
    internal interface IDataMapper<T>
    {
        List<T> Select();
        List<T> Find(string LastName);
    }
}
