using Orchard.ContentManagement.MetaData;
using Orchard.Data.Migration;
using Orchard.Core.Contents.Extensions;

namespace SkyWalker.WebShop
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

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterPartDefinition(typeof(ProductPart).Name, part => part
                .Attachable()
                );

            return 2;
        }
    }
}