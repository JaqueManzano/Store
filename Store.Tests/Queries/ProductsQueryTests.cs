using Store.Domain.Entities;
using Store.Domain.Queries;
using Store.Domain.Repositories;
using Store.Tests.Repositories;

namespace Store.Tests.Queries
{
    [TestClass]
    public class ProductsQueryTests
    {
        private IList<Product> _products;

        public ProductsQueryTests()
        {
            _products = new List<Product>
            {
                new Product("Produto 01", 10, true),
                new Product("Produto 02", 10, true),
                new Product("Produto 03", 10, true),
                new Product("Produto 04", 10, false),
                new Product("Produto 05", 10, false)
            };
        }

        [TestMethod]
        [TestCategory("Queries")]
        public void Dado_a_consulta_de_produtos_ativos_deve_retornar_3()
        {
            var result = _products.AsQueryable().Where(ProductQueries.GetActiveProducts());
            Assert.AreEqual(result.Count(), 3);
        }   
        
        [TestMethod]
        [TestCategory("Queries")]
        public void Dado_a_consulta_de_produtos_inativos_deve_retornar_2()
        {
            var result = _products.AsQueryable().Where(ProductQueries.GetInactiveProducts());
            Assert.AreEqual(result.Count(), 2);
        }
    }
}
