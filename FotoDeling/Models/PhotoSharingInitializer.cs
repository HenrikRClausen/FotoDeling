using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.IO;


namespace FotoDeling.Models {
    public class PhotoSharingInitializer : DropCreateDatabaseAlways<PhotoSharingContext> {
      
        protected override void Seed(PhotoSharingContext context) {
            base.Seed(context);
            }

        //This gets a byte array for a file at the path specified
        //The path is relative to the route of the web site
        //It is used to seed images
        private byte[] getFileBytes(string path) {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk)) {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
                }
            return fileBytes;
            }
        }
    }
