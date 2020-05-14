using System;
using System.Linq;

namespace EntityFrameworkCorePractice
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            //with Entity Framework only
            EfOnly entityOnly = new EfOnly();
            entityOnly.EfExecute();
*/


            //with Entity Framework using Generics
            EfGen efGen = new EfGen();
            efGen.EfGenExecute();
            
        }
    }
}
