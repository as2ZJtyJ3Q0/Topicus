using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Enums;
using WebApplication1.Objects;

namespace WebApplication1.Logic
{
    public class InformationLogic
    {
        public static Medicine[] GetMedicine()
        {
            Medicine paracetamolTablet = new Medicine()
            {
                Name = "paracetamol tablet",
                Form = FormEnum.Tablet,
                PackageDetails = new PackageDetail()
                {
                    PackageType = PackageTypeEnum.Strips,
                    AmountOfBoxes = 3,
                    TabletsPerStrip = 2
                }
            };

            Medicine paracetamolPowder = new Medicine()
            {
                Name = "paracetamol poeder",
                Form = FormEnum.Powder,
                PackageDetails = new PackageDetail()
                {
                    PackageType = PackageTypeEnum.Other,
                    AmountOfBoxes = 3,
                    Amount = 2
                }
            };

            Medicine broomhexineTablet = new Medicine()
            {
                Name = "broomhexine tablet",
                Form = FormEnum.Tablet,
                PackageDetails = new PackageDetail()
                {
                    PackageType = PackageTypeEnum.Strips,
                    AmountOfBoxes = 3,
                    TabletsPerStrip = 2
                }
            };

            Medicine broomhexineLiquid = new Medicine()
            {
                Name = "broomhexine vloeistof",
                Form = FormEnum.Liquid,
                PackageDetails = new PackageDetail()
                {
                    PackageType = PackageTypeEnum.Vials,
                    AmountOfBoxes = 3,
                    MlPerVial = 5
                }
            };

            Medicine eyeDrops = new Medicine()
            {
                Name = "eyeDrops vloeistof",
                Form = FormEnum.Liquid,
                PackageDetails = new PackageDetail()
                {
                    PackageType = PackageTypeEnum.Vials,
                    AmountOfBoxes = 3,
                    MlPerVial = 5
                }
            };
            return new [] { paracetamolTablet, paracetamolPowder, broomhexineTablet, broomhexineLiquid, eyeDrops };
        }
    }
}
