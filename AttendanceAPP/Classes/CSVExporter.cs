using System.Text;

namespace AttendanceAPP.Classes
{
    internal class CSVExporter
    {
        public static void ExportToCSV(DataGridView dataGridView, string folderPath, string fileName)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            string filePath = Path.Combine(folderPath, fileName);

            StringBuilder csvContent = new StringBuilder();

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                csvContent.Append(dataGridView.Columns[i].HeaderText + (i < dataGridView.Columns.Count - 1 ? "," : ""));
            }
            csvContent.AppendLine();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow) 
                {
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        csvContent.Append(row.Cells[i].Value?.ToString() + (i < dataGridView.Columns.Count - 1 ? "," : ""));
                    }
                    csvContent.AppendLine();
                }
            }

            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
            MessageBox.Show($"CSV file saved successfully!\nLocation: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
