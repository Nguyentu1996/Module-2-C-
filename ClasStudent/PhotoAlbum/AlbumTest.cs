using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoAlbum
{
    class AlbumTest
    {
        public static void Main()
        {
            PhotoAlbum pt = new PhotoAlbum();
            Console.WriteLine(pt.getNumberOfPage());
            PhotoAlbum pt2 = new PhotoAlbum(24);
            Console.WriteLine(pt2.getNumberOfPage());
            BigPhotoAlbum bgab = new BigPhotoAlbum();
            Console.WriteLine(bgab.getNumberOfPage());
        }
    }
}
