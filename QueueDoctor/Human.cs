using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDoctor
{
    public enum DoctorType
    {
        threapist,
        neurologist,
        surgeon, 
    }

    internal class Human
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public DoctorType Doctor { get; set; }

        public Human(string Name, string Phone, DoctorType Doctor)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Doctor = Doctor;
        }
    }
}
