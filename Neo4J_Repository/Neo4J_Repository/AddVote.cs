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
    public partial class AddVote : Form
    {
        public GraphClient client;
        public AddVote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Voters voter = this.createVoter();
            string maxId = getMaxId();

            try
            {
                int mId = Int32.Parse(maxId);
                voter.id = (mId++).ToString();
            }
            catch (Exception exception)
            {
                voter.id = "";
            }


            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("name", voter.name);
            queryDict.Add("surname", voter.surname);
            queryDict.Add("birthday", voter.birthday);
            queryDict.Add("birthplace", voter.birthplace);
            queryDict.Add("vote_for", voter.voteFor);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Voter {id:'" + voter.id + "', name:'" + voter.name + "', surname:'" + voter.surname
                                                            + "', birthday:'" + voter.birthday + "', birthplace:'" + voter.birthplace + "', vote_for:'" + voter.voteFor
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            List<Voters> voters = ((IRawGraphClient)client).ExecuteGetCypherResults<Voters>(query).ToList();

            foreach (Voters a in voters)
            {
                MessageBox.Show(a.name);
            }

            City city = this.createCity();
            string maxId1 = getMaxId();

            try
            {
                int mId = Int32.Parse(maxId);
                city.id = (mId++).ToString();
            }
            catch (Exception exception)
            {
                city.id = "";
            }

            Dictionary<string, object> queryDictC = new Dictionary<string, object>();
            queryDictC.Add("name", city.name);


            var queryC = new Neo4jClient.Cypher.CypherQuery("Merge (n:City {id:'" + city.id + "', name:'" + city.name + "'}) return n",
                                                            queryDictC, CypherResultMode.Set);

            List<City> cities = ((IRawGraphClient)client).ExecuteGetCypherResults<City>(queryC).ToList();



            string PName = nameTextBox.Text;
            string PPres = comboBox1.SelectedItem.ToString();
            string PCity = birthplaceTextBox.Text;
            int increment = 1;

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            queryDict1.Add("PName", PName);
            queryDict1.Add("PPres", PPres);
            queryDict1.Add("PCity", PCity);
            queryDict1.Add("increment", increment);

            CypherQuery query1 = new Neo4jClient.Cypher.CypherQuery("match (u:Voter) , (r:President) , (c:City) where u.name = {PName} and r.name = {PPres} and c.name = {PCity} merge (u)-[:VOTE_FOR]->(r) merge (u)-[:LIVES]->(c) ",
                                                              queryDict1, CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query1);
               
            //brojanje glasova
            /*CypherQuery query2 = new Neo4jClient.Cypher.CypherQuery("Match (r:President) where r.name = {PPres} set r.votes = r.votes + {increment}})",
                                                              queryDict1, CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query2);*/
        }

        

        private Voters createVoter()
        {
            Voters a = new Voters();

            TimeSpan unixtime =
                dateTimePicker1.Value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            a.name = nameTextBox.Text;
            a.surname = surNameTextBox.Text;
            a.birthday = unixtime.TotalMilliseconds.ToString();
            a.birthplace = birthplaceTextBox.Text;
            a.voteFor = comboBox1.SelectedItem.ToString();
            
            return a;
        }

        private City createCity()
        {
            City a = new City();

            a.name = birthplaceTextBox.Text;

            return a;
        }

        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }

        private void AddVote_Load(object sender, EventArgs e)
        {
            string PName = ".*" + ".*";

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            queryDict1.Add("PName", PName);

            var query1 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:President) and exists(n.name) and n.name =~ {PName} return n",
                                                            queryDict1, CypherResultMode.Set);

            List<President> presidents = ((IRawGraphClient)client).ExecuteGetCypherResults<President>(query1).ToList();

            foreach (President a in presidents)
            {
                comboBox1.Items.Add(a.name);
            }
        }
    }
}
