using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace XianShou.bcyoo.Common.Helper
{
    public class GDIHelper
    {
        /// <summary>
        /// 文字附加在图片上
        /// </summary>
        /// <param name="fromPatn">背景图</param>
        /// <param name="savePath">保存路径</param>
        /// <param name="authNo">编号</param>
        /// <param name="name">姓名</param>
        /// <param name="roleValue">授权等级</param>
        /// <param name="authTime">审核时间</param>
        /// <param name="addTime">添加时间</param>
        /// <param name="weixinId">微信</param>
        public static  void WriteFontOnImage(string fromPatn, string savePath, string authNo, string name, string roleValue, string authTime, string addTime, string weixinId)
        {
            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
            Image imgPhoto = Image.FromFile(fromPatn);
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);


            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
            //以后所有的绘图都将发生在原来照片的顶部。
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(
                imgPhoto,
                new Rectangle(0, 0, phWidth, phHeight),
                0,
                0,
                phWidth,
                phHeight,
                GraphicsUnit.Pixel);
            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Near;

            SolidBrush solidBrush1 = new SolidBrush(Color.FromArgb(253, 0, 0, 0));

            PointF pointF1 = new PointF();
            PointF pointF2 = new PointF();
            PointF pointF3 = new PointF();
            PointF pointF4 = new PointF();
            PointF pointF5 = new PointF();
            PointF pointF6 = new PointF();
            Font font1 = new Font("微软雅黑", 70, FontStyle.Bold);
            Font font2 = new Font("微软雅黑", 70, FontStyle.Bold);
            Font font3 = new Font("微软雅黑", 70, FontStyle.Bold);
            Font font4 = new Font("微软雅黑", 70, FontStyle.Bold);
            Font font5 = new Font("微软雅黑", 70, FontStyle.Bold);
            Font font6 = new Font("微软雅黑", 70, FontStyle.Bold);
            pointF1 = new PointF(59, 440);
            pointF2 = new PointF(59, 540);
            pointF3 = new PointF(59, 640);
            pointF4 = new PointF(59, 740);
            pointF5 = new PointF(59, 840);
            pointF6 = new PointF(267, 988);

            //grPhoto.RotateTransform(90f);
            grPhoto.DrawString(authNo,
              font1,
              solidBrush1,
             pointF1,
              StrFormat);
            grPhoto.DrawString(name,
             font2,
             solidBrush1,
            pointF2,
             StrFormat);
            grPhoto.DrawString(roleValue,
             font3,
             solidBrush1,
            pointF3,
             StrFormat);
            grPhoto.DrawString(authTime,
             font4,
             solidBrush1,
            pointF4,
             StrFormat);
            grPhoto.DrawString(addTime,
             font5,
             solidBrush1,
            pointF5,
             StrFormat);
            grPhoto.DrawString(weixinId,
             font6,
             solidBrush1,
            pointF6,
             StrFormat);
            grPhoto.ResetTransform();
            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(
                imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            Graphics grWatermark =
                  Graphics.FromImage(bmWatermark);

            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
            imgPhoto = bmWatermark;
            grPhoto.Dispose();

            imgPhoto.Save(savePath, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            bmWatermark.Dispose();
            solidBrush1.Dispose();
            grPhoto.Dispose();
            StrFormat.Dispose();
            bmPhoto.Dispose();
            font1.Dispose();
            font2.Dispose();
            font3.Dispose();
            font4.Dispose();
            font5.Dispose();
            font6.Dispose();
        }

        /// <summary>
        /// 文字附加在图片上
        /// </summary>
        /// <param name="rSrcImgPath"></param>
        /// <param name="pic2"></param>
        /// <param name="weixin"></param>
        /// <param name="lianmeng"></param>
        public static void WriteFontOnImage(string fromPatn, string savePath, string authNo, string name, string roleValue, string authTime, string addTime, string weixinId, string role, string Time)
        {
            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
            Image imgPhoto = Image.FromFile(fromPatn);
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);


            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
            //以后所有的绘图都将发生在原来照片的顶部。
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(
                imgPhoto,
                new Rectangle(0, 0, phWidth, phHeight),
                0,
                0,
                phWidth,
                phHeight,
                GraphicsUnit.Pixel);
            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Near;

            SolidBrush solidBrush1 = new SolidBrush(Color.FromArgb(253, 0, 0, 0));
            SolidBrush solidBrush2 = new SolidBrush(Color.FromArgb(253, 255, 255, 255));
            SolidBrush solidBrush3 = new SolidBrush(Color.FromArgb(253, 216, 38, 29));
            SolidBrush solidBrush4 = new SolidBrush(Color.FromArgb(253, 255, 255, 255));
            PointF pointF1 = new PointF();
            PointF pointF2 = new PointF();
            PointF pointF3 = new PointF();
            PointF pointF4 = new PointF();
            PointF pointF5 = new PointF();
            PointF pointF6 = new PointF();
            PointF pointF7 = new PointF();
            PointF pointF8 = new PointF();

            Font font1 = new Font("微软雅黑", 60);
            Font font2 = new Font("微软雅黑", 90, FontStyle.Bold);
            Font font3 = new Font("微软雅黑", 90, FontStyle.Bold);
            Font font4 = new Font("微软雅黑", 52);
            Font font5 = new Font("微软雅黑", 52);
            Font font6 = new Font("微软雅黑", 36, FontStyle.Bold);
            Font font7 = new Font("微软雅黑", 40, FontStyle.Bold);
            Font font8 = new Font("微软雅黑", 52);
            pointF1 = new PointF(830, 655);
            pointF2 = new PointF(810, 720);
            pointF3 = new PointF(1090, 1125);
            pointF4 = new PointF(680, 1410);
            pointF5 = new PointF(1290, 1410);
            pointF6 = new PointF(400, 1740);
            pointF7 = new PointF(400, 1620);
            pointF8 = new PointF(840, 1650);

            //grPhoto.RotateTransform(90f);
            grPhoto.DrawString(authNo,
              font1,
              solidBrush4,
             pointF1,
              StrFormat);
            grPhoto.DrawString(name,
             font2,
             solidBrush2,
            pointF2,
             StrFormat);
            grPhoto.DrawString(roleValue,
             font3,
             solidBrush2,
            pointF3,
             StrFormat);
            grPhoto.DrawString(authTime,
             font4,
             solidBrush4,
            pointF4,
             StrFormat);
            grPhoto.DrawString(addTime,
             font5,
             solidBrush4,
            pointF5,
             StrFormat);
            grPhoto.DrawString(weixinId,
             font6,
             solidBrush3,
            pointF6,
            StrFormat);
            grPhoto.DrawString(role,
             font7,
             solidBrush3,
            pointF7,
            StrFormat);
            grPhoto.DrawString(Time,
             font8,
             solidBrush4,
            pointF8,
             StrFormat);
            grPhoto.ResetTransform();
            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(
                imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            Graphics grWatermark =
                  Graphics.FromImage(bmWatermark);

            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
            imgPhoto = bmWatermark;
            grPhoto.Dispose();

            imgPhoto.Save(savePath, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            bmWatermark.Dispose();
            solidBrush1.Dispose();
            grPhoto.Dispose();
            StrFormat.Dispose();
            bmPhoto.Dispose();
            font1.Dispose();
            font2.Dispose();
            font3.Dispose();
            font4.Dispose();
            font5.Dispose();
            font6.Dispose();
            font7.Dispose();
            font8.Dispose();
        }

        public void SetFileImageSize(int width, int height, string formSrc, string saveSrc)
        {
            Image img = Image.FromFile(formSrc);
            int iWidth = width;//宽   
            int iHeight = height;//高   
            Bitmap bmp = new Bitmap(img, iWidth, iHeight);
            bmp.Save(saveSrc);
        }
        public static void SetUrlImageSize(int width, int height, string formSrc, string saveSrc)
        {
            Stream stream = null;
            HttpWebResponse webResponse = null;
            WebRequest webRequest = HttpWebRequest.Create(formSrc);   //打开图片地址
            webResponse = (HttpWebResponse)webRequest.GetResponse();
            stream = webResponse.GetResponseStream();
            Image img = Image.FromStream(stream);
            int iWidth = width;//宽   
            int iHeight = height;//高   
            Bitmap bmp = new Bitmap(img, iWidth, iHeight);
            bmp.Save(saveSrc);
            bmp.Dispose();
            ///upload/white/IDPLUS/xxx.jpg
        }
        public static void SaveUrlIamge(string formSrc,string saveSrc)
        {
            Stream stream = null;
            HttpWebResponse webResponse = null;
            WebRequest webRequest = HttpWebRequest.Create(formSrc);   //打开图片地址
            webResponse = (HttpWebResponse)webRequest.GetResponse();
            stream = webResponse.GetResponseStream();
            Image img = Image.FromStream(stream);
            //int iWidth = width;//宽   
            //int iHeight = height;//高   
            Bitmap bmp = new Bitmap(img);
            bmp.Save(saveSrc);
        }
        public static void MergerImage(string bgScr, string leftScr, string rightScr, string saveScr)
        {
            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
            Image imgPhoto = Image.FromFile(bgScr);
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //这个代码载入水印图片，水印图片已经被保存为一个BMP文件，以绿色(A=0,R=0,G=255,B=0)作为背景颜色。
            //再一次，会为它的Width 和Height定义一个变量。
            //Bitmap bmNew=new Bitmap(rMarkImgPath);
            //bmNew.MakeTransparent(Color.White);
            //Image imgWatermark = bmNew;
            Image imgleft = new Bitmap(leftScr);
            Image imgRight = new Bitmap(rightScr);
            int wmWidth = imgleft.Width;
            int wmHeight = imgleft.Height;

            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
            //以后所有的绘图都将发生在原来照片的顶部。
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(
                imgPhoto,
                new Rectangle(0, 0, phWidth, phHeight),
                0,
                0,
                phWidth,
                phHeight,
                GraphicsUnit.Pixel);
            //为了最大化版权信息的大小，我们将测试7种不同的字体大小来决定我们能为我们的照片宽度使用的可能的最大大小。
            //为了有效地完成这个，我们将定义一个整型数组，接着遍历这些整型值测量不同大小的版权字符串。
            //一旦我们决定了可能的最大大小，我们就退出循环，绘制文本



            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            //现在我们已经有了所有所需的位置坐标来使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 。
            //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。
            //这段偏离将用来创建阴影效果。使用Brush重复这样一个过程，在前一个绘制的文本顶部绘制同样的文本。



            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(
                imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            Graphics grWatermark =
                Graphics.FromImage(bmWatermark);

            //通过定义一个ImageAttributes 对象并设置它的两个属性，我们就是实现了两个颜色的处理，以达到半透明的水印效果。
            //处理水印图象的第一步是把背景图案变为透明的(Alpha=0, R=0, G=0, B=0)。我们使用一个Colormap 和定义一个RemapTable来做这个。
            //就像前面展示的，我的水印被定义为100%绿色背景，我们将搜到这个颜色，然后取代为透明。
            ImageAttributes imageAttributes =
                new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 255, 255, 255);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };


            //第二个颜色处理用来改变水印的不透明性。
            //通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。
            //通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。
            imageAttributes.SetRemapTable(remapTable,
                ColorAdjustType.Bitmap);
            float[][] colorMatrixElements = { 
                                         new float[] {1.0f,   0.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   1.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   1.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   1f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   0.0f, 1.0f}
                                     };

            ColorMatrix wmColorMatrix = new
                ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //随着两个颜色处理加入到imageAttributes 对象，我们现在就能在照片右手边上绘制水印了。
            //我们会偏离10像素到底部，10像素到左边。
            int markWidth;
            int markHeight;

            //mark比原来的图宽
            if (phWidth <= wmWidth)
            {
                markWidth = phWidth;
                markHeight = (markWidth * wmHeight) / wmWidth;
            }
            else if (phHeight <= wmHeight)
            {
                markHeight = phHeight;
                markWidth = (markHeight * wmWidth) / wmHeight;
            }
            else
            {
                markWidth = wmWidth;
                markHeight = wmHeight;
            }
            int xPosOfWm = ((phWidth - markWidth));
            int yPosOfWm = 0;

            grWatermark.DrawImage(imgleft,
                new Rectangle(xPosOfWm - 450, yPosOfWm, markWidth,
                markHeight),
                0,
                0,
                wmWidth,
                wmHeight,
                GraphicsUnit.Pixel,
                imageAttributes);
            grWatermark.DrawImage(imgRight,
            new Rectangle(xPosOfWm, yPosOfWm, markWidth,
            markHeight),
            0,
            0,
            wmWidth,
            wmHeight,
            GraphicsUnit.Pixel,
            imageAttributes);
            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
            imgPhoto = bmWatermark;
            grPhoto.Dispose();
            grWatermark.Dispose();

            imgPhoto.Save(saveScr, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            imgleft.Dispose();
            imgRight.Dispose();
        }


        public static void MergerImageSeven(string bgScr, string one, string two, string three, string four, string five, string six, string seven, string saveScr)
        {
            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
            Image imgPhoto = Image.FromFile(bgScr);
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //这个代码载入水印图片，水印图片已经被保存为一个BMP文件，以绿色(A=0,R=0,G=255,B=0)作为背景颜色。
            //再一次，会为它的Width 和Height定义一个变量。
            //Bitmap bmNew=new Bitmap(rMarkImgPath);
            //bmNew.MakeTransparent(Color.White);
            //Image imgWatermark = bmNew;
            Image imgone = new Bitmap(one);
            Image imgtwo = new Bitmap(two);
            Image imgthree = new Bitmap(three);
            Image imgfour = new Bitmap(four);
            Image imgfive = new Bitmap(five);
            Image imgsix = new Bitmap(six);
            Image imgseven = new Bitmap(seven);
            int wmWidth = imgone.Width;
            int wmHeight = imgone.Height;

            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
            //以后所有的绘图都将发生在原来照片的顶部。
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(
                imgPhoto,
                new Rectangle(0, 0, phWidth, phHeight),
                0,
                0,
                phWidth,
                phHeight,
                GraphicsUnit.Pixel);
            //为了最大化版权信息的大小，我们将测试7种不同的字体大小来决定我们能为我们的照片宽度使用的可能的最大大小。
            //为了有效地完成这个，我们将定义一个整型数组，接着遍历这些整型值测量不同大小的版权字符串。
            //一旦我们决定了可能的最大大小，我们就退出循环，绘制文本



            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            //现在我们已经有了所有所需的位置坐标来使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 。
            //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。
            //这段偏离将用来创建阴影效果。使用Brush重复这样一个过程，在前一个绘制的文本顶部绘制同样的文本。



            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(
                imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            Graphics grWatermark =
                Graphics.FromImage(bmWatermark);

            //通过定义一个ImageAttributes 对象并设置它的两个属性，我们就是实现了两个颜色的处理，以达到半透明的水印效果。
            //处理水印图象的第一步是把背景图案变为透明的(Alpha=0, R=0, G=0, B=0)。我们使用一个Colormap 和定义一个RemapTable来做这个。
            //就像前面展示的，我的水印被定义为100%绿色背景，我们将搜到这个颜色，然后取代为透明。
            ImageAttributes imageAttributes =
                new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 255, 255, 255);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };


            //第二个颜色处理用来改变水印的不透明性。
            //通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。
            //通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。
            imageAttributes.SetRemapTable(remapTable,
                ColorAdjustType.Bitmap);
            float[][] colorMatrixElements = { 
                                         new float[] {1.0f,   0.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   1.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   1.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   1f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   0.0f, 1.0f}
                                     };

            ColorMatrix wmColorMatrix = new
                ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //随着两个颜色处理加入到imageAttributes 对象，我们现在就能在照片右手边上绘制水印了。
            //我们会偏离10像素到底部，10像素到左边。
            int markWidth;
            int markHeight;

            //mark比原来的图宽
            if (phWidth <= wmWidth)
            {
                markWidth = phWidth;
                markHeight = (markWidth * wmHeight) / wmWidth;
            }
            else if (phHeight <= wmHeight)
            {
                markHeight = phHeight;
                markWidth = (markHeight * wmWidth) / wmHeight;
            }
            else
            {
                markWidth = wmWidth;
                markHeight = wmHeight;
            }
            int xPosOfWm = ((phWidth - markWidth));
            int yPosOfWm = 0;

            grWatermark.DrawImage(imgone,
                new Rectangle(0, 0, 900,
                600),
                0,
                0,
                900,
                600,
                GraphicsUnit.Pixel,
                imageAttributes);
            grWatermark.DrawImage(imgtwo,
            new Rectangle(0, 600, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgthree,
            new Rectangle(0, 1200, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgfour,
            new Rectangle(0, 1800, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgfive,
            new Rectangle(0, 2400, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgsix,
            new Rectangle(0, 3000, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgseven,
            new Rectangle(0, 3600, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
            imgPhoto = bmWatermark;
            grPhoto.Dispose();
            grWatermark.Dispose();

            imgPhoto.Save(saveScr, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            imgone.Dispose();
            imgtwo.Dispose();
            imgthree.Dispose();
            imgfour.Dispose();
            imgfive.Dispose();
            imgsix.Dispose();
            imgseven.Dispose();
        }
        public static void MergerImageSix(string bgScr, string one, string two, string three, string four, string five, string six,string saveScr)
        {
            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
            Image imgPhoto = Image.FromFile(bgScr);
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //这个代码载入水印图片，水印图片已经被保存为一个BMP文件，以绿色(A=0,R=0,G=255,B=0)作为背景颜色。
            //再一次，会为它的Width 和Height定义一个变量。
            //Bitmap bmNew=new Bitmap(rMarkImgPath);
            //bmNew.MakeTransparent(Color.White);
            //Image imgWatermark = bmNew;
            Image imgone = new Bitmap(one);
            Image imgtwo = new Bitmap(two);
            Image imgthree = new Bitmap(three);
            Image imgfour = new Bitmap(four);
            Image imgfive = new Bitmap(five);
            Image imgsix = new Bitmap(six);
            int wmWidth = imgone.Width;
            int wmHeight = imgone.Height;

            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
            //以后所有的绘图都将发生在原来照片的顶部。
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(
                imgPhoto,
                new Rectangle(0, 0, phWidth, phHeight),
                0,
                0,
                phWidth,
                phHeight,
                GraphicsUnit.Pixel);
            //为了最大化版权信息的大小，我们将测试7种不同的字体大小来决定我们能为我们的照片宽度使用的可能的最大大小。
            //为了有效地完成这个，我们将定义一个整型数组，接着遍历这些整型值测量不同大小的版权字符串。
            //一旦我们决定了可能的最大大小，我们就退出循环，绘制文本



            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            //现在我们已经有了所有所需的位置坐标来使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 。
            //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。
            //这段偏离将用来创建阴影效果。使用Brush重复这样一个过程，在前一个绘制的文本顶部绘制同样的文本。



            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(
                imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            Graphics grWatermark =
                Graphics.FromImage(bmWatermark);

            //通过定义一个ImageAttributes 对象并设置它的两个属性，我们就是实现了两个颜色的处理，以达到半透明的水印效果。
            //处理水印图象的第一步是把背景图案变为透明的(Alpha=0, R=0, G=0, B=0)。我们使用一个Colormap 和定义一个RemapTable来做这个。
            //就像前面展示的，我的水印被定义为100%绿色背景，我们将搜到这个颜色，然后取代为透明。
            ImageAttributes imageAttributes =
                new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 255, 255, 255);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };


            //第二个颜色处理用来改变水印的不透明性。
            //通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。
            //通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。
            imageAttributes.SetRemapTable(remapTable,
                ColorAdjustType.Bitmap);
            float[][] colorMatrixElements = { 
                                         new float[] {1.0f,   0.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   1.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   1.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   1f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   0.0f, 1.0f}
                                     };

            ColorMatrix wmColorMatrix = new
                ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //随着两个颜色处理加入到imageAttributes 对象，我们现在就能在照片右手边上绘制水印了。
            //我们会偏离10像素到底部，10像素到左边。
            int markWidth;
            int markHeight;

            //mark比原来的图宽
            if (phWidth <= wmWidth)
            {
                markWidth = phWidth;
                markHeight = (markWidth * wmHeight) / wmWidth;
            }
            else if (phHeight <= wmHeight)
            {
                markHeight = phHeight;
                markWidth = (markHeight * wmWidth) / wmHeight;
            }
            else
            {
                markWidth = wmWidth;
                markHeight = wmHeight;
            }
            int xPosOfWm = ((phWidth - markWidth));
            int yPosOfWm = 0;

            grWatermark.DrawImage(imgone,
                new Rectangle(0, 0, 900,
                600),
                0,
                0,
                900,
                600,
                GraphicsUnit.Pixel,
                imageAttributes);
            grWatermark.DrawImage(imgtwo,
            new Rectangle(0, 600, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgthree,
            new Rectangle(0, 1200, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgfour,
            new Rectangle(0, 1800, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgfive,
            new Rectangle(0, 2400, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgsix,
            new Rectangle(0, 3000, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
            imgPhoto = bmWatermark;
            grPhoto.Dispose();
            grWatermark.Dispose();

            imgPhoto.Save(saveScr, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            imgone.Dispose();
            imgtwo.Dispose();
            imgthree.Dispose();
            imgfour.Dispose();
            imgfive.Dispose();
            imgsix.Dispose();
        }
        public static void MergerImageFive(string bgScr, string one, string two, string three, string four, string five,string saveScr)
        {
            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
            Image imgPhoto = Image.FromFile(bgScr);
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //这个代码载入水印图片，水印图片已经被保存为一个BMP文件，以绿色(A=0,R=0,G=255,B=0)作为背景颜色。
            //再一次，会为它的Width 和Height定义一个变量。
            //Bitmap bmNew=new Bitmap(rMarkImgPath);
            //bmNew.MakeTransparent(Color.White);
            //Image imgWatermark = bmNew;
            Image imgone = new Bitmap(one);
            Image imgtwo = new Bitmap(two);
            Image imgthree = new Bitmap(three);
            Image imgfour = new Bitmap(four);
            Image imgfive = new Bitmap(five);
            int wmWidth = imgone.Width;
            int wmHeight = imgone.Height;

            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
            //以后所有的绘图都将发生在原来照片的顶部。
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(
                imgPhoto,
                new Rectangle(0, 0, phWidth, phHeight),
                0,
                0,
                phWidth,
                phHeight,
                GraphicsUnit.Pixel);
            //为了最大化版权信息的大小，我们将测试7种不同的字体大小来决定我们能为我们的照片宽度使用的可能的最大大小。
            //为了有效地完成这个，我们将定义一个整型数组，接着遍历这些整型值测量不同大小的版权字符串。
            //一旦我们决定了可能的最大大小，我们就退出循环，绘制文本



            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            //现在我们已经有了所有所需的位置坐标来使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 。
            //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。
            //这段偏离将用来创建阴影效果。使用Brush重复这样一个过程，在前一个绘制的文本顶部绘制同样的文本。



            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(
                imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            Graphics grWatermark =
                Graphics.FromImage(bmWatermark);

            //通过定义一个ImageAttributes 对象并设置它的两个属性，我们就是实现了两个颜色的处理，以达到半透明的水印效果。
            //处理水印图象的第一步是把背景图案变为透明的(Alpha=0, R=0, G=0, B=0)。我们使用一个Colormap 和定义一个RemapTable来做这个。
            //就像前面展示的，我的水印被定义为100%绿色背景，我们将搜到这个颜色，然后取代为透明。
            ImageAttributes imageAttributes =
                new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 255, 255, 255);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };


            //第二个颜色处理用来改变水印的不透明性。
            //通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。
            //通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。
            imageAttributes.SetRemapTable(remapTable,
                ColorAdjustType.Bitmap);
            float[][] colorMatrixElements = { 
                                         new float[] {1.0f,   0.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   1.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   1.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   1f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   0.0f, 1.0f}
                                     };

            ColorMatrix wmColorMatrix = new
                ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //随着两个颜色处理加入到imageAttributes 对象，我们现在就能在照片右手边上绘制水印了。
            //我们会偏离10像素到底部，10像素到左边。
            int markWidth;
            int markHeight;

            //mark比原来的图宽
            if (phWidth <= wmWidth)
            {
                markWidth = phWidth;
                markHeight = (markWidth * wmHeight) / wmWidth;
            }
            else if (phHeight <= wmHeight)
            {
                markHeight = phHeight;
                markWidth = (markHeight * wmWidth) / wmHeight;
            }
            else
            {
                markWidth = wmWidth;
                markHeight = wmHeight;
            }
            int xPosOfWm = ((phWidth - markWidth));
            int yPosOfWm = 0;

            grWatermark.DrawImage(imgone,
                new Rectangle(0, 0, 900,
                600),
                0,
                0,
                900,
                600,
                GraphicsUnit.Pixel,
                imageAttributes);
            grWatermark.DrawImage(imgtwo,
            new Rectangle(0, 600, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgthree,
            new Rectangle(0, 1200, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgfour,
            new Rectangle(0, 1800, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgfive,
            new Rectangle(0, 2400, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
            imgPhoto = bmWatermark;
            grPhoto.Dispose();
            grWatermark.Dispose();

            imgPhoto.Save(saveScr, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            imgone.Dispose();
            imgtwo.Dispose();
            imgthree.Dispose();
            imgfour.Dispose();
            imgfive.Dispose();
        }
        public static void MergerImageFour(string bgScr, string one, string two, string three, string four,string saveScr)
        {
            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
            Image imgPhoto = Image.FromFile(bgScr);
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //这个代码载入水印图片，水印图片已经被保存为一个BMP文件，以绿色(A=0,R=0,G=255,B=0)作为背景颜色。
            //再一次，会为它的Width 和Height定义一个变量。
            //Bitmap bmNew=new Bitmap(rMarkImgPath);
            //bmNew.MakeTransparent(Color.White);
            //Image imgWatermark = bmNew;
            Image imgone = new Bitmap(one);
            Image imgtwo = new Bitmap(two);
            Image imgthree = new Bitmap(three);
            Image imgfour = new Bitmap(four);
            int wmWidth = imgone.Width;
            int wmHeight = imgone.Height;

            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
            //以后所有的绘图都将发生在原来照片的顶部。
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(
                imgPhoto,
                new Rectangle(0, 0, phWidth, phHeight),
                0,
                0,
                phWidth,
                phHeight,
                GraphicsUnit.Pixel);
            //为了最大化版权信息的大小，我们将测试7种不同的字体大小来决定我们能为我们的照片宽度使用的可能的最大大小。
            //为了有效地完成这个，我们将定义一个整型数组，接着遍历这些整型值测量不同大小的版权字符串。
            //一旦我们决定了可能的最大大小，我们就退出循环，绘制文本



            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            //现在我们已经有了所有所需的位置坐标来使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 。
            //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。
            //这段偏离将用来创建阴影效果。使用Brush重复这样一个过程，在前一个绘制的文本顶部绘制同样的文本。



            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(
                imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            Graphics grWatermark =
                Graphics.FromImage(bmWatermark);

            //通过定义一个ImageAttributes 对象并设置它的两个属性，我们就是实现了两个颜色的处理，以达到半透明的水印效果。
            //处理水印图象的第一步是把背景图案变为透明的(Alpha=0, R=0, G=0, B=0)。我们使用一个Colormap 和定义一个RemapTable来做这个。
            //就像前面展示的，我的水印被定义为100%绿色背景，我们将搜到这个颜色，然后取代为透明。
            ImageAttributes imageAttributes =
                new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 255, 255, 255);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };


            //第二个颜色处理用来改变水印的不透明性。
            //通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。
            //通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。
            imageAttributes.SetRemapTable(remapTable,
                ColorAdjustType.Bitmap);
            float[][] colorMatrixElements = { 
                                         new float[] {1.0f,   0.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   1.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   1.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   1f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   0.0f, 1.0f}
                                     };

            ColorMatrix wmColorMatrix = new
                ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //随着两个颜色处理加入到imageAttributes 对象，我们现在就能在照片右手边上绘制水印了。
            //我们会偏离10像素到底部，10像素到左边。
            int markWidth;
            int markHeight;

            //mark比原来的图宽
            if (phWidth <= wmWidth)
            {
                markWidth = phWidth;
                markHeight = (markWidth * wmHeight) / wmWidth;
            }
            else if (phHeight <= wmHeight)
            {
                markHeight = phHeight;
                markWidth = (markHeight * wmWidth) / wmHeight;
            }
            else
            {
                markWidth = wmWidth;
                markHeight = wmHeight;
            }
            int xPosOfWm = ((phWidth - markWidth));
            int yPosOfWm = 0;

            grWatermark.DrawImage(imgone,
                new Rectangle(0, 0, 900,
                600),
                0,
                0,
                900,
                600,
                GraphicsUnit.Pixel,
                imageAttributes);
            grWatermark.DrawImage(imgtwo,
            new Rectangle(0, 600, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgthree,
            new Rectangle(0, 1200, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgfour,
            new Rectangle(0, 1800, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
            imgPhoto = bmWatermark;
            grPhoto.Dispose();
            grWatermark.Dispose();

            imgPhoto.Save(saveScr, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            imgone.Dispose();
            imgtwo.Dispose();
            imgthree.Dispose();
            imgfour.Dispose();
        }
        public static void MergerImageThree(string bgScr, string one, string two, string three, string saveScr)
        {
            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
            Image imgPhoto = Image.FromFile(bgScr);
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //这个代码载入水印图片，水印图片已经被保存为一个BMP文件，以绿色(A=0,R=0,G=255,B=0)作为背景颜色。
            //再一次，会为它的Width 和Height定义一个变量。
            //Bitmap bmNew=new Bitmap(rMarkImgPath);
            //bmNew.MakeTransparent(Color.White);
            //Image imgWatermark = bmNew;
            Image imgone = new Bitmap(one);
            Image imgtwo = new Bitmap(two);
            Image imgthree = new Bitmap(three);
            int wmWidth = imgone.Width;
            int wmHeight = imgone.Height;

            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
            //以后所有的绘图都将发生在原来照片的顶部。
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(
                imgPhoto,
                new Rectangle(0, 0, phWidth, phHeight),
                0,
                0,
                phWidth,
                phHeight,
                GraphicsUnit.Pixel);
            //为了最大化版权信息的大小，我们将测试7种不同的字体大小来决定我们能为我们的照片宽度使用的可能的最大大小。
            //为了有效地完成这个，我们将定义一个整型数组，接着遍历这些整型值测量不同大小的版权字符串。
            //一旦我们决定了可能的最大大小，我们就退出循环，绘制文本



            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            //现在我们已经有了所有所需的位置坐标来使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 。
            //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。
            //这段偏离将用来创建阴影效果。使用Brush重复这样一个过程，在前一个绘制的文本顶部绘制同样的文本。



            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(
                imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            Graphics grWatermark =
                Graphics.FromImage(bmWatermark);

            //通过定义一个ImageAttributes 对象并设置它的两个属性，我们就是实现了两个颜色的处理，以达到半透明的水印效果。
            //处理水印图象的第一步是把背景图案变为透明的(Alpha=0, R=0, G=0, B=0)。我们使用一个Colormap 和定义一个RemapTable来做这个。
            //就像前面展示的，我的水印被定义为100%绿色背景，我们将搜到这个颜色，然后取代为透明。
            ImageAttributes imageAttributes =
                new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 255, 255, 255);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };


            //第二个颜色处理用来改变水印的不透明性。
            //通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。
            //通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。
            imageAttributes.SetRemapTable(remapTable,
                ColorAdjustType.Bitmap);
            float[][] colorMatrixElements = { 
                                         new float[] {1.0f,   0.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   1.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   1.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   1f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   0.0f, 1.0f}
                                     };

            ColorMatrix wmColorMatrix = new
                ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //随着两个颜色处理加入到imageAttributes 对象，我们现在就能在照片右手边上绘制水印了。
            //我们会偏离10像素到底部，10像素到左边。
            int markWidth;
            int markHeight;

            //mark比原来的图宽
            if (phWidth <= wmWidth)
            {
                markWidth = phWidth;
                markHeight = (markWidth * wmHeight) / wmWidth;
            }
            else if (phHeight <= wmHeight)
            {
                markHeight = phHeight;
                markWidth = (markHeight * wmWidth) / wmHeight;
            }
            else
            {
                markWidth = wmWidth;
                markHeight = wmHeight;
            }
            int xPosOfWm = ((phWidth - markWidth));
            int yPosOfWm = 0;

            grWatermark.DrawImage(imgone,
                new Rectangle(0, 0, 900,
                600),
                0,
                0,
                900,
                600,
                GraphicsUnit.Pixel,
                imageAttributes);
            grWatermark.DrawImage(imgtwo,
            new Rectangle(0, 600, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgthree,
            new Rectangle(0, 1200, 900,
            600),
            0,
            0,
            900,
            600,
            GraphicsUnit.Pixel,
            imageAttributes);
            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
            imgPhoto = bmWatermark;
            grPhoto.Dispose();
            grWatermark.Dispose();

            imgPhoto.Save(saveScr, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            imgone.Dispose();
            imgtwo.Dispose();
            imgthree.Dispose();
        }
        public static void MergerImageTwo(string bgScr, string one, string two, string saveScr)
        {
                //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
                //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
                Image imgPhoto = Image.FromFile(bgScr);
                int phWidth = imgPhoto.Width;
                int phHeight = imgPhoto.Height;

                Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

                bmPhoto.SetResolution(72, 72);

                Graphics grPhoto = Graphics.FromImage(bmPhoto);

                //这个代码载入水印图片，水印图片已经被保存为一个BMP文件，以绿色(A=0,R=0,G=255,B=0)作为背景颜色。
                //再一次，会为它的Width 和Height定义一个变量。
                //Bitmap bmNew=new Bitmap(rMarkImgPath);
                //bmNew.MakeTransparent(Color.White);
                //Image imgWatermark = bmNew;
                Image imgone = new Bitmap(one);
                Image imgtwo = new Bitmap(two);
                int wmWidth = imgone.Width;
                int wmHeight = imgone.Height;

                //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
                //以后所有的绘图都将发生在原来照片的顶部。
                grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
                grPhoto.DrawImage(
                    imgPhoto,
                    new Rectangle(0, 0, phWidth, phHeight),
                    0,
                    0,
                    phWidth,
                    phHeight,
                    GraphicsUnit.Pixel);
                //为了最大化版权信息的大小，我们将测试7种不同的字体大小来决定我们能为我们的照片宽度使用的可能的最大大小。
                //为了有效地完成这个，我们将定义一个整型数组，接着遍历这些整型值测量不同大小的版权字符串。
                //一旦我们决定了可能的最大大小，我们就退出循环，绘制文本



                StringFormat StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Center;
                //现在我们已经有了所有所需的位置坐标来使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 。
                //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。
                //这段偏离将用来创建阴影效果。使用Brush重复这样一个过程，在前一个绘制的文本顶部绘制同样的文本。



                //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
                Bitmap bmWatermark = new Bitmap(bmPhoto);

                bmWatermark.SetResolution(
                    imgPhoto.HorizontalResolution,
                    imgPhoto.VerticalResolution);

                Graphics grWatermark =
                    Graphics.FromImage(bmWatermark);

                //通过定义一个ImageAttributes 对象并设置它的两个属性，我们就是实现了两个颜色的处理，以达到半透明的水印效果。
                //处理水印图象的第一步是把背景图案变为透明的(Alpha=0, R=0, G=0, B=0)。我们使用一个Colormap 和定义一个RemapTable来做这个。
                //就像前面展示的，我的水印被定义为100%绿色背景，我们将搜到这个颜色，然后取代为透明。
                ImageAttributes imageAttributes =
                    new ImageAttributes();
                ColorMap colorMap = new ColorMap();

                colorMap.OldColor = Color.FromArgb(255, 255, 255, 255);
                colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
                ColorMap[] remapTable = { colorMap };


                //第二个颜色处理用来改变水印的不透明性。
                //通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。
                //通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。
                imageAttributes.SetRemapTable(remapTable,
                    ColorAdjustType.Bitmap);
                float[][] colorMatrixElements = { 
                                         new float[] {1.0f,   0.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   1.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   1.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   1f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   0.0f, 1.0f}
                                     };

                ColorMatrix wmColorMatrix = new
                    ColorMatrix(colorMatrixElements);

                imageAttributes.SetColorMatrix(wmColorMatrix,
                    ColorMatrixFlag.Default,
                    ColorAdjustType.Bitmap);

                //随着两个颜色处理加入到imageAttributes 对象，我们现在就能在照片右手边上绘制水印了。
                //我们会偏离10像素到底部，10像素到左边。
                int markWidth;
                int markHeight;

                //mark比原来的图宽
                if (phWidth <= wmWidth)
                {
                    markWidth = phWidth;
                    markHeight = (markWidth * wmHeight) / wmWidth;
                }
                else if (phHeight <= wmHeight)
                {
                    markHeight = phHeight;
                    markWidth = (markHeight * wmWidth) / wmHeight;
                }
                else
                {
                    markWidth = wmWidth;
                    markHeight = wmHeight;
                }
                int xPosOfWm = ((phWidth - markWidth));
                int yPosOfWm = 0;

                grWatermark.DrawImage(imgone,
                    new Rectangle(0, 0, 900,
                    600),
                    0,
                    0,
                    900,
                    600,
                    GraphicsUnit.Pixel,
                    imageAttributes);
                grWatermark.DrawImage(imgtwo,
                new Rectangle(0, 600, 900,
                600),
                0,
                0,
                900,
                600,
                GraphicsUnit.Pixel,
                imageAttributes);
                //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
                imgPhoto = bmWatermark;
                grPhoto.Dispose();
                grWatermark.Dispose();

                imgPhoto.Save(saveScr, ImageFormat.Jpeg);
                imgPhoto.Dispose();
                imgone.Dispose();
                imgtwo.Dispose();
        }
        public static void PornsImage(string bgScr,string leftScr,string rightScr,string midScr,string saveScr)
        {
            //以下（代码）从一个指定文件创建了一个Image 对象，然后为它的 Width 和 Height定义变量。
            //这些长度待会被用来建立一个以24 bits 每像素的格式作为颜色数据的Bitmap对象。
            Image imgPhoto = Image.FromFile(bgScr);
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;

            Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(72, 72);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            //这个代码载入水印图片，水印图片已经被保存为一个BMP文件，以绿色(A=0,R=0,G=255,B=0)作为背景颜色。
            //再一次，会为它的Width 和Height定义一个变量。
            //Bitmap bmNew=new Bitmap(rMarkImgPath);
            //bmNew.MakeTransparent(Color.White);
            //Image imgWatermark = bmNew;
            Image imgleft = new Bitmap(leftScr);
            Image imgRight = new Bitmap(rightScr);
            Image imgmid = new Bitmap(midScr);
            int wmWidth = imgleft.Width;
            int wmHeight = imgleft.Height;

            //这个代码以100%它的原始大小绘制imgPhoto 到Graphics 对象的（x=0,y=0）位置。
            //以后所有的绘图都将发生在原来照片的顶部。
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.DrawImage(
                imgPhoto,
                new Rectangle(0, 0, phWidth, phHeight),
                0,
                0,
                phWidth,
                phHeight,
                GraphicsUnit.Pixel);
            //为了最大化版权信息的大小，我们将测试7种不同的字体大小来决定我们能为我们的照片宽度使用的可能的最大大小。
            //为了有效地完成这个，我们将定义一个整型数组，接着遍历这些整型值测量不同大小的版权字符串。
            //一旦我们决定了可能的最大大小，我们就退出循环，绘制文本



            StringFormat StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            //现在我们已经有了所有所需的位置坐标来使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 。
            //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。
            //这段偏离将用来创建阴影效果。使用Brush重复这样一个过程，在前一个绘制的文本顶部绘制同样的文本。



            //根据前面修改后的照片创建一个Bitmap。把这个Bitmap载入到一个新的Graphic对象。
            Bitmap bmWatermark = new Bitmap(bmPhoto);

            bmWatermark.SetResolution(
                imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            Graphics grWatermark =
                Graphics.FromImage(bmWatermark);

            //通过定义一个ImageAttributes 对象并设置它的两个属性，我们就是实现了两个颜色的处理，以达到半透明的水印效果。
            //处理水印图象的第一步是把背景图案变为透明的(Alpha=0, R=0, G=0, B=0)。我们使用一个Colormap 和定义一个RemapTable来做这个。
            //就像前面展示的，我的水印被定义为100%绿色背景，我们将搜到这个颜色，然后取代为透明。
            ImageAttributes imageAttributes =
                new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 255, 255, 255);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };


            //第二个颜色处理用来改变水印的不透明性。
            //通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。
            //通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。
            imageAttributes.SetRemapTable(remapTable,
                ColorAdjustType.Bitmap);
            float[][] colorMatrixElements = { 
                                         new float[] {1.0f,   0.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   1.0f,   0.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   1.0f,   0.0f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   1f, 0.0f},
                                         new float[] {0.0f,   0.0f,   0.0f,   0.0f, 1.0f}
                                     };

            ColorMatrix wmColorMatrix = new
                ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(wmColorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //随着两个颜色处理加入到imageAttributes 对象，我们现在就能在照片右手边上绘制水印了。
            //我们会偏离10像素到底部，10像素到左边。
            int markWidth;
            int markHeight;

            //mark比原来的图宽
            if (phWidth <= wmWidth)
            {
                markWidth = phWidth;
                markHeight = (markWidth * wmHeight) / wmWidth;
            }
            else if (phHeight <= wmHeight)
            {
                markHeight = phHeight;
                markWidth = (markHeight * wmWidth) / wmHeight;
            }
            else
            {
                markWidth = wmWidth;
                markHeight = wmHeight;
            }
            int xPosOfWm = ((phWidth - markWidth));
            int yPosOfWm = 0;

            grWatermark.DrawImage(imgleft,
                new Rectangle(34, 295, 275,
                370),
                0,
                0,
                275,
                370,
                GraphicsUnit.Pixel,
                imageAttributes);
            grWatermark.DrawImage(imgRight,
            new Rectangle(331, 295, 275,
            370),
            0,
            0,
            275,
            370,
            GraphicsUnit.Pixel,
            imageAttributes);
            grWatermark.DrawImage(imgmid,
               new Rectangle(253, 607, 134,
               140),
               0,
               0,
               134,
               140,
               GraphicsUnit.Pixel,
               imageAttributes);
            //最后的步骤将是使用新的Bitmap取代原来的Image。 销毁两个Graphic对象，然后把Image 保存到文件系统。
            imgPhoto = bmWatermark;
            grPhoto.Dispose();
            grWatermark.Dispose();

            imgPhoto.Save(saveScr, ImageFormat.Jpeg);
            imgPhoto.Dispose();
            imgleft.Dispose();
            imgRight.Dispose();
            imgmid.Dispose();
        }
    }
}
