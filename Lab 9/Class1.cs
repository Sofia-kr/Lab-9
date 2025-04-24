using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_9
{
    internal class CreateFile
    {
        private static int TotalFilesCreated;
        public int totalFilesCreated 
        { get { return TotalFilesCreated; }
           
        }


        private string name;
        private DateTime creationDate;
        private long length;
        private StringBuilder content = new StringBuilder();

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва файлу не може бути порожньою");
                name = value;
            }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Дата створення не може бути у майбутньому");
                creationDate = value;
            }
        }

        public long Length
        {
            get { return length; }
            private set
            {
                length = value;
            }

        }
        public string Content
        {
            get { return content.ToString(); }
        }

        public string Status
        {
            get
            {
                return string.Format("Файл: {0}\nДата: {1:dd.MM.yyyy}\nРозмір: {2} байт\nВміст: {3}\nКількість створених файлів: {4}",
                    name,
                    creationDate,
                    length,
                    length > 0 ? "є" : "немає",
                    totalFilesCreated);
            }
        }

     
        public CreateFile() : this("Новий файл.txt", DateTime.Now) { }

        public CreateFile(string name, DateTime creationDate)
        {
            Name = name;
            CreationDate = creationDate;
            content = new StringBuilder(); 
            TotalFilesCreated++;
            UpdateLength();
        }


        public double GetSizeInKB()
        {
            return Length / 1024.0;
        }

        public void AppendText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Текст не може бути порожнім");
            }

            content.AppendLine(text);
            UpdateLength();
        }
        public void ClearContent()
        {
            content.Clear();
            UpdateLength();
        }

        private void UpdateLength()
        {
            Length = Encoding.UTF8.GetByteCount(content.ToString());
        }

        public override string ToString()
        {
            return Status;
        }
    }


}
