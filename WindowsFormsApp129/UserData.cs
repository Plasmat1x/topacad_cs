using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp129.Services;

namespace WindowsFormsApp129
{
    public class UserData : ISerialize
    {
        public string FileName { get; set; } = nameof(UserData);
    }
}
