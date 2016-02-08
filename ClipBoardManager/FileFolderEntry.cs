using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoardManager
{
    class FileFolderEntry : Entry
    {
        private String id { get; set; }
        private StringCollection content { get; set; }
        private String shortContent { get; set; }

        public FileFolderEntry(StringCollection content, string id)
        {
            this.content = content;
            this.id = id;

            int index =  content[0].LastIndexOf('\\');
            this.shortContent = content[0].Substring(index + 1);
        }

        public StringCollection GetContent()
        {
            return content;
        }

        public string GetId()
        {
            return id;
        }

        public string GetShortContent()
        {
            return shortContent;
        }

        public override String ToString()
        {
            return this.shortContent;
        }

        public override bool Equals(Object obj)
        {
            if (obj is FileFolderEntry)
            {
                FileFolderEntry castedObj = obj as FileFolderEntry;
                return (this.shortContent == castedObj.shortContent);
            }
            else
            {
                return false;
            }
        }
    }
}
