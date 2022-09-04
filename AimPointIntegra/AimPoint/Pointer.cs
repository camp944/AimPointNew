using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coin;
using Newtonsoft.Json.Linq;
using PostgresRequests;


namespace Pointer
{
    public class Sighter
    {
        public CoinClass MyCoin;
        public double[][] sightHistory = new double[6][];
        public string[][] time_sight_verif = new string[6][];
        public string[][] price_Collected = new string[6][];
        public double[] priceRegister = new double[6];
        public int[] contValues = new int[6];


        public Sighter(CoinClass myCoin)
        {
            MyCoin = myCoin;
            for(int i =0; i < 5; i++)
            {
                sightHistory[i] = new double[96];
                
                contValues[i] = 0;
            }
        }


        public void ShotInSight(int cont, JObject data, CoinClass coin, int halfHour)
        {
            RegDatePrice(cont, data, coin,halfHour);


            if(coin.NextAdd(cont))
            {
                ShotInSight( cont + 1,  data,  coin, halfHour);
            }

        }

        
        private void RegDatePrice(int cont, JObject data, CoinClass coin, int halfHour)
        {
            if (String.IsNullOrEmpty(time_sight_verif[cont][0]))
            {
                time_sight_verif[cont][0] = data["data"]["quote"]["USD"]["last_updated"].ToString();
                price_Collected[cont][0] = data["data"]["quote"]["USD"]["price"].ToString().Replace(',', '.');
                priceRegister[cont] = Calculator(cont, coin, halfHour) * coin.actualValue;
            }
            else
            {
               
                time_sight_verif[cont][1] = data["data"]["quote"]["USD"]["last_updated"].ToString();
                price_Collected[cont][1] = data["data"]["quote"]["USD"]["price"].ToString().Replace(',', '.');
                    
                string[] Insert = new string[5];
                Insert[0] = time_sight_verif[cont][0];
                Insert[3] = time_sight_verif[cont][1];
                Insert[1] = price_Collected[cont][0].ToString().Replace(',', '.');
                Insert[4] = price_Collected[cont][1].ToString().Replace(',', '.');
                Insert[2] = priceRegister[cont].ToString().Replace(',', '.');
                    
                PgReq Request = new PgReq();

                Request.Insert_Sighter(cont, Insert);


                time_sight_verif[cont][1] =  null;
                price_Collected[cont][1] = null;
                time_sight_verif[cont][0] = null;
                price_Collected[cont][0] = null;

            }
        }

        //Return Multiplication factor for a period
        private double Calculator(int cont,CoinClass coin, int halHourCycles )
        {
            var Avgs = coin.CalcAvgVariation();
            int Ref = cont;
            int Sub = 1;
            int initFactor = 6;
            int endFactor = 6;

            double result = Math.Pow(Avgs[Ref], TimeDaysConverted(Ref , halHourCycles)) * 6;

            while ((Ref - Sub > 0) || (Ref + Sub <= 5))
            {
                if((Ref - Sub > 0))
                {
                    result = result + Math.Pow(Avgs[Ref - Sub], TimeDaysConverted(Ref - Sub, halHourCycles)) * initFactor;
                    endFactor = endFactor + initFactor;
                }
                if((Ref + Sub <= 5))
                {
                    result = result + Math.Pow(Avgs[Ref + Sub], TimeDaysConverted(Ref + Sub, halHourCycles)) * initFactor;
                    endFactor = endFactor + initFactor;
                }
                Sub++;
                initFactor--;
            }

            return result / endFactor;
        }

        //Return halfhour cycles
        private double TimeDaysConverted(int cont,int halfHour)
        {
            double[] result = new double[6];
            result[0] = halfHour * 5;
            result[1] = halfHour * 1;
            result[2] = halfHour * 1 / 6;
            result[3] = halfHour * 1 / 48 ;
            result[4] = halfHour * 1 / 336;
            result[5] = halfHour * 1 / 1344;

            return result[cont];

        }
    }
}
