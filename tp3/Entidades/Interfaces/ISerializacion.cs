using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface ISerializacion<T>
    {
        bool Serialize(T data, string path);
        bool Deserialize(string path, out T data);

    }
}
