using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeLibrary.Models
{
    public class ConversionRate
    { 
        public double AED { get; set; }
        public double AFN {get; set;}
        public double ALL {get; set;}
        public double AMD {get; set;}
        public double ANG {get; set;}
        public double AOA {get; set;}
        public double ARS {get; set;}
        public double AUD {get; set;}
        public double AWG {get; set;}
        public double AZN {get; set;}
        public double BAM {get; set;}
        public double BBD {get; set;}
        public double BDT {get; set;}
        public double BGN {get; set;}
        public double BHD {get; set;}
        public double BIF {get; set;}
        public double BMD {get; set;}
        public double BND {get; set;}
        public double BOB {get; set;}
        public double BRL {get; set;}
        public double BSD {get; set;}
        public double BTN {get; set;}
        public double BWP {get; set;}
        public double BYN {get; set;}
        public double BZD {get; set;}
        public double CAD {get; set;}
        public double CDF {get; set;}
        public double CHF {get; set;}
        public double CLP {get; set;}
        public double CNY {get; set;}
        public double COP {get; set;}
        public double CRC {get; set;}
        public double CUP {get; set;}
        public double CVE {get; set;}
        public double CZK {get; set;}
        public double DJF {get; set;}
        public double DKK {get; set;}
        public double DOP {get; set;}
        public double DZD {get; set;}
        public double EGP {get; set;}
        public double ERN {get; set;}
        public double ETB {get; set;}
        public double EUR {get; set;}
        public double FJD {get; set;}
        public double FKP {get; set;}
        public double FOK {get; set;}
        public double GBP {get; set;}
        public double GEL {get; set;}
        public double GGP {get; set;}
        public double GHS {get; set;}
        public double GIP {get; set;}
        public double GMD {get; set;}
        public double GNF {get; set;}
        public double GTQ {get; set;}
        public double GYD {get; set;}
        public double HKD {get; set;}
        public double HNL {get; set;}
        public double HRK {get; set;}
        public double HTG {get; set;}
        public double HUF {get; set;}
        public double IDR {get; set;}
        public double ILS {get; set;}
        public double IMP {get; set;}
        public double INR {get; set;}
        public double IQD {get; set;}
        public double IRR {get; set;}
        public double ISK {get; set;}
        public double JEP {get; set;}
        public double JMD {get; set;}
        public double JOD {get; set;}
        public double JPY {get; set;}
        public double KES {get; set;}
        public double KGS {get; set;}
        public double KHR {get; set;}
        public double KID {get; set;}
        public double KMF {get; set;}
        public double KRW {get; set;}
        public double KWD {get; set;}
        public double KYD {get; set;}
        public double KZT {get; set;}
        public double LAK {get; set;}
        public double LBP {get; set;}
        public double LKR {get; set;}
        public double LRD {get; set;}
        public double LSL {get; set;}
        public double LYD {get; set;}
        public double MAD {get; set;}
        public double MDL {get; set;}
        public double MGA {get; set;}
        public double MKD {get; set;}
        public double MMK {get; set;}
        public double MNT {get; set;}
        public double MOP {get; set;}
        public double MRU {get; set;}
        public double MUR {get; set;}
        public double MVR {get; set;}
        public double MWK {get; set;}
        public double MXN {get; set;}
        public double MYR {get; set;}
        public double MZN {get; set;}
        public double NAD {get; set;}
        public double NGN {get; set;}
        public double NIO {get; set;}
        public double NOK {get; set;}
        public double NPR {get; set;}
        public double NZD {get; set;}
        public double OMR {get; set;}
        public double PAB {get; set;}
        public double PEN {get; set;}
        public double PGK {get; set;}
        public double PHP {get; set;}
        public double PKR {get; set;}
        public double PLN {get; set;}
        public double PYG {get; set;}
        public double QAR {get; set;}
        public double RON {get; set;}
        public double RSD {get; set;}
        public double RUB {get; set;}
        public double RWF {get; set;}
        public double SAR {get; set;}
        public double SBD {get; set;}
        public double SCR {get; set;}
        public double SDG {get; set;}
        public double SEK {get; set;}
        public double SGD {get; set;}
        public double SHP {get; set;}
        public double SLE {get; set;}
        public double SOS {get; set;}
        public double SRD {get; set;}
        public double SSP {get; set;}
        public double STN {get; set;}
        public double SYP {get; set;}
        public double SZL {get; set;}
        public double THB {get; set;}
        public double TJS {get; set;}
        public double TMT {get; set;}
        public double TND {get; set;}
        public double TOP {get; set;}
        public double TRY {get; set;}
        public double TTD {get; set;}
        public double TVD {get; set;}
        public double TWD {get; set;}
        public double TZS {get; set;}
        public double UAH {get; set;}
        public double UGX {get; set;}
        public double USD {get; set;}
        public double UYU {get; set;}
        public double UZS {get; set;}
        public double VES {get; set;}
        public double VND {get; set;}
        public double VUV {get; set;}
        public double WST {get; set;}
        public double XAF {get; set;}
        public double XCD {get; set;}
        public double XDR {get; set;}
        public double XOF {get; set;}
        public double XPF {get; set;}
        public double YER {get; set;}
        public double ZAR {get; set;}
        public double ZMW {get; set;}
        public double ZWL {get; set;}

        public override string ToString()
        {
            return $"{nameof(AED)}: {AED}, {nameof(AFN)}: {AFN}, {nameof(ALL)}: {ALL}, {nameof(AMD)}: {AMD}, {nameof(ANG)}: {ANG}, {nameof(AOA)}: {AOA}, {nameof(ARS)}: {ARS}, {nameof(AUD)}: {AUD}, {nameof(AWG)}: {AWG}, {nameof(AZN)}: {AZN}, {nameof(BAM)}: {BAM}, {nameof(BBD)}: {BBD}, {nameof(BDT)}: {BDT}, {nameof(BGN)}: {BGN}, {nameof(BHD)}: {BHD}, {nameof(BIF)}: {BIF}, {nameof(BMD)}: {BMD}, {nameof(BND)}: {BND}, {nameof(BOB)}: {BOB}, {nameof(BRL)}: {BRL}, {nameof(BSD)}: {BSD}, {nameof(BTN)}: {BTN}, {nameof(BWP)}: {BWP}, {nameof(BYN)}: {BYN}, {nameof(BZD)}: {BZD}, {nameof(CAD)}: {CAD}, {nameof(CDF)}: {CDF}, {nameof(CHF)}: {CHF}, {nameof(CLP)}: {CLP}, {nameof(CNY)}: {CNY}, {nameof(COP)}: {COP}, {nameof(CRC)}: {CRC}, {nameof(CUP)}: {CUP}, {nameof(CVE)}: {CVE}, {nameof(CZK)}: {CZK}, {nameof(DJF)}: {DJF}, {nameof(DKK)}: {DKK}, {nameof(DOP)}: {DOP}, {nameof(DZD)}: {DZD}, {nameof(EGP)}: {EGP}, {nameof(ERN)}: {ERN}, {nameof(ETB)}: {ETB}, {nameof(EUR)}: {EUR}, {nameof(FJD)}: {FJD}, {nameof(FKP)}: {FKP}, {nameof(FOK)}: {FOK}, {nameof(GBP)}: {GBP}, {nameof(GEL)}: {GEL}, {nameof(GGP)}: {GGP}, {nameof(GHS)}: {GHS}, {nameof(GIP)}: {GIP}, {nameof(GMD)}: {GMD}, {nameof(GNF)}: {GNF}, {nameof(GTQ)}: {GTQ}, {nameof(GYD)}: {GYD}, {nameof(HKD)}: {HKD}, {nameof(HNL)}: {HNL}, {nameof(HRK)}: {HRK}, {nameof(HTG)}: {HTG}, {nameof(HUF)}: {HUF}, {nameof(IDR)}: {IDR}, {nameof(ILS)}: {ILS}, {nameof(IMP)}: {IMP}, {nameof(INR)}: {INR}, {nameof(IQD)}: {IQD}, {nameof(IRR)}: {IRR}, {nameof(ISK)}: {ISK}, {nameof(JEP)}: {JEP}, {nameof(JMD)}: {JMD}, {nameof(JOD)}: {JOD}, {nameof(JPY)}: {JPY}, {nameof(KES)}: {KES}, {nameof(KGS)}: {KGS}, {nameof(KHR)}: {KHR}, {nameof(KID)}: {KID}, {nameof(KMF)}: {KMF}, {nameof(KRW)}: {KRW}, {nameof(KWD)}: {KWD}, {nameof(KYD)}: {KYD}, {nameof(KZT)}: {KZT}, {nameof(LAK)}: {LAK}, {nameof(LBP)}: {LBP}, {nameof(LKR)}: {LKR}, {nameof(LRD)}: {LRD}, {nameof(LSL)}: {LSL}, {nameof(LYD)}: {LYD}, {nameof(MAD)}: {MAD}, {nameof(MDL)}: {MDL}, {nameof(MGA)}: {MGA}, {nameof(MKD)}: {MKD}, {nameof(MMK)}: {MMK}, {nameof(MNT)}: {MNT}, {nameof(MOP)}: {MOP}, {nameof(MRU)}: {MRU}, {nameof(MUR)}: {MUR}, {nameof(MVR)}: {MVR}, {nameof(MWK)}: {MWK}, {nameof(MXN)}: {MXN}, {nameof(MYR)}: {MYR}, {nameof(MZN)}: {MZN}, {nameof(NAD)}: {NAD}, {nameof(NGN)}: {NGN}, {nameof(NIO)}: {NIO}, {nameof(NOK)}: {NOK}, {nameof(NPR)}: {NPR}, {nameof(NZD)}: {NZD}, {nameof(OMR)}: {OMR}, {nameof(PAB)}: {PAB}, {nameof(PEN)}: {PEN}, {nameof(PGK)}: {PGK}, {nameof(PHP)}: {PHP}, {nameof(PKR)}: {PKR}, {nameof(PLN)}: {PLN}, {nameof(PYG)}: {PYG}, {nameof(QAR)}: {QAR}, {nameof(RON)}: {RON}, {nameof(RSD)}: {RSD}, {nameof(RUB)}: {RUB}, {nameof(RWF)}: {RWF}, {nameof(SAR)}: {SAR}, {nameof(SBD)}: {SBD}, {nameof(SCR)}: {SCR}, {nameof(SDG)}: {SDG}, {nameof(SEK)}: {SEK}, {nameof(SGD)}: {SGD}, {nameof(SHP)}: {SHP}, {nameof(SLE)}: {SLE}, {nameof(SOS)}: {SOS}, {nameof(SRD)}: {SRD}, {nameof(SSP)}: {SSP}, {nameof(STN)}: {STN}, {nameof(SYP)}: {SYP}, {nameof(SZL)}: {SZL}, {nameof(THB)}: {THB}, {nameof(TJS)}: {TJS}, {nameof(TMT)}: {TMT}, {nameof(TND)}: {TND}, {nameof(TOP)}: {TOP}, {nameof(TRY)}: {TRY}, {nameof(TTD)}: {TTD}, {nameof(TVD)}: {TVD}, {nameof(TWD)}: {TWD}, {nameof(TZS)}: {TZS}, {nameof(UAH)}: {UAH}, {nameof(UGX)}: {UGX}, {nameof(USD)}: {USD}, {nameof(UYU)}: {UYU}, {nameof(UZS)}: {UZS}, {nameof(VES)}: {VES}, {nameof(VND)}: {VND}, {nameof(VUV)}: {VUV}, {nameof(WST)}: {WST}, {nameof(XAF)}: {XAF}, {nameof(XCD)}: {XCD}, {nameof(XDR)}: {XDR}, {nameof(XOF)}: {XOF}, {nameof(XPF)}: {XPF}, {nameof(YER)}: {YER}, {nameof(ZAR)}: {ZAR}, {nameof(ZMW)}: {ZMW}, {nameof(ZWL)}: {ZWL}";
        }
    }
}
