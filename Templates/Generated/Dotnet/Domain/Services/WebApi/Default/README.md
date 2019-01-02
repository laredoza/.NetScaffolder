# Generated .NetScaffolder WebApi

### Migrations 

Select the target migration project in the migrations folder, open the README.md and follow instructions.

### Targeting correct database. 

Databases are targeted by selecting the correct context. To keep things simple I've referenced DotNetScaffolder.Domain.Data.Contexts.EFCore.SqlServer.dll. In a production enviroment you would rather copy the correct dll into your bin folder on deployment. Structuremap will handle context injection.

## Testing generated WebApi
https://localhost:44325/api/product/LoadByProductProductId/1/true

## Configuring Includes

The following configuration in ProductController.cs can be used to return Book and Software data for api/product/LoadByProductProductId:

```
public void ConfigureIncludes()
{
	this.LoadByProductProductIdIncludes = new Expression<Func<IProduct, object>>[]
		{
			a => a.Book,
			a => a.Software
        };
}
```