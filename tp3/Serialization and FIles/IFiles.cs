using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndFiles
{
    interface IFiles<T>
    {
        bool Save(string path, T data);
        bool Read(string path, out T data);
    }
}
