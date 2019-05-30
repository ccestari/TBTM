using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

namespace TakeBackTheMusic.Common
{
   /* public class FileValidator 
    {
        protected void ExtValidate(this IFormFile userfile, string uploadtype)
        {
            // Set variable for allowable file extension types
            string[] imageTypes = { "image/jpg", "image/jpeg", "image/pjpeg", "image/gif", "image/png" };
            string[] musicTypes = { };
            string[] videoTypes = { };

            string[] imageExt = { ".jpg", ".jpeg", ".pjpeg", ".gif", ".png" };
            string[] musicExt = { };
            string[] videoExt = { };

            var userFile = userfile.ContentType.ToLower();

            if (imageTypes.Contains(userFile))
            {

            }



        }
    } */
}
/*

public static class FormFileExtensions
{
    public const int ImageMinimumBytes = 512;

    public static bool IsImage(this IFormFile postedFile)
    {

        
        
        //-------------------------------------------
        //  Check the image mime types
        //-------------------------------------------
        if (postedFile.ContentType.ToLower() != "image/jpg" &&
                    postedFile.ContentType.ToLower() != "image/jpeg" &&
                    postedFile.ContentType.ToLower() != "image/pjpeg" &&
                    postedFile.ContentType.ToLower() != "image/gif" &&
                    postedFile.ContentType.ToLower() != "image/x-png" &&
                    postedFile.ContentType.ToLower() != "image/png")
        {
            return false;
        }

        //-------------------------------------------
        //  Check the image extension
        //-------------------------------------------
        if (Path.GetExtension(postedFile.FileName).ToLower() != ".jpg"
            && Path.GetExtension(postedFile.FileName).ToLower() != ".png"
            && Path.GetExtension(postedFile.FileName).ToLower() != ".gif"
            && Path.GetExtension(postedFile.FileName).ToLower() != ".jpeg")
        {
            return false;
        }

        //-------------------------------------------
        //  Attempt to read the file and check the first bytes
        //-------------------------------------------
        try
        {
            if (!postedFile.OpenReadStream().CanRead)
            {
                return false;
            }
            //------------------------------------------
            //check whether the image size exceeding the limit or not
            //------------------------------------------ 
            if (postedFile.Length < ImageMinimumBytes)
            {
                return false;
            }

            byte[] buffer = new byte[ImageMinimumBytes];
            postedFile.OpenReadStream().Read(buffer, 0, ImageMinimumBytes);
            string content = System.Text.Encoding.UTF8.GetString(buffer);
            if (Regex.IsMatch(content, @"<script|<html|<head|<title|<body|<pre|<table|<a\s+href|<img|<plaintext|<cross\-domain\-policy",
                RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline))
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }

        //-------------------------------------------
        //  Try to instantiate new Bitmap, if .NET will throw exception
        //  we can assume that it's not a valid image
        //-------------------------------------------

        try
        {
            using (var bitmap = new System.Drawing.Bitmap(postedFile.OpenReadStream()))
            {
            }
        }
        catch (Exception)
        {
            return false;
        }
        finally
        {
            postedFile.OpenReadStream().Position = 0;
        }

        return true;
    }
}  */