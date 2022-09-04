using System;
using System.Net;
using System.Web;



namespace PostgresRequests
{

    class PgReq
    {
        private const string Domain = "AimPoint30.Domain.Logics.";
        private const string Business = "Business";
        private const string Entities = "AimPoint30.Entities.Model.";
        public string[][] logicNames = new string[2][];

        public PgReq()
        {
            logicNames[0][0] = "Min6";
            logicNames[0][1] = "Min30";
            logicNames[0][2] = "Hour3";
            logicNames[0][3] = "Day1";
            logicNames[0][4] = "Day7";
            logicNames[0][5] = "Week4";

            logicNames[1][0] = "SightMin6";
            logicNames[1][1] = "SightMin30";
            logicNames[1][2] = "SightHour3";
            logicNames[1][3] = "SightDay1";
            logicNames[1][4] = "SightDay_7";
            logicNames[1][5] = "SightWeek_4";
        }

        public bool Insert_Api_Request(int cont, string date, decimal price )
        {
            try
            {
                dynamic objEntity = Activator.CreateInstance(Type.GetType($"{Entities}{logicNames[0][cont]}"));
                objEntity.Price = price;
                objEntity.DateRequest = date;

                dynamic objBusiness = Activator.CreateInstance(Type.GetType($"{Domain}{logicNames[0][cont]}{Business}"));
                
                objBusiness.GetType().GetMethod("Salvar").Invoke(objBusiness, new[] { objEntity });


                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            
        }

        public bool Insert_Sighter(int cont, string[] data)
        {
            try
            {
              


                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }


        }

    }
}
