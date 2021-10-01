using System;
using System.Collections.Generic;
using System.Text;

namespace RareCrew.Integration.Alexa.BusinessObjects
{

    public class AlexaResponse
    {
        public Awis Awis { get; set; }

        public static explicit operator int(AlexaResponse v)
        {
            throw new NotImplementedException();
        }
    }

    public class Awis
    {
        public Operationrequest OperationRequest { get; set; }
        public Results Results { get; set; }
    }

    public class Operationrequest
    {
        public string RequestId { get; set; }
    }

    public class Results
    {
        public Result Result { get; set; }
        public Responsestatus ResponseStatus { get; set; }
    }

    public class Result
    {
        public Alexa Alexa { get; set; }
    }

    public class Alexa
    {
        public Request Request { get; set; }
        public Trafficdata TrafficData { get; set; }
    }

    public class Request
    {
        public Arguments Arguments { get; set; }
    }

    public class Arguments
    {
        public Argument[] Argument { get; set; }
    }

    public class Argument
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Trafficdata
    {
        public string DataUrl { get; set; }
        public string Rank { get; set; }
    }

    public class Responsestatus
    {
        public string StatusCode { get; set; }
    }

}
