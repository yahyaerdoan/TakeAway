﻿using MongoDB.Bson;

namespace TakeAway.CatalogService.Dtos.SliderDto;

public class GetByIdSliderDto
{
    public string Id { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
