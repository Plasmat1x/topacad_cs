using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp129.Services
{
    public interface ISerializeType
    {
        void Serialize(ISerialize obj, Type type);
        ISerialize Deserialize(ISerialize obj, Type type);
    }
}
