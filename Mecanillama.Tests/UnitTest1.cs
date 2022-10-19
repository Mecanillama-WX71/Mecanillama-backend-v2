using AutoMapper;
using Mecanillama.API.Customers.Controllers;
using Mecanillama.API.Customers.Domain.Services;
using Mecanillama.API.Customers.Domain.Model;
using Mecanillama.API.Customers.Services;
using Moq;

namespace Mecanillama.Tests;

public class UnitTest1
{
    
    private readonly CustomersController _controller;

    public UnitTest1()
    {
        _controller = new CustomersController(null, null);
    }

    [Fact]
    public async Task Test1()
    {
        var response = _controller.GetAllSync();
        Assert.NotNull(response);
    }
}