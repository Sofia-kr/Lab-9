using System;

namespace Lab_9
{
    internal class FileData
    {
        private string name;
        private DateTime date;
        private long length;

        public FileData(string name, DateTime date, long length)
        {
            this.name = name;
            this.date = date;
            this.length = length;
        }

        public string FileState { get; internal set; }
    }
}