﻿using MongoDB.Bson;

namespace TakeAway.CatalogService.Dtos.CategoryDtos;

public class UpdateCategoryDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

