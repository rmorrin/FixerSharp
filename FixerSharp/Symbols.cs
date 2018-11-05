using System.Linq;

namespace FixerSharp
{
    public static class Symbols
    {
        #region Currency Symbols

        /// <summary>
        /// United Arab Emirates Dirham
        /// </summary>
        public const string AED = "AED";

        /// <summary>
        /// Afghan Afghani
        /// </summary>
        public const string AFN = "AFN";

        /// <summary>
        /// Albanian Lek
        /// </summary>
        public const string ALL = "ALL";

        /// <summary>
        /// Armenian Dram
        /// </summary>
        public const string AMD = "AMD";

        /// <summary>
        /// Netherlands Antillean Guilder
        /// </summary>
        public const string ANG = "ANG";

        /// <summary>
        /// Angolan Kwanza
        /// </summary>
        public const string AOA = "AOA";

        /// <summary>
        /// Argentine Peso
        /// </summary>
        public const string ARS = "ARS";

        /// <summary>
        /// Australian Dollar
        /// </summary>
        public const string AUD = "AUD";

        /// <summary>
        /// Aruban Florin
        /// </summary>
        public const string AWG = "AWG";

        /// <summary>
        /// Azerbaijani Manat
        /// </summary>
        public const string AZN = "AZN";

        /// <summary>
        /// Bosnia-Herzegovina Convertible Mark
        /// </summary>
        public const string BAM = "BAM";

        /// <summary>
        /// Barbadian Dollar
        /// </summary>
        public const string BBD = "BBD";

        /// <summary>
        /// Bangladeshi Taka
        /// </summary>
        public const string BDT = "BDT";

        /// <summary>
        /// Bulgarian Lev
        /// </summary>
        public const string BGN = "BGN";

        /// <summary>
        /// Bahraini Dinar
        /// </summary>
        public const string BHD = "BHD";

        /// <summary>
        /// Burundian Franc
        /// </summary>
        public const string BIF = "BIF";

        /// <summary>
        /// Bermudan Dollar
        /// </summary>
        public const string BMD = "BMD";

        /// <summary>
        /// Brunei Dollar
        /// </summary>
        public const string BND = "BND";

        /// <summary>
        /// Bolivian Boliviano
        /// </summary>
        public const string BOB = "BOB";

        /// <summary>
        /// Brazilian Real
        /// </summary>
        public const string BRL = "BRL";

        /// <summary>
        /// Bahamian Dollar
        /// </summary>
        public const string BSD = "BSD";

        /// <summary>
        /// Bitcoin
        /// </summary>
        public const string BTC = "BTC";

        /// <summary>
        /// Bhutanese Ngultrum
        /// </summary>
        public const string BTN = "BTN";

        /// <summary>
        /// Botswanan Pula
        /// </summary>
        public const string BWP = "BWP";

        /// <summary>
        /// New Belarusian Ruble
        /// </summary>
        public const string BYN = "BYN";

        /// <summary>
        /// Belarusian Ruble
        /// </summary>
        public const string BYR = "BYR";

        /// <summary>
        /// Belize Dollar
        /// </summary>
        public const string BZD = "BZD";

        /// <summary>
        /// Canadian Dollar
        /// </summary>
        public const string CAD = "CAD";

        /// <summary>
        /// Congolese Franc
        /// </summary>
        public const string CDF = "CDF";

        /// <summary>
        /// Swiss Franc
        /// </summary>
        public const string CHF = "CHF";

        /// <summary>
        /// Chilean Unit of Account (UF)
        /// </summary>
        public const string CLF = "CLF";

        /// <summary>
        /// Chilean Peso
        /// </summary>
        public const string CLP = "CLP";

        /// <summary>
        /// Chinese Yuan
        /// </summary>
        public const string CNY = "CNY";

        /// <summary>
        /// Colombian Peso
        /// </summary>
        public const string COP = "COP";

        /// <summary>
        /// Costa Rican Colón
        /// </summary>
        public const string CRC = "CRC";

        /// <summary>
        /// Cuban Convertible Peso
        /// </summary>
        public const string CUC = "CUC";

        /// <summary>
        /// Cuban Peso
        /// </summary>
        public const string CUP = "CUP";

