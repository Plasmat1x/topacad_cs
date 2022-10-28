using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Comp
    {
        public string Some { set; get; }
    }

    [Serializable]
    class BaseClass
    {
        public string PhoneNumber { get; set; }
    }


    [Serializable]
    internal class Person : BaseClass
    {
        public string Name { get; set; }

        [NonSerialized]
        public int Id;

        public Comp Com { get; set; }
    }
}
