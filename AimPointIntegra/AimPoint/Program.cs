using System;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;
using Coin;
using ApiCoinMarketCap;
using System.Threading;
using Pointer;


namespace Program
{


    class Program
    {
        public static void Main(string[] args)
        {
            int cont_tempo = 0;
            Api Caller = new Api();
            CoinClass coin = new CoinClass("bitcoin","BTC","USD");
            Sighter sighter = new Sighter(coin);

           while(true)
            {
                try
                {

                    JObject data = Caller.makeAPICall(coin);
                    
                    coin.actualValue = Double.Parse(data["data"]["quote"]["USD"]["price"].ToString());
                    coin.AddValue(0, data);


                    if (cont_tempo > 240)
                    {
                        //FALTA CRIAR O BANCO
                        //sighter.ShotInSight(0, data, coin, 1);

                    }
                    

                    Thread.Sleep(360000);
                }
                catch (WebException e)
                {
                    Console.WriteLine(e.Message);
                }
                cont_tempo++;
            }
        }
    }
}
