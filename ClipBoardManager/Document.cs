using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoardManager
{
    class Document
    {
        private int INDEX { get; set; }
        private List<Entry> entries { get; set; }
        private int maximumEntriesAlowed { get ;set; }

        // default constructor
        public Document( int max)
        {
            this.INDEX = 0;
            this.entries = new List<Entry>();
            maximumEntriesAlowed = max;
        }

        // add new entry
        public void AddEntry(String content){
            Entry entry = new TextEntry(content, INDEX.ToString());
            INDEX++;

            // if equal content is beeng copied in the past, remove it.
            // this is how we hande duplicates.
            // new content should be last in the list.
            if (entries.Contains(entry))
            {
                entries.Remove(entry);
            }

            if (entries.Count >= maximumEntriesAlowed)
            {
                entries.RemoveAt(1);
            }

            entries.Add(entry);
        }

        public void AddEntry(System.Collections.Specialized.StringCollection item)
        {
            Entry entry = new FileFolderEntry(item, INDEX.ToString());
            INDEX++;

            if (entries.Contains(entry))
            {
                entries.Remove(entry);
            }

            entries.Add(entry);
        }
        
        // return entry
        public  List<Entry> GetEntries(){
            return this.entries;
        }

        // return entry wit matching id
        public Entry getById(string id)
        {
            foreach (Entry e in entries)
            {
                if (e.GetId() == id)
                {
                    return e;
                }
            }
            return null;
        }

        // remove all entries
        public void Clear()
        {
            this.entries = new List<Entry>();
            this.INDEX = 0;
        }

        // save entries as plain text
        // ***    ****   only text is implemented, files and folders are not
        internal void Serialize(String history)
        {
            try
            {
                int size = entries.Count;

                string[] tmp = new string[size];
                for (int i = 0; i < size; i++)
                {
                    if (!(entries[i] is FileFolderEntry))
                    {
                        tmp[i] = entries[i].ToString();
                    }
                    else
                    {
                        // 0 = file or folder, we can not serialize them as plain text
                        tmp[i] = "0";
                    }
                }
                System.IO.File.WriteAllLines(history, tmp);
            }
            catch (Exception ex)
            {
            }
        }




    }
}
