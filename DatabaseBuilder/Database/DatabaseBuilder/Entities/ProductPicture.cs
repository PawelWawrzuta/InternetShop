﻿namespace DatabaseBuilder.Entities
{
    /// <summary>
    /// Describes database table
    /// </summary>
    public class ProductPicture
    {
        public int PictureID { get; set; }  //Primary Key
        public int ProductID { get; set; }  //ForeignKey

        //Image type -> byte[] ?
        public byte[] Picture { get; set; }
    }
}
