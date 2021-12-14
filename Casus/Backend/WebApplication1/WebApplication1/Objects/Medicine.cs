using WebApplication1.Enums;

namespace WebApplication1.Objects
{
    public class Medicine
    {
        public string Name { get; set; }
        public PackageDetail PackageDetails { get; set; }
        public FormEnum Form { get; set; }
    }
}