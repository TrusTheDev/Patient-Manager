using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace Patient_Manager.Controllers
{
    internal class gridViewController
    {
        public static DataGridView docxToGridView(DataGridView gridView, DocX document)
        {
            gridView.Columns.Clear();
            foreach (var table in document.Tables)
            {
                foreach (var row in table.Rows)
                {
                    if (gridView.Columns.Count == 0)
                    {
                        foreach (var cell in row.Cells)
                        {
                            gridView.Columns.Add(cell.Paragraphs[0].Text, cell.Paragraphs[0].Text);
                        }
                    }
                    else
                    {
                        List<string> rowData = new List<string>();
                        foreach (var cell in row.Cells)
                        {
                            rowData.Add(cell.Paragraphs[0].Text);
                        }
                        gridView.Rows.Add(rowData.ToArray());
                    }
                }
            }
            return gridView;
        }
    }
}