        /// <summary>
        /// Cape Verdean Escudo
        /// </summary>
        public const string CVE = "CVE";

        /// <summary>
        /// Czech Republic Koruna
        /// </summary>
        public const string CZK = "CZK";

        /// <summary>
        /// Djiboutian Franc
        /// </summary>
        public const string DJF = "DJF";

        /// <summary>
        /// Danish Krone
        /// </summary>
        public const string DKK = "DKK";

        /// <summary>
        /// Dominican Peso
        /// </summary>
        public const string DOP = "DOP";

        /// <summary>
        /// Algerian Dinar
        /// </summary>
        public const string DZD = "DZD";

        /// <summary>
        /// Egyptian Pound
        /// </summary>
        public const string EGP = "EGP";

        /// <summary>
        /// Eritrean Nakfa
        /// </summary>
        public const string ERN = "ERN";

        /// <summary>
        /// Ethiopian Birr
        /// </summary>
        public const string ETB = "ETB";

        /// <summary>
        /// Euro
        /// </summary>
        public const string EUR = "EUR";

        /// <summary>
        /// Fijian Dollar
        /// </summary>
        public const string FJD = "FJD";

        /// <summary>
        /// Falkland Islands Pound
        /// </summary>
        public const string FKP = "FKP";

        /// <summary>
        /// British Pound Sterling
        /// </summary>
        public const string GBP = "GBP";

        /// <summary>
        /// Georgian Lari
        /// </summary>
        public const string GEL = "GEL";

        /// <summary>
        /// Guernsey Pound
        /// </summary>
        public const string GGP = "GGP";

        /// <summary>
        /// Ghanaian Cedi
        /// </summary>
        public const string GHS = "GHS";

        /// <summary>
        /// Gibraltar Pound
        /// </summary>
        public const string GIP = "GIP";

        /// <summary>
        /// Gambian Dalasi
        /// </summary>
        public const string GMD = "GMD";

        /// <summary>
        /// Guinean Franc
        /// </summary>
        public const string GNF = "GNF";

        /// <summary>
        /// Guatemalan Quetzal
        /// </summary>
        public const string GTQ = "GTQ";

        /// <summary>
        /// Guyanaese Dollar
        /// </summary>
        public const string GYD = "GYD";

        /// <summary>
        /// Hong Kong Dollar
        /// </summary>
        public const string HKD = "HKD";

        /// <summary>
        /// Honduran Lempira
        /// </summary>
        public const string HNL = "HNL";

        /// <summary>
        /// Croatian Kuna
        /// </summary>
        public const string HRK = "HRK";

        /// <summary>
        /// Haitian Gourde
        /// </summary>
        public const string HTG = "HTG";

        /// <summary>
        /// Hungarian Forint
        /// </summary>
        public const string HUF = "HUF";

        /// <summary>
        /// Indonesian Rupiah
        /// </summary>
        public const string IDR = "IDR";

        /// <summary>
        /// Israeli New Sheqel
        /// </summary>
        public const string ILS = "ILS";

        /// <summary>
        /// Manx pound
        /// </summary>
        public const string IMP = "IMP";

        /// <summary>
        /// Indian Rupee
        /// </summary>
        public const string INR = "INR";

        /// <summary>
        /// Iraqi Dinar
        /// </summary>
        public const string IQD = "IQD";

        /// <summary>
        /// Iranian Rial
        /// </summary>
        public const string IRR = "IRR";

        /// <summary>
        /// Icelandic Króna
        /// </summary>
        public const string ISK = "ISK";

        /// <summary>
        /// Jersey Pound
        /// </summary>
        public const string JEP = "JEP";

        /// <summary>
        /// Jamaican Dollar
        /// </summary>
        public const string JMD = "JMD";

        /// <summary>
        /// Jordanian Dinar
        /// </summary>
        public const string JOD = "JOD";

        /// <summary>
        /// Japanese Yen
        /// </summary>
        public const string JPY = "JPY";

        /// <summary>
        /// Kenyan Shilling
        /// </summary>
        public const string KES = "KES";

        /// <summary>
        /// Kyrgystani Som
        /// </summary>
        public const string KGS = "KGS";

        /// <summary>
        /// Cambodian Riel
        /// </summary>
        public const string KHR = "KHR";

