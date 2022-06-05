using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPMGCalc
{
    public enum GroundTypes
    {
        unknown,
        sands,
        sandyloam,
        loam,
        clay,
        peatSD,
        peatMD
    }

    public enum Salts
    {
        unknown,
        unsalted,
        salineMT,
        salineCT,
    }

    //структура для сериализации вводимых данных
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public struct GData
    {
        //Тип грунта:
        [JsonProperty(PropertyName = "Type")]
        public string Type;
        //Засоленность грунта:
        [JsonProperty(PropertyName = "Salt")]
        public string Salt;
        //Степень засоленности %
        [JsonProperty(PropertyName = "Dsal")]
        public int Dsal;
        //Льдистость
        [JsonProperty(PropertyName = "Itot")]
        public double Itot;
        //Суммарная влажность
        [JsonProperty(PropertyName = "Wtot")]
        public double Wtot;
        //Влажность мерзлого грунта
        [JsonProperty(PropertyName = "Wm")]
        public double Wm;

        public GData(string type, string salt, int dsal, double itot, double wtot, double wm)
        {
            Type = type;
            Salt = salt;
            Dsal = dsal;
            Itot = itot;
            Wtot = wtot;
            Wm = wm;
        }

    }

    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class FTPMGData
    {
        public const string cSands = "Пески разных фракций";
        public const string cSandyloams = "Супеси и пылеватые пески";
        public const string cLoam = "Суглинок";
        public const string cClays = "Глины";
        public const string cPeatSD = "Торф слаборазложившийся";
        public const string cPeatMD = "Торф среднеразложившийся";

        public const string cUnsalted = "незасоленный";
        public const string cSalineMT = "засоленный(морской тип)";
        public const string cSalineCT = "засоленный(континентальный тип)";


        //Тип грунта:
        private GroundTypes _Type;
        [JsonProperty(PropertyName = "Type")]
        public string Type
        {
            get
            {
                return StringType();
            }
        }
        //Засоленность грунта:
        private Salts _Salt;
        [JsonProperty(PropertyName = "Salt")]
        public string Salt
        {
            get
            {
                return StringSaltsType();
            }
        }
        //Степень засоленности %
        [JsonProperty(PropertyName = "Dsal")]
        public int Dsal { get; }
        //Льдистость
        [JsonProperty(PropertyName = "Itot")]
        public double Itot { get; }
        //Суммарная влажность
        [JsonProperty(PropertyName = "Wtot")]
        public double Wtot { get; }
        //Влажность мерзлого грунта
        [JsonProperty(PropertyName = "Wm")]
        public double Wm { get; }
        //концентрация порового раствора - , доли единицы
        public double Cbf
        {
            get
            {
                return GetCbf();
            }
        }
        [JsonProperty(PropertyName = "Tbf")]
        //емпература начала замерзания грунта
        public double Tbf
        {
            get
            {
                return GetTbf();
            }
        }

        public FTPMGData(int type, int salt, int dsal, double itot, double wtot, double wm)
        {
            SetType(type);
            SetSaltsType(salt);
            Dsal = dsal;
            Itot = itot;
            Wtot = wtot;
            Wm = wm;
        }

        public FTPMGData(string type, string salt, int dsal, double itot, double wtot, double wm)
        {
            SetType(type);
            SetSaltsType(salt);
            Dsal = dsal;
            Itot = itot;
            Wtot = wtot;
            Wm = wm;
        }
        /// <summary>
        ///температура начала замерзания грунта по формуле (Б.3).
        ///</summary>
        public double GetTbf()
        {
            double A, B;
            switch (_Salt)
            {
                case Salts.unsalted:
                    B = 0;
                    break;
                case Salts.salineMT:
                    B = 1;
                    break;
                case Salts.salineCT:
                    B = 0.85;
                    break;
                case Salts.unknown:
                default:
                    throw new Exception("Засоленность грунта не определна");

            }
            switch (_Type)
            {
                case GroundTypes.sands:
                    A = -0.10;
                    break;
                case GroundTypes.sandyloam:
                    A = -0.15;
                    break;
                case GroundTypes.loam:
                    A = -0.20;
                    break;
                case GroundTypes.clay:
                    A = -0.25;
                    break;
                case GroundTypes.peatSD:
                case GroundTypes.peatMD:
                    return PeatTbf();
                case GroundTypes.unknown:
                default:
                    throw new Exception("Тип грунта не определн");
            }
            return A - B * (53 * Cbf + 40 * Math.Pow(Cbf, 2));
        }

        /// <summary>
        ///температура начала замерзания грунта - Торф
        ///</summary>
        private double PeatTbf()
        {
            double tbf = double.NaN;
            switch (_Type)
            {
                case GroundTypes.peatSD:
                    if (1.64 <= Wtot && Wtot < 3.27)
                        tbf = -0.35;
                    else if (3.27 <= Wtot && Wtot < 5.90)
                        tbf = -0.25;
                    else if (5.90 <= Wtot && Wtot < 7.30)
                        tbf = -0.16;
                    else if (7.30 <= Wtot)
                        tbf = -0.14;
                    break;
                case GroundTypes.peatMD:
                    if (0.90 <= Wtot && Wtot < 3.5)
                        tbf = -0.20;
                    else if (3.50 <= Wtot)
                        tbf = -0.13;
                    break;
                default:
                    throw new Exception("not peat type");
            }
            return tbf;
        }

        /// <summary>
        ///Концентрация порового раствора
        ///</summary>
        public double GetCbf()
        {
            double W = Itot <= 0.4 ? Wtot : Wm;
            return Dsal / (Dsal + 100 * W);
        }

        #region type works
        /// <summary>
        ///получить строковое значение для типа грунта
        ///</summary>
        public string StringType()
        {
            switch (_Type)
            {
                case GroundTypes.sands:
                    return cSands;
                case GroundTypes.sandyloam:
                    return cSandyloams;
                case GroundTypes.loam:
                    return cLoam;
                case GroundTypes.clay:
                    return cClays;
                case GroundTypes.peatSD:
                    return cPeatSD;
                case GroundTypes.peatMD:
                    return cPeatMD;
                case GroundTypes.unknown:
                default:
                    return null;
            }
        }

        /// <summary>
        ///установить тип грунта
        ///</summary>
        private void SetType(string type)
        {
            switch (type)
            {
                case cSands:
                    _Type = GroundTypes.sands;
                    break;
                case cSandyloams:
                    _Type = GroundTypes.sandyloam;
                    break;
                case cLoam:
                    _Type = GroundTypes.loam;
                    break;
                case cClays:
                    _Type = GroundTypes.clay;
                    break;
                case cPeatSD:
                    _Type = GroundTypes.peatSD;
                    break;
                case cPeatMD:
                    _Type = GroundTypes.peatMD;
                    break;
                default:
                    _Type = GroundTypes.unknown;
                    break;
            }
        }

        /// <summary>
        ///установить тип грунта
        ///</summary>
        private void SetType(int type)
        {
            if (0 <= type && type < 7)
                _Type = (GroundTypes)type;
            else
                _Type = GroundTypes.unknown;
        }

        /// <summary>
        ///получить строковое значение для типа засоленности
        ///</summary>
        public string StringSaltsType()
        {
            switch (_Salt)
            {
                case Salts.unsalted:
                    return cUnsalted;
                case Salts.salineMT:
                    return cSalineMT;
                case Salts.salineCT:
                    return cSalineCT;
                case Salts.unknown:
                default:
                    return null;
            }
        }

        /// <summary>
        ///установить тип засоленности грунта
        ///</summary>
        private void SetSaltsType(string type)
        {
            switch (type)
            {
                case cUnsalted:
                    _Salt = Salts.unsalted;
                    break;
                case cSalineMT:
                    _Salt = Salts.salineMT;
                    break;
                case cSalineCT:
                    _Salt = Salts.salineCT;
                    break;
                default:
                    _Salt = Salts.unknown;
                    break;
            }
        }

        /// <summary>
        ///установить тип засоленности грунта
        ///</summary>
        private void SetSaltsType(int type)
        {
            if (0 < type && type < 4)
                _Salt = (Salts)type;
            else
                _Salt = Salts.unknown;
        }
        #endregion

        #region equatable
        //переопределение стандартных методов сравнения
        //для поиска в коллекции 
        public static bool operator !=(FTPMGData leftObj, FTPMGData rightObj)
        {
            return !(leftObj == rightObj);
        }

        public static bool operator ==(FTPMGData leftObj, FTPMGData rightObj)
        {
            if (ReferenceEquals(leftObj, rightObj))
            {
                return true;
            }
            if (ReferenceEquals(null, leftObj) || ReferenceEquals(null, rightObj))
            {
                return false;
            }
            if (leftObj._Type == rightObj._Type && leftObj._Salt == rightObj._Salt &&
                leftObj.Dsal == rightObj.Dsal && leftObj.Itot == rightObj.Itot &&
                leftObj.Wtot == rightObj.Wtot && leftObj.Wm == rightObj.Wm)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            try
            {
                return (this == (FTPMGData)obj);
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
