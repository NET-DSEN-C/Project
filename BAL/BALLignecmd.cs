using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace BAL
{
    public class BALLignecmd
    {
        public static void remplirListeLigneCmnd(DataGridView dgv, string idCmd)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader;

            reader = Global.ExecuterOleDBSelect(@"select * from ligcmd where numcmd = "+ idCmd , cn);
            while (reader.Read())
            {
                
                dgv.Rows.Add(getProduitByCodeProduit(reader.GetValue(0))  , reader.GetValue(2), reader.GetValue(3));
            }
            Global.seDeconnecter(cn);
            reader.Close();
        }
      
        public static string getProduitByCodeProduit(Object codeProduit)
        {

            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader;
            string produit="";

            reader = Global.ExecuterOleDBSelect(@"select * from produit where code ='" + codeProduit.ToString()+"'", cn);
            while (reader.Read())
            {
                produit = reader.GetValue(1).ToString();
            }
            reader.Close();
            Global.seDeconnecter(cn);
            return produit;
        }
    }
}
