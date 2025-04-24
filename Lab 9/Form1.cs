using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Form1 : Form
    {

        private CreateFile сreateFile;

        public Form1()
        {
            InitializeComponent();
            SetupControls();
            UpdateFileInfo();
        }

        private void SetupControls()
        {
            dateTimePicker1.Value = DateTime.Now;
            txtContent.ScrollBars = ScrollBars.Vertical;
        }

        private void UpdateFileInfo()
        {
            if (сreateFile != null)
            {
                lblTotalFiles.Text = сreateFile.ToString();
            }
            else
            {
                lblTotalFiles.Text = "No files created";
            }
        }

        private void btnCreateDefault_Click(object sender, EventArgs e)
        {
            try
            {
                сreateFile = new CreateFile();
                UpdateFileInfo();
                MessageBox.Show("Файл створено за замовчуванням", "Успіх",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateCustom_Click(object sender, EventArgs e)
        {
            try
            {
                сreateFile = new CreateFile(txtFileName.Text,dateTimePicker1.Value);
                
                UpdateFileInfo();
                MessageBox.Show("Файл створено з параметрами", "Успіх",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAppendData_Click(object sender, EventArgs e)
        {
            if (сreateFile == null)
            {
                MessageBox.Show("Спочатку створіть файл", "Попередження",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                сreateFile.AppendText(txtContentToAdd.Text);
                UpdateFileInfo();
                txtContentToAdd.Clear();
                MessageBox.Show("Текст успішно додано до файлу", "Успіх",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (сreateFile == null)
            {
                MessageBox.Show("Файл не створено", "Інформація",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string info = $"Детальна інформація:\n{сreateFile}\n" +
                         $"Розмір у KB: {сreateFile.GetSizeInKB():F2}";
            txtContent.Text = сreateFile.Content;

        }

        

        private void btnClearContent_Click_1(object sender, EventArgs e)
        {
            if (сreateFile == null)
            {
                MessageBox.Show("Файл не створено", "Інформація",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            сreateFile.ClearContent();
            UpdateFileInfo();
            txtContent.Clear();
            MessageBox.Show("Вміст файлу очищено", "Успіх",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    

