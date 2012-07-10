using Orchard.ContentManagement.Drivers;

namespace SkyWalker.WebShop.Drivers
{
    public class ProductDriver : ContentPartDriver<ProductPart>
    {
        //get
        protected override DriverResult Editor(ProductPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_Product_Edit",
                () => shapeHelper.EditorTemplate(TemplateName: "Parts/Product", Model: part, Prefix: Prefix));
        }
        //post
        protected override DriverResult Editor(ProductPart part, Orchard.ContentManagement.IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

    }
}