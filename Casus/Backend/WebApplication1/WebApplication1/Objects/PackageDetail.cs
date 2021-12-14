using WebApplication1.Enums;

namespace WebApplication1.Objects
{
    public class PackageDetail
    {
        public PackageTypeEnum PackageType { get; set; }
        public int AmountOfBoxes { get; set; }
        public int? TabletsPerStrip { get; set; }
        public int? MlPerVial { get; set; }
        public int? Amount { get; set; }

    }
}