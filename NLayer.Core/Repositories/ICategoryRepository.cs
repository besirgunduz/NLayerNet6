﻿using NLayer.Core.Models;

namespace NLayer.Core.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetCategoryByIdWithProductsAsync(int categoryId);
    }
}
