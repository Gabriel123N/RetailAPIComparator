using RetailAPIComparator.Data;
using System.Text.Json;

namespace RetailAPIComparator.Services
{
    public class GlobalService
    {
        public IGrouping<string,string>[] VMSkuFamilies;
        public Region[] Regions;
        public GlobalService(IWebHostEnvironment _webHostEnvironment)
        {
            using var skufile = new FileStream(_webHostEnvironment.WebRootPath + @"\skunames.json", FileMode.Open);
            using var regionfile = new FileStream(_webHostEnvironment.WebRootPath + @"\regions.json", FileMode.Open);
            var skus = JsonSerializer.Deserialize<string>(skufile);
            Regions = JsonSerializer.Deserialize<Region[]>(regionfile);
            var VMSkus = skus.Split(',', StringSplitOptions.TrimEntries);
            VMSkuFamilies = VMSkus.GroupBy(s => s.Substring(s.IndexOf('_') + 1, 1).ToUpper()).ToArray();
        }
    }
}
