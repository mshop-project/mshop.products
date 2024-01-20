﻿using mshop.products.domain.Entities;

namespace mshop.products.domain.Repositories.Categories
{
    public interface ICategoriesRepository
    {
        public Task CreateAsync(Category category);
        public Task<IEnumerable<Category>> GetAllAsync();
    }
}
