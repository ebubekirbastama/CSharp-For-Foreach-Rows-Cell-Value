using System.Windows.Forms;

namespace ebstimecms
{
    public class EBSForForeachKullanımı
    {

        public static string  EBSforrows(DataGridView dgrd,int satirverisi ,int sutunverisi)
        {
          return dgrd.Rows[satirverisi].Cells[sutunverisi].Value.ToString();
        }
        public static void EBSForeachRows(DataGridView dgrd,int surunverisi)
        {
            foreach (DataGridViewRow row in dgrd.Rows)
            {
                row.Cells[surunverisi].Value.ToString();
            }

        }
    }
}
