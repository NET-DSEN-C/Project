using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using DAL;

namespace BAL
{
    public class BALClient
    {
        public static void remplirInfoClient(DataGridView dgv, TextBox[] info)
        {
            if (dgv.SelectedCells.Count > 0 )
            {
                OleDbConnection cn = new OleDbConnection();
                cn = Global.seConnecter(Global.cs);
                OleDbDataReader reader;

                string nomClient = dgv.SelectedCells[0].Value.ToString();
                reader = Global.ExecuterOleDBSelect(@"select * from client where nom = '"+ nomClient +"'",cn);
                while (reader.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        info[i].Text = reader.GetValue(i + 1).ToString();
                    }
                }
                reader.Close();
                Global.seDeconnecter(cn);
            }
        }





        public int addClient(DAL.Client c)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] attr =
            {
                {"@nom",c.nom},
                {"@rue", c.rue },
                {"@ville",c.ville },
                {"@cp",c.cp },
                {"@tel",c.tel }
            };
            res = Global.ExecuterOleDBActionNomsParams(@"insert into client (nom, rue, ville, cp, tel) values" +
                 " (@nom,@rue,@ville,@cp,@tel)", cn, attr);
            Global.seDeconnecter(cn);


            return 0;
        }
    }
}
