using MVCCore_MongoDB_CRUD.Models;
using System.Collections.Generic;

namespace MVCCore_MongoDB_CRUD.Repositories
{
    public interface IAlbumCollection
    {
        public void InsertAlbum(Album album);

        void UpdateAlbum(Album album);
        void DeleteAlbum(string id);
        List<Album> GetAllAlbums();

        Album GetAlbumById(string id); 

    }
}
