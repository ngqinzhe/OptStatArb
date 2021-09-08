using System;
using System.Collections.Generic;

namespace OptionsAPI
{
    public class OptionsModel
    {
        public OptionChain optionChain { get; set; }
    }

    public class OptionChain
    {
        public IEnumerable<Result> result { get; set; }
    }

    public class Result
    {
        public IEnumerable<Options> options { get; set; }
    }

    public class Options
    {
        public IEnumerable<Calls> calls { get; set; }
        public IEnumerable<Puts> puts { get; set; }
    }

    public class Calls
    {
        public decimal Strike { get; set; }
        public decimal LastPrice { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
        public int Expiration { get; set; }
        public decimal ImpliedVolatility { get; set; }
    }

    public class Puts
    {
        public decimal Strike { get; set; }
        public decimal LastPrice { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
        public int Expiration { get; set; }
        public decimal ImpliedVolatility { get; set; }
    }


}
