using Orchard.Data.Migration;

namespace SkyWalker.WebShop.Data
{
    public class Migration : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable("ProductRecord", table => table
                .ContentPartRecord()
                .Column<decimal>("Price")
                .Column<string>("Sku", column => column.WithLength(50))
                );

            return 1;
        }
    }
}