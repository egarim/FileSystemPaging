using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using System;
using System.Linq;

namespace FileSystemPaging
{
    [DomainComponent]
    public class FileSystemItem : NonPersistentBaseObject
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string FullPath { get; set; }
        public string Parent { get; set; }
        public bool IsDeleted { get; set; }

        List<FileSystemItem> fileSystemItems;
        public List<FileSystemItem> FileSystemItems
        {
            get
            {
                if(this.Type== "directory")
                {
                   return FileSystemHelper.GetChildItems(this.FullPath,this.Parent);
                }
                return null;
            }

           
        }
    }
}