        /// <summary>
        /// Comorian Franc
        /// </summary>
        public const string KMF = "KMF";

        /// <summary>
        /// North Korean Won
        /// </summary>
        public const string KPW = "KPW";

        /// <summary>
        /// South Korean Won
        /// </summary>
        public const string KRW = "KRW";

        /// <summary>
        /// Kuwaiti Dinar
        /// </summary>
        public const string KWD = "KWD";

        /// <summary>
        /// Cayman Islands Dollar
        /// </summary>
        public const string KYD = "KYD";

        /// <summary>
        /// Kazakhstani Tenge
        /// </summary>
        public const string KZT = "KZT";

        /// <summary>
        /// Laotian Kip
        /// </summary>
        public const string LAK = "LAK";

        /// <summary>
        /// Lebanese Pound
        /// </summary>
        public const string LBP = "LBP";

        /// <summary>
        /// Sri Lankan Rupee
        /// </summary>
        public const string LKR = "LKR";

        /// <summary>
        /// Liberian Dollar
        /// </summary>
        public const string LRD = "LRD";

        /// <summary>
        /// Lesotho Loti
        /// </summary>
        public const string LSL = "LSL";

        /// <summary>
        /// Lithuanian Litas
        /// </summary>
        public const string LTL = "LTL";

        /// <summary>
        /// Latvian Lats
        /// </summary>
        public const string LVL = "LVL";

        /// <summary>
        /// Libyan Dinar
        /// </summary>
        public const string LYD = "LYD";

        /// <summary>
        /// Moroccan Dirham
        /// </summary>
        public const string MAD = "MAD";

        /// <summary>
        /// Moldovan Leu
        /// </summary>
        public const string MDL = "MDL";

        /// <summary>
        /// Malagasy Ariary
        /// </summary>
        public const string MGA = "MGA";

        /// <summary>
        /// Macedonian Denar
        /// </summary>
        public const string MKD = "MKD";

        /// <summary>
        /// Myanma Kyat
        /// </summary>
        public const string MMK = "MMK";

        /// <summary>
        /// Mongolian Tugrik
        /// </summary>
        public const string MNT = "MNT";

        /// <summary>
        /// Macanese Pataca
        /// </summary>
        public const string MOP = "MOP";

        /// <summary>
        /// Mauritanian Ouguiya
        /// </summary>
        public const string MRO = "MRO";

        /// <summary>
        /// Mauritian Rupee
        /// </summary>
        public const string MUR = "MUR";

        /// <summary>
        /// Maldivian Rufiyaa
        /// </summary>
        public const string MVR = "MVR";

        /// <summary>
        /// Malawian Kwacha
        /// </summary>
        public const string MWK = "MWK";

        /// <summary>
        /// Mexican Peso
        /// </summary>
        public const string MXN = "MXN";

        /// <summary>
        /// Malaysian Ringgit
        /// </summary>
        public const string MYR = "MYR";

        /// <summary>
        /// Mozambican Metical
        /// </summary>
        public const string MZN = "MZN";

        /// <summary>
        /// Namibian Dollar
        /// </summary>
        public const string NAD = "NAD";

        /// <summary>
        /// Nigerian Naira
        /// </summary>
        public const string NGN = "NGN";

        /// <summary>
        /// Nicaraguan Córdoba
        /// </summary>
        public const string NIO = "NIO";

        /// <summary>
        /// Norwegian Krone
        /// </summary>
        public const string NOK = "NOK";

        /// <summary>
        /// Nepalese Rupee
        /// </summary>
        public const string NPR = "NPR";

        /// <summary>
        /// New Zealand Dollar
        /// </summary>
        public const string NZD = "NZD";

        /// <summary>
        /// Omani Rial
        /// </summary>
        public const string OMR = "OMR";

        /// <summary>
        /// Panamanian Balboa
        /// </summary>
        public const string PAB = "PAB";

        /// <summary>
        /// Peruvian Nuevo Sol
        /// </summary>
        public const string PEN = "PEN";

        /// <summary>
        /// Papua New Guinean Kina
        /// </summary>
        public const string PGK = "PGK";

        /// <summary>
        /// Philippine Peso
        /// </summary>
        public const string PHP = "PHP";

