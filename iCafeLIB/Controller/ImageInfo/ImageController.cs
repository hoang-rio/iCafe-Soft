using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace iCafeLIB.Controller.ImageInfo
{
    public class ImageController
    {
        /// <summary>
        ///     Nghiệp vụ chuyển file ảnh thành mảng byte để đưa vào csdl
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static byte[] ConvertImageToByte(string filePath)
        {
            try
            {
                var objStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                var objReader = new BinaryReader(objStream);
                var byImages = objReader.ReadBytes((int) objStream.Length);

                objReader.Close();
                objStream.Close();

                return byImages;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public static byte[] ConvertImageToByte(Image img)
        {
            byte[] byImage;
            try
            {
                var fs = new FileStream(":\\", FileMode.Open, FileAccess.Read);
                img.Save(fs, ImageFormat.Png);
                var binReader = new BinaryReader(fs);
                byImage = binReader.ReadBytes((int) fs.Length);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return byImage;
        }

        /// <summary>
        ///     Nghiệp vụ chuyển mảng byte thành files ảnh tương ứng để hiện lên picturebox
        /// </summary>
        /// <param name="byImages"></param>
        /// <returns></returns>
        public static Image ConvertByteToImage(byte[] byImages)
        {
            MemoryStream objMStream;
            try
            {
                objMStream = new MemoryStream(byImages);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return Image.FromStream(objMStream);
        }

        public static byte[] ConvertImageToByte(string filePath, Size nSize, ImageFormat imgFormat)
        {
            byte[] byImage;
            try
            {
                var img = resizeImage(nSize.Width, nSize.Height, filePath);
                var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                img.Save(fs, imgFormat);
                var binReader = new BinaryReader(fs);
                byImage = binReader.ReadBytes((int) fs.Length);
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return byImage;
        }

        /// <summary>
        ///     Resize Ảnh
        /// </summary>
        /// <param name="newWidth"></param>
        /// <param name="newHeight"></param>
        /// <param name="stPhotoPath"></param>
        /// <returns></returns>
        private static Image resizeImage(int newWidth, int newHeight, string stPhotoPath)
        {
            var imgPhoto = Image.FromFile(stPhotoPath);

            var sourceWidth = imgPhoto.Width;
            var sourceHeight = imgPhoto.Height;

            //Consider vertical pics
            if (sourceWidth < sourceHeight)
            {
                var buff = newWidth;

                newWidth = newHeight;
                newHeight = buff;
            }

            int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
            float nPercent = 0, nPercentW = 0, nPercentH = 0;

            nPercentW = (newWidth/(float) sourceWidth);
            nPercentH = (newHeight/(float) sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = Convert.ToInt16((newWidth -
                                         (sourceWidth*nPercent))/2);
            }
            else
            {
                nPercent = nPercentW;
                destY = Convert.ToInt16((newHeight -
                                         (sourceHeight*nPercent))/2);
            }

            var destWidth = (int) (sourceWidth*nPercent);
            var destHeight = (int) (sourceHeight*nPercent);


            var bmPhoto = new Bitmap(newWidth, newHeight,
                PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            var grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Black);
            grPhoto.InterpolationMode =
                InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            imgPhoto.Dispose();
            return bmPhoto;
        }
    }
}