using Store.Domain.Commands;

namespace Store.Domain.Utils
{
    public static class ExtractGuids
    {
        public static IEnumerable<Guid> Extract(IList<CreateOrderItemCommand> items)
        {
            // Versão Balta
            var guids = new List<Guid>();

            foreach (var item in items)
                guids.Add(item.Product);

            return guids;

            // Versão Jaque com Linq
            // return items.Select(x => x.Product);
        }
    }
}
