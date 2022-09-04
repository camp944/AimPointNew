using System;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;
using Coin;


namespace ApiCoinMarketCap
{

    public class Api
    {
 
        public JObject makeAPICall(CoinClass moeda)
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/tools/price-conversion");

            var queryString = HttpUtility.ParseQueryString(string.Empty);

            queryString["amount"] = "1";
            queryString["symbol"] = moeda.symbol;
            queryString["convert"] = moeda.convert;


            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", "f823816c-3ba2-4b6a-9733-315540b882ee");
            client.Headers.Add("Accepts", "application/json");

            JObject Result = JObject.Parse(client.DownloadString(URL.ToString()));
            return Result;

        }
    }
}
