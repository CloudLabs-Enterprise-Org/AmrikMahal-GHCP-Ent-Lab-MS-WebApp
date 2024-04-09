﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Result;
using Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate;

namespace Microsoft.eShopWeb.ApplicationCore.Interfaces;

public interface IBasketService
{
    Task TransferBasketAsync(string anonymousId, string userName);
    Task<Basket> AddItemToBasketAsync(string username, int catalogItemId, decimal price, int quantity = 1);
    Task<Result<Basket>> SetQuantitiesAsync(int basketId, Dictionary<string, int> quantities);
    Task DeleteBasketAsync(int basketId);
}
