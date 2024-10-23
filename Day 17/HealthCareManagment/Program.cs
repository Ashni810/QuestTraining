using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace HealthCareManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new HealthCareManager().ListUpcomingAppontmentsInNextSevenDays();
        }
    }
}
