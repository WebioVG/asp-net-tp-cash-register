using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cashRegister.Models;
using cashRegister.Repositories;

namespace cashRegister.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public ProductController(ILogger<ProductController> logger, IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        _logger = logger;
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Products()
    {
        var products = await _productRepository.GetAll();
        return View(products);
    }

    public async Task<IActionResult> Details(int id)
    {
        var product = await _productRepository.GetById(id);
        return View(product);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var product = await _productRepository.GetById(id);
        if (product == null)
        {
            return NotFound();
        }

        var categories = await _categoryRepository.GetAll();
        var viewModel = new ProductEditViewModel()
        {
            Product = product,
            Categories = categories
        };

        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(ProductEditViewModel productViewModel)
    {
        if (!ModelState.IsValid)
        {
            productViewModel.Categories = await _categoryRepository.GetAll();
            return View("Edit", productViewModel);
        }

        var updatedProduct = await _productRepository.Update(productViewModel.Product);
        if (updatedProduct == null)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(Products));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
