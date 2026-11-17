namespace MercadinhoBrasil.Telas;

public static class Estilo
{
    public static void ArrumarGrade(DataGridView grade)
    {
        grade.ReadOnly = true;
        grade.AllowUserToAddRows = false;
        grade.AllowUserToDeleteRows = false;
        grade.AllowUserToResizeRows = false;
        grade.MultiSelect = false;
        grade.RowHeadersVisible = false;

        grade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        grade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        grade.EnableHeadersVisualStyles = false;
        grade.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
        grade.ColumnHeadersDefaultCellStyle.ForeColor = Color.Yellow;
        grade.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
    }
}
