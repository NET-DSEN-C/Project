using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BAL
{
    public class BALCommande
    {
        public static void remplirListeCommande(DataGridView dgv)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader readerCmd;

            readerCmd = Global.ExecuterOleDBSelect(@"select * from [commande] ;", cn);

            while (readerCmd.Read())
            {
                
                dgv.Rows.Add(readerCmd.GetValue(0), readerCmd.GetValue(1),getClientById(readerCmd.GetValue(2).ToString()) );
               
            }
            Global.seDeconnecter(cn);
            readerCmd.Close();

        }
        private static string getClientById(string id)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader;
            string name = "";

            reader = Global.ExecuterOleDBSelect(@"select * from client where id = " + id, cn);
            while (reader.Read())
            {
              name = reader.GetValue(1).ToString();
            }
            
            reader.Close();
            Global.seDeconnecter(cn);
            return name;

        }

        public static void supprimerCmd(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                OleDbConnection cn = new OleDbConnection();
                cn = Global.seConnecter(Global.cs);

                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                int m = Global.ExecuteOleDBAction(@"delete from commande where id = "+id, cn);
                Global.seDeconnecter(cn);
                remplirListeCommande(dgv);
            }
        }

        private static string getIdClientByName(string name)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader;
            string id = "";

            reader = Global.ExecuterOleDBSelect(@"select * from client where nom = " + name, cn);
            while (reader.Read())
            {
                id = reader.GetValue(0).ToString();
            }

            reader.Close();
            Global.seDeconnecter(cn);
            return id;

        }


    }
}
