using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Neo4J_Repository.DomainModel;
using Neo4jClient;
using Neo4jClient.Cypher;


namespace Neo4J_Repository
{
    public partial class AddPresident : Form
    {
        public GraphClient client;
        public AddPresident()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            President president = this.createPresident();
            string maxId = getMaxId();

            try
            {
                int mId = Int32.Parse(maxId);
                president.id = (mId++).ToString();
            }
            catch (Exception exception)
            {
                president.id = "";
            }

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("name", president.name);
            queryDict.Add("votes", president.votes);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:President {id:'" + president.id + "', name:'" + president.name + "', votes:'" + president.votes
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            List<President> presidents = ((IRawGraphClient)client).ExecuteGetCypherResults<President>(query).ToList();

            foreach (President a in presidents)
            {
                MessageBox.Show(a.name);
            }

            this.Close();
        }

        private President createPresident()
        {
            President a = new President();

            
            a.name = textBox1.Text;
            a.votes = 0;
            

            return a;
        }

        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }
    }
}
