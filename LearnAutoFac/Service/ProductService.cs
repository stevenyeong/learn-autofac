namespace LearnAutoFac.Service
{
    public class ProductService : IProductService
    {
        private IStockService _StockService;
        private IBondService _BondService;

        public ProductService(IStockService stockService, IBondService bondService)
        {
            this._StockService = stockService;
            this._BondService = bondService;
        }

        public int StockPrice(string stockCode)
        {
            return this._StockService.Price(stockCode);
        }

        public float BondTerm(string bondCode)
        {
            return this._BondService.Term(bondCode);
        }
    }
}
