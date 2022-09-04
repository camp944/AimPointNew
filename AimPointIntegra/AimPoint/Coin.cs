using System;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;
using PostgresRequests;

namespace Coin
{
   

    public class CoinClass
    {
        public double actualValue { get; set; }
        public double[][] historyValues = new double[6][];
        public int[] contValues = new int[6];
        public string coinName { get; set; }
        public string symbol { get; set; }
        public string convert { get; set; }


        public CoinClass(string coin, string simbolo, string CoinConvert)
        {
            for (int i = 0; i < 6; i++)
            {
                historyValues[i] = new double[96];
                contValues[i] = 0;
            }
            coinName = coin;
            symbol = simbolo;
            convert = CoinConvert;
            
        }
        
        
        
        public void AddValue(int cont, JObject coin)
        {

            if (cont == 6) { return; }

            PgReq request = new PgReq();



            if (historyValues[cont][95] != 0)
            {
                int walker = 0;

                while (walker < 96 - 1)
                {
                    historyValues[cont][walker] = historyValues[cont][walker + 1];
                }

                historyValues[cont][95] = actualValue;
               
            }
            else
            {
                int cont0 = 0;
                while (historyValues[cont][cont0] != 0) { cont0++; }
                historyValues[cont][cont0] = actualValue;
            }
            
            

            var result = request.Insert_Api_Request(cont, coin["data"]["quote"]["USD"]["last_updated"].ToString(),System.Convert.ToDecimal(actualValue));

            
            
            
            if(result == true)
            {
                if(cont == 0)
                {
                    Console.WriteLine("\t[ US$ " + String.Format("{0:0.###}", actualValue) + " ]\t[ " + coin["data"]["quote"]["USD"]["last_updated"].ToString() + " ]");
                }
                
                if(NextAdd(cont) && cont < 5)
                {
                    AddValue(cont + 1, coin);
                }
            }
            else
            {
                Console.WriteLine("\tNao inseriu");
            }


            contValues[cont] += 1;

            return;
        }

        public bool NextAdd(int cont)
        {
            if(cont == 0)
            {
                if(contValues[cont] % 5 == 0 ) { return true; }
                return false; 
            }

            if(cont == 1)
            {
                if (contValues[cont] % 6 == 0) { return true; }
                return false;
            }

            if (cont == 2)
            {
                if(contValues[cont] % 4 == 0) { return true; }
                return false;
            }

            if(cont == 3)
            {
                if(contValues[cont] % 7 == 0) { return true; }
                return false;
            }

            if (cont == 4)
            {
                if (contValues[cont] % 4 == 0) { return true; }
            }
            return false;

        }

        public double[] CalcAvgVariation()
        {
            var media = new double[6];
            
            for(int i = 0;i < 6; i++)
            {
                int j = 1;
                double aux = 0;

                while (historyValues[i][j]!=0)
                {
                    aux = aux + (historyValues[i][j] / historyValues[i][j-1]) * (j);
                    j++;
                }

                media[i] = aux / j;
            }

                return media;
        }
    }
    
}
