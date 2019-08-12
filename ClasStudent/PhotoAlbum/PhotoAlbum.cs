using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoAlbum
{
    class PhotoAlbum
    {
        protected int numberOfPage;
        public PhotoAlbum()
        {
            numberOfPage = 16;
        }
        public PhotoAlbum (int numberOfPage)
        {
            this.numberOfPage = numberOfPage;
        }
        public int getNumberOfPage()
        {
            return numberOfPage;
        }
    }
}
