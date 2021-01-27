using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TamaguchiClient.DTO
{
    public class PetDTO
    {

        public string PetName { get; set; }
        public int PetCode { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public int PetWeight { get; set; }
        public int HungerStatus { get; set; }
        public int HappinessStatus { get; set; }
        public int HygieneStatus { get; set; }
        public int PlayerCode { get; set; }

        

    }
}
