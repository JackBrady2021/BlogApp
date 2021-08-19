using BlogApp.Models.Photo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Repository
{
    public interface IPhotoRepository
    {
        public Task<Photo> InsertAsync(PhotoCreate photoCreate, int applicationUserID);
        public Task<Photo> GetAsync(int photoID);
        public Task<List<Photo>> GetAllByUserIdAsync(int applicationUserID);
        public Task<int> DeleteAsync(int photoID);

    }
}
