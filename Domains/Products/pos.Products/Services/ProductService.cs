﻿using Microsoft.EntityFrameworkCore;
using pos.Core;
using pos.Infrastructure.Data;

namespace pos.Products.Services;

public interface IProductService
{
}

public class ProductService : IProductService
{
    private readonly ITenantDbContextFactory tenantDbContextFactory;

    public ProductService(ITenantDbContextFactory tenantDbContextFactory)
    {
        this.tenantDbContextFactory = tenantDbContextFactory;
    }
}