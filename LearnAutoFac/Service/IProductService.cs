namespace LearnAutoFac.Service
{
    public interface IProductService
    {
        int StockPrice(string stockCode);

        float BondTerm(string bondCode);
    }
}
