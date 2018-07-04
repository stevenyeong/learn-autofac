using Autofac;
using LearnAutoFac.Service;
using System;

namespace LearnAutoFac
{
    public class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<StockService>().As<IStockService>();
            builder.RegisterType<BondService>().As<IBondService>();
            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var productService = scope.Resolve<IProductService>();

                var stockPrice = productService.StockPrice("stockCode");
                var bondTerm = productService.BondTerm("bondCode");

                Console.WriteLine("Stock Price:" + stockPrice);
                Console.WriteLine("Bond Term:" + bondTerm);
                Console.ReadLine();
            }
        }
    }
}
