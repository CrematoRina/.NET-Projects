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
    public partial class Form1 : Form
    {

        private GraphClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "12345678");
            try
            {
                client.Connect();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

             
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //string presidentName = 'Vucic';

           // Dictionary<string, object> queryDict = new Dictionary<string, object>();
           // queryDict.Add("presidentName", presidentName);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:VOTE_FOR]->(a) where a.name =~ 'Vucic' return n",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);

            List<Voters> voters = ((IRawGraphClient)client).ExecuteGetCypherResults<Voters>(query).ToList();

            foreach (Voters v in voters)
            {
                MessageBox.Show(v.name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string voterName = ".*" + voterNameTextBox.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("voterName", voterName);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Voter) and exists(n.name) and n.name =~ {voterName} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Voters> voters = ((IRawGraphClient)client).ExecuteGetCypherResults<Voters>(query).ToList();

            foreach (Voters a in voters)
            {
                MessageBox.Show(a.name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cityName = ".*" + cityNameTextBox.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("cityName", cityName);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:City) and exists(n.name) and n.name =~ {cityName} return n",
                                                            queryDict, CypherResultMode.Set);

            List<City> cities = ((IRawGraphClient)client).ExecuteGetCypherResults<City>(query).ToList();

            foreach (City a in cities)
            {
                MessageBox.Show(a.name);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cgName = ".*" + cgTextBox.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("cgName", cgName);



            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:LIVES]->(m) where exists(m.name) and m.name =~ {cgName} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Voters> voters = ((IRawGraphClient)client).ExecuteGetCypherResults<Voters>(query).ToList();

            foreach (Voters m in voters)
            {
                MessageBox.Show(m.name);
            }
        }
         
        private void button5_Click(object sender, EventArgs e)
        {
            string presidentName = ".*" + presidentTextBox.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("presidentName", presidentName);



            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:VOTE_FOR]->(m) where exists(m.name) and m.name =~ {presidentName} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Voters> voters = ((IRawGraphClient)client).ExecuteGetCypherResults<Voters>(query).ToList();

            foreach (Voters a in voters)
            {
                MessageBox.Show(a.name);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddVote addVoteForm = new AddVote();
            addVoteForm.client = client;
            addVoteForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPresident addPresidentForm = new AddPresident();
            addPresidentForm.client = client;
            addPresidentForm.ShowDialog();
        }
        /*private void button7_Click(object sender, EventArgs e)
        {
            
            string actorName = ".*ki.*";
            
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("actorName", actorName);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Actor) and exists(n.name) and n.name =~ {actorName} delete n",
                                                            queryDict, CypherResultMode.Projection);

            List<Voters> actors = ((IRawGraphClient)client).ExecuteGetCypherResults<Voters>(query).ToList();

            foreach (Voters a in actors)
            {
                MessageBox.Show(a.name);
            }
        }*/

        private void button8_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Actor) and exists(n.name) and n.name =~ \".*ri.*\" set n.surname = 'nikakav student' return n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Voters> actors = ((IRawGraphClient)client).ExecuteGetCypherResults<Voters>(query).ToList();

            foreach (Voters a in actors)
            {
                MessageBox.Show(a.surname);
            }
        }
    }
}
