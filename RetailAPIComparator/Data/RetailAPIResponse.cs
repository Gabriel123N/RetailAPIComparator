namespace RetailAPIComparator.Data
{
    public class Item
    {
        public string currencyCode { get; set; }
        public double tierMinimumUnits { get; set; }
        public double retailPrice { get; set; }
        public double unitPrice { get; set; }
        public string armRegionName { get; set; }
        public string location { get; set; }
        public DateTime effectiveStartDate { get; set; }
        public string meterId { get; set; }
        public string meterName { get; set; }
        public string productId { get; set; }
        public string skuId { get; set; }
        public string productName { get; set; }
        public string skuName { get; set; }
        public string serviceName { get; set; }
        public string serviceId { get; set; }
        public string serviceFamily { get; set; }
        public string unitOfMeasure { get; set; }
        public string type { get; set; }
        public bool isPrimaryMeterRegion { get; set; }
        public string armSkuName { get; set; }
        public string reservationTerm { get; set; } = "None";
    }

    public class RetailAPIResponse
    {
        public string BillingCurrency { get; set; }
        public string CustomerEntityId { get; set; }
        public string CustomerEntityType { get; set; }
        public List<Item> Items { get; set; }
        public string NextPageLink { get; set; }
        public int Count { get; set; }
    }
}
