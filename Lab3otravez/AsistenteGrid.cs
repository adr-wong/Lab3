using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3otravez
{
    public static class AsistenteGrid
    {
        public static DataGridViewColumn CrearColumna(int i)
        {
            DataGridViewColumn newCol = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "c" + (i + 2);
            newCol.Name = "c" + (i + 2);
            newCol.Visible = true;
            newCol.Width = 40;
            return newCol;
        }
    }
}
