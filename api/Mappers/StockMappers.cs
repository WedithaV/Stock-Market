using System;
using api.Dtos.Stock;
using api.Models;

namespace api.Mappers;

public static class StockMappers
{
    public static StockDto ToStockDto(this Stock stockModel)
    {
       return new StockDto
       {
            Id = stockModel.Id,
            Sysmbol = stockModel.Sysmbol,
            CompanyName = stockModel.CompanyName,
            Purchase = stockModel.Purchase,
            LastDiv = stockModel.LastDiv,
            Industry = stockModel.Industry,
            MarketCap = stockModel.MarketCap

       }; 
    }
}
