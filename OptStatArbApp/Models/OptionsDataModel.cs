using System;
using System.Collections.Generic;

namespace OptStatArbApp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Quote
    {
        public string language { get; set; }
        public string region { get; set; }
        public string quoteType { get; set; }
        public string quoteSourceName { get; set; }
        public bool triggerable { get; set; }
        public string currency { get; set; }
        public string shortName { get; set; }
        public string exchange { get; set; }
        public string longName { get; set; }
        public string messageBoardId { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public int gmtOffSetMilliseconds { get; set; }
        public string market { get; set; }
        public bool esgPopulated { get; set; }
        public string marketState { get; set; }
        public long firstTradeDateMilliseconds { get; set; }
        public int priceHint { get; set; }
        public double preMarketChange { get; set; }
        public double preMarketChangePercent { get; set; }
        public int preMarketTime { get; set; }
        public double preMarketPrice { get; set; }
        public double regularMarketChange { get; set; }
        public double regularMarketChangePercent { get; set; }
        public int regularMarketTime { get; set; }
        public double regularMarketPrice { get; set; }
        public double regularMarketDayHigh { get; set; }
        public string regularMarketDayRange { get; set; }
        public double regularMarketDayLow { get; set; }
        public int regularMarketVolume { get; set; }
        public double regularMarketPreviousClose { get; set; }
        public double bid { get; set; }
        public double ask { get; set; }
        public int bidSize { get; set; }
        public int askSize { get; set; }
        public string fullExchangeName { get; set; }
        public string financialCurrency { get; set; }
        public double regularMarketOpen { get; set; }
        public int averageDailyVolume3Month { get; set; }
        public int averageDailyVolume10Day { get; set; }
        public double fiftyTwoWeekLowChange { get; set; }
        public double fiftyTwoWeekLowChangePercent { get; set; }
        public string fiftyTwoWeekRange { get; set; }
        public double fiftyTwoWeekHighChange { get; set; }
        public double fiftyTwoWeekHighChangePercent { get; set; }
        public double fiftyTwoWeekLow { get; set; }
        public double fiftyTwoWeekHigh { get; set; }
        public int earningsTimestamp { get; set; }
        public int earningsTimestampStart { get; set; }
        public int earningsTimestampEnd { get; set; }
        public double trailingPE { get; set; }
        public double epsTrailingTwelveMonths { get; set; }
        public double epsForward { get; set; }
        public double epsCurrentYear { get; set; }
        public double priceEpsCurrentYear { get; set; }
        public int sharesOutstanding { get; set; }
        public double bookValue { get; set; }
        public double fiftyDayAverage { get; set; }
        public double fiftyDayAverageChange { get; set; }
        public double fiftyDayAverageChangePercent { get; set; }
        public double twoHundredDayAverage { get; set; }
        public double twoHundredDayAverageChange { get; set; }
        public double twoHundredDayAverageChangePercent { get; set; }
        public long marketCap { get; set; }
        public double forwardPE { get; set; }
        public double priceToBook { get; set; }
        public int sourceInterval { get; set; }
        public int exchangeDataDelayedBy { get; set; }
        public string averageAnalystRating { get; set; }
        public bool tradeable { get; set; }
        public string displayName { get; set; }
        public string symbol { get; set; }
    }

    public class Call
    {
        public string contractSymbol { get; set; }
        public double strike { get; set; }
        public string currency { get; set; }
        public double lastPrice { get; set; }
        public double change { get; set; }
        public double percentChange { get; set; }
        public int openInterest { get; set; }
        public double bid { get; set; }
        public double ask { get; set; }
        public string contractSize { get; set; }
        public int expiration { get; set; }
        public int lastTradeDate { get; set; }
        public double impliedVolatility { get; set; }
        public bool inTheMoney { get; set; }
        public int? volume { get; set; }
    }

    public class Put
    {
        public string contractSymbol { get; set; }
        public double strike { get; set; }
        public string currency { get; set; }
        public double lastPrice { get; set; }
        public double change { get; set; }
        public double percentChange { get; set; }
        public int volume { get; set; }
        public int openInterest { get; set; }
        public double bid { get; set; }
        public double ask { get; set; }
        public string contractSize { get; set; }
        public int expiration { get; set; }
        public int lastTradeDate { get; set; }
        public double impliedVolatility { get; set; }
        public bool inTheMoney { get; set; }
    }

    public class Option
    {
        public int expirationDate { get; set; }
        public bool hasMiniOptions { get; set; }
        public List<Call> calls { get; set; }
        public List<Put> puts { get; set; }
    }

    public class Result
    {
        public string underlyingSymbol { get; set; }
        public List<int> expirationDates { get; set; }
        public List<double> strikes { get; set; }
        public bool hasMiniOptions { get; set; }
        public Quote quote { get; set; }
        public List<Option> options { get; set; }
    }

    public class OptionChain
    {
        public List<Result> result { get; set; }
        public object error { get; set; }
    }

    public class OptionsDataModel
    {
        public OptionChain optionChain { get; set; }
    }


}
