
using BackGroundTaskCrawler.Applications.Business.UseCases.Product.Commands.AddProduct;
using BackGroundTaskCrawler.Domains.Entities.Contracts;
using FluentValidation;

namespace BackGroundTaskCrawler.Applications.Business.Behaviors.Products;

public class AddProductValidator : AbstractValidator<AddProductRequest>
{
    public AddProductValidator(IProductPolicies customerPolicies)
    {
        //RuleFor(x => x.ProductName)
        //    .NotNull().WithMessage("Product Name Could not be null")
        //    .NotEmpty().WithMessage("Product Name Could not be null");
    }
}