        /// <summary>
        /// Pakistani Rupee
        /// </summary>
        public const string PKR = "PKR";

        /// <summary>
        /// Polish Zloty
        /// </summary>
        public const string PLN = "PLN";

        /// <summary>
        /// Paraguayan Guarani
        /// </summary>
        public const string PYG = "PYG";

        /// <summary>
        /// Qatari Rial
        /// </summary>
        public const string QAR = "QAR";

        /// <summary>
        /// Romanian Leu
        /// </summary>
        public const string RON = "RON";

        /// <summary>
        /// Serbian Dinar
        /// </summary>
        public const string RSD = "RSD";

        /// <summary>
        /// Russian Ruble
        /// </summary>
        public const string RUB = "RUB";

        /// <summary>
        /// Rwandan Franc
        /// </summary>
        public const string RWF = "RWF";

        /// <summary>
        /// Saudi Riyal
        /// </summary>
        public const string SAR = "SAR";

        /// <summary>
        /// Solomon Islands Dollar
        /// </summary>
        public const string SBD = "SBD";

        /// <summary>
        /// Seychellois Rupee
        /// </summary>
        public const string SCR = "SCR";

        /// <summary>
        /// Sudanese Pound
        /// </summary>
        public const string SDG = "SDG";

        /// <summary>
        /// Swedish Krona
        /// </summary>
        public const string SEK = "SEK";

        /// <summary>
        /// Singapore Dollar
        /// </summary>
        public const string SGD = "SGD";

        /// <summary>
        /// Saint Helena Pound
        /// </summary>
        public const string SHP = "SHP";

        /// <summary>
        /// Sierra Leonean Leone
        /// </summary>
        public const string SLL = "SLL";

        /// <summary>
        /// Somali Shilling
        /// </summary>
        public const string SOS = "SOS";

        /// <summary>
        /// Surinamese Dollar
        /// </summary>
        public const string SRD = "SRD";

        /// <summary>
        /// São Tomé and Príncipe Dobra
        /// </summary>
        public const string STD = "STD";

        /// <summary>
        /// Salvadoran Colón
        /// </summary>
        public const string SVC = "SVC";

        /// <summary>
        /// Syrian Pound
        /// </summary>
        public const string SYP = "SYP";

        /// <summary>
        /// Swazi Lilangeni
        /// </summary>
        public const string SZL = "SZL";

        /// <summary>
        /// Thai Baht
        /// </summary>
        public const string THB = "THB";

        /// <summary>
        /// Tajikistani Somoni
        /// </summary>
        public const string TJS = "TJS";

        /// <summary>
        /// Turkmenistani Manat
        /// </summary>
        public const string TMT = "TMT";

        /// <summary>
        /// Tunisian Dinar
        /// </summary>
        public const string TND = "TND";

        /// <summary>
        /// Tongan Paʻanga
        /// </summary>
        public const string TOP = "TOP";

        /// <summary>
        /// Turkish Lira
        /// </summary>
        public const string TRY = "TRY";

        /// <summary>
        /// Trinidad and Tobago Dollar
        /// </summary>
        public const string TTD = "TTD";

        /// <summary>
        /// New Taiwan Dollar
        /// </summary>
        public const string TWD = "TWD";

        /// <summary>
        /// Tanzanian Shilling
        /// </summary>
        public const string TZS = "TZS";

        /// <summary>
        /// Ukrainian Hryvnia
        /// </summary>
        public const string UAH = "UAH";

        /// <summary>
        /// Ugandan Shilling
        /// </summary>
        public const string UGX = "UGX";

        /// <summary>
        /// United States Dollar
        /// </summary>
        public const string USD = "USD";

        /// <summary>
        /// Uruguayan Peso
        /// </summary>
        public const string UYU = "UYU";

        /// <summary>
        /// Uzbekistan Som
        /// </summary>
        public const string UZS = "UZS";

        /// <summary>
        /// Venezuelan Bolívar Fuerte
        /// </summary>
        public const string VEF = "VEF";

        /// <summary>
        /// Vietnamese Dong
        /// </summary>
        public const string VND = "VND";

        /// <summary>
        /// Vanuatu Vatu
        /// </summary>
        public const string VUV = "VUV";

