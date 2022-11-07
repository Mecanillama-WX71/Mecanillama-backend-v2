using AutoMapper;
using Mecanillama.API.Customers.Controllers;
using Mecanillama.API.Customers.Domain.Services;
using Mecanillama.API.Customers.Domain.Model;
using Mecanillama.API.Customers.Services;
using Mecanillama.API.Mechanics.Controllers;
using Moq;

namespace Mecanillama.Tests;

public class UnitTest3
{
    
    private readonly MechanicsController _controller;

    public UnitTest3()
    {
        _controller = new MechanicsController(null, null);
    }

    [Fact]
    public async Task Test3()
    {
        var response = _controller.GetAllSync();
        Assert.NotNull(response);
    }
}