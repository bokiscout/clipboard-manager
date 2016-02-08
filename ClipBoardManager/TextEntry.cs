using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoardManager
{
    class TextEntry : Entry
    {
        private String id { get; set; }
        private String content { get; set; }
        private String shortContent { get; set; }

        public TextEntry(String content, String id)
        {
            this.content = content;
            this.id = id;

            this.shortContent = content.Trim();

            if (this.shortContent.Length > 15)
            {
                this.shortContent = this.shortContent.Substring(0, 14) + "...";
            }

            if (this.shortContent.Contains("\n"))
            {
                int index = this.shortContent.IndexOf("\n");
                this.shortContent = this.shortContent.Substring(0, index - 1) + "...";
            }
        }

        public String GetContent()
        {
            return content;
        }

        public String GetId()
        {
            return id;
        }

        public String GetShortContent()
        {
            return shortContent;
        }

        public override String ToString()
        {
            return shortContent;
        }

        public override bool Equals(Object obj)
        {
            if (obj is TextEntry)
            {
                TextEntry castedObj = obj as TextEntry;
                return (this.content == castedObj.content);
            }
            else
            {
                return false;
            }
        }
    }
}
