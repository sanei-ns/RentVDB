using System.ComponentModel;
using System.Web;

namespace RentVDB.Models
{
    public class ImageMv
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("Upload File")]
        public string ImagePath { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
    }
}