        /// <summary>
        /// Samoan Tala
        /// </summary>
        public const string WST = "WST";

        /// <summary>
        /// CFA Franc BEAC
        /// </summary>
        public const string XAF = "XAF";

        /// <summary>
        /// Silver (troy ounce)
        /// </summary>
        public const string XAG = "XAG";

        /// <summary>
        /// Gold (troy ounce)
        /// </summary>
        public const string XAU = "XAU";

        /// <summary>
        /// East Caribbean Dollar
        /// </summary>
        public const string XCD = "XCD";

        /// <summary>
        /// Special Drawing Rights
        /// </summary>
        public const string XDR = "XDR";

        /// <summary>
        /// CFA Franc BCEAO
        /// </summary>
        public const string XOF = "XOF";

        /// <summary>
        /// CFP Franc
        /// </summary>
        public const string XPF = "XPF";

        /// <summary>
        /// Yemeni Rial
        /// </summary>
        public const string YER = "YER";

        /// <summary>
        /// South African Rand
        /// </summary>
        public const string ZAR = "ZAR";

        /// <summary>
        /// Zambian Kwacha (pre-2013)
        /// </summary>
        public const string ZMK = "ZMK";

        /// <summary>
        /// Zambian Kwacha
        /// </summary>
        public const string ZMW = "ZMW";

        /// <summary>
        /// Zimbabwean Dollar
        /// </summary>
        public const string ZWL = "ZWL";

        #endregion

        public static bool IsValid(string symbol)
        {
            return ValidSymbols.Contains(symbol);
        }

        private static string[] ValidSymbols = new string[]
        {
            #region Currency Symbols

            AED,
            AFN,
            ALL,
            AMD,
            ANG,
            AOA,
            ARS,
            AUD,
            AWG,
            AZN,
            BAM,
            BBD,
            BDT,
            BGN,
            BHD,
            BIF,
            BMD,
            BND,
            BOB,
            BRL,
            BSD,
            BTC,
            BTN,
            BWP,
            BYN,
            BYR,
            BZD,
            CAD,
            CDF,
            CHF,
            CLF,
            CLP,
            CNY,
            COP,
            CRC,
            CUC,
            CUP,
            CVE,
            CZK,
            DJF,
            DKK,
            DOP,
            DZD,
            EGP,
            ERN,
            ETB,
            EUR,
            FJD,
            FKP,
            GBP,
            GEL,
            GGP,
            GHS,
            GIP,
            GMD,
            GNF,
            GTQ,
            GYD,
            HKD,
            HNL,
            HRK,
            HTG,
            HUF,
            IDR,
            ILS,
            IMP,
            INR,
            IQD,
            IRR,
            ISK,
            JEP,
            JMD,
            JOD,
            JPY,
            KES,
            KGS,
            KHR,
            KMF,
            KPW,
            KRW,
            KWD,
            KYD,
            KZT,
            LAK,
            LBP,
            LKR,
            LRD,
            LSL,
            LTL,
            LVL,
            LYD,
            MAD,
            MDL,
            MGA,
            MKD,
            MMK,
            MNT,
            MOP,
            MRO,
            MUR,
            MVR,
            MWK,
            MXN,
            MYR,
            MZN,
            NAD,
            NGN,
            NIO,
            NOK,
            NPR,
            NZD,
            OMR,
            PAB,
            PEN,
            PGK,
            PHP,
            PKR,
            PLN,
            PYG,
            QAR,
            RON,
            RSD,
            RUB,
            RWF,
            SAR,
            SBD,
            SCR,
            SDG,
            SEK,
            SGD,
            SHP,
            SLL,
            SOS,
            SRD,
            STD,
            SVC,
            SYP,
            SZL,
            THB,
            TJS,
            TMT,
            TND,
            TOP,
            TRY,
            TTD,
            TWD,
            TZS,
            UAH,
            UGX,
            USD,
            UYU,
            UZS,
            VEF,
            VND,
            VUV,
            WST,
            XAF,
            XAG,
            XAU,
            XCD,
            XDR,
            XOF,
            XPF,
            YER,
            ZAR,
            ZMK,
            ZMW,
            ZWL

            #endregion
        };
    }
}
