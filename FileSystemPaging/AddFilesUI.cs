using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.BaseImpl;

namespace FileSystemPaging
{
    [DomainComponent]
    public class AddFilesUI:NonPersistentBaseObject
    {
        public FileData File { get; set; }
    }
}
