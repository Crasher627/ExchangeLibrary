using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeLibrary.Models
{
    public class HistoricalRate
    { 
        public double AUD { get; set; }
        public double DKK {get;set;}
        public double IEP {get;set;}
        public double MYR {get;set;}
        public double TWD {get;set;}
        public double ATS {get;set;}
        public double ESP {get;set;}
        public double INR {get;set;}
        public double NOK {get;set;}
        public double USD {get;set;}
        public double BEF {get;set;}
        public double EUR {get;set;}
        public double IRR {get;set;}
        public double NLG {get;set;}
        public double ZAR {get;set;}
        public double BRL {get;set;}
        public double FIM {get;set;}
        public double ITL {get;set;}
        public double NZD {get;set;}
        public double CAD {get;set;}
        public double FRF {get;set;}
        public double JPY {get;set;}
        public double PTE {get;set;}
        public double CHF {get;set;}
        public double GBP {get;set;}
        public double KRW {get;set;}
        public double SEK {get;set;}
        public double CNY {get;set;}
        public double GRD {get;set;}
        public double LKR {get;set;}
        public double SGD {get;set;}
        public double DEM {get;set;}
        public double HKD {get;set;}
        public double MXN {get;set;}
        public double THB {get;set;}

        public override string ToString()
        {
            return $"{nameof(AUD)}: {AUD}, {nameof(DKK)}: {DKK}, {nameof(IEP)}: {IEP}, {nameof(MYR)}: {MYR}, {nameof(TWD)}: {TWD}, {nameof(ATS)}: {ATS}, {nameof(ESP)}: {ESP}, {nameof(INR)}: {INR}, {nameof(NOK)}: {NOK}, {nameof(USD)}: {USD}, {nameof(BEF)}: {BEF}, {nameof(EUR)}: {EUR}, {nameof(IRR)}: {IRR}, {nameof(NLG)}: {NLG}, {nameof(ZAR)}: {ZAR}, {nameof(BRL)}: {BRL}, {nameof(FIM)}: {FIM}, {nameof(ITL)}: {ITL}, {nameof(NZD)}: {NZD}, {nameof(CAD)}: {CAD}, {nameof(FRF)}: {FRF}, {nameof(JPY)}: {JPY}, {nameof(PTE)}: {PTE}, {nameof(CHF)}: {CHF}, {nameof(GBP)}: {GBP}, {nameof(KRW)}: {KRW}, {nameof(SEK)}: {SEK}, {nameof(CNY)}: {CNY}, {nameof(GRD)}: {GRD}, {nameof(LKR)}: {LKR}, {nameof(SGD)}: {SGD}, {nameof(DEM)}: {DEM}, {nameof(HKD)}: {HKD}, {nameof(MXN)}: {MXN}, {nameof(THB)}: {THB}";
        }
    }
}
