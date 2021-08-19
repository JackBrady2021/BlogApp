using BlogApp.Models.Blog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Repository
{
    public interface IBlogRepository
    {
        public Task<Blog> UpsertAsync(BlogCreate blogCreate, int applicationUserID);

        public Task<PagedResults<Blog>> GetAllAsync(BlogPaging blogPaging);

        public Task<Blog> GetAsync(int blogID);

        public Task<List<Blog>> GetAllByUserIDAsync(int applicationUserID);

        public Task<List<Blog>> GetAllFamousAsync();

        public Task<int> DeleteAsync(int blogID);
    }
}
