using Instagram_Email_Scrape.Class;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;

namespace Instagram_Email_Scrape
{

    public partial class FrmMain : Form
    {
        public string baseUrl = "https://gender-api.com/get?key=gyaAZpkQMrpTJQsZEz&name=";
        private const int SIZE_OF_MRE = 4;
        private CFormControl control = new CFormControl();
        private CWebBrowser wb = new CWebBrowser();
        private CInstagram instagram = new CInstagram();

        private ThreadStart emailThread;
        private Thread emailThread_Thread;
        private IWebDriver navigator;

        private ThreadStart GetTimeThreadStart;
        private ThreadStart RandomTimeThreadStart;
        private Thread GetTimeThread;
        private Thread RandomTimeThread;

        private int startTime = -1;
        private int endTime = -1;

        private int PauseHour = -1;
        private int PauseMin = -1;
        private int ResumeHour = -1;
        private int ResumeMin = -1;

        private Dictionary<int, ManualResetEvent> mapMRE = null;
        private int currentPos = 0;

        private Random random = new Random();
        //database
        public string ConnectTheString = "Data Source=DESKTOP-7405PO1\\SQLEXPRESS;Initial Catalog=GenderApiDataBase;Integrated Security=True";
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader dataReader;
        
      



        public FrmMain()
        {
            InitializeComponent();
        }

        

       
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                var collection = File.ReadAllLines("playlist.txt");
                foreach (var item in collection)
                {
                    if (item != "")
                    {
                        dgv_link.Rows.Add(item);
                    }
                }
            }
            catch (Exception)
            {
            }
            try
            {
                var collection = File.ReadAllLines("account.txt");
                foreach (var item in collection)
                {
                    if (item != "")
                    {
                        try
                        {
                            dgv_account.Rows.Add(item.Split(':')[0], item.Split(':')[1]);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            try
            {
                var collection = File.ReadAllLines("proxy.txt");
                foreach (var item in collection)
                {
                    if (item != "")
                    {
                        try
                        {
                            dgv_proxy.Rows.Add(item.Split(':')[0], item.Split(':')[1]);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public string DataProcessIntoDataBase(string name)
        {
            //try
            //{
                string url = baseUrl + name;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json; charset=utf-8";
                request.Accept = "application/json";
                request.Method = WebRequestMethods.Http.Get;
                WebResponse response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                string json_text = sr.ReadToEnd();
                // here get name, country and gender
                string name_label = "\"name\":\"";
                string sanitized_label = "\"name_sanitized\":\"";
                string country_label = "\"country\":\"";
                string gender_lable = "\"gender\":\"";
                string samples_lable = "\"samples\":";
                string accuracy_label = "\"accuracy\":";
                string duration_label = "\"duration\":\"";
                string credits_label = "\"credits_used\":";

                string name_ = getSubString(json_text, json_text.IndexOf(name_label) + name_label.Length, json_text.IndexOf(sanitized_label) - 2);
                string santized = getSubString(json_text, json_text.IndexOf(sanitized_label) + sanitized_label.Length, json_text.IndexOf(country_label) - 2);
                string country = getSubString(json_text, json_text.IndexOf(country_label) + country_label.Length, json_text.IndexOf(gender_lable) - 2);
                string gender = getSubString(json_text, json_text.IndexOf(gender_lable) + gender_lable.Length, json_text.IndexOf(samples_lable) - 2);
                string samples = getSubString(json_text, json_text.IndexOf(samples_lable) + samples_lable.Length, json_text.IndexOf(accuracy_label) - 1);
                string accuracy = getSubString(json_text, json_text.IndexOf(accuracy_label) + accuracy_label.Length, json_text.IndexOf(duration_label) - 1);
                string duration = getSubString(json_text, json_text.IndexOf(duration_label) + duration_label.Length, json_text.IndexOf(credits_label) - 2);
                string credits = getSubString(json_text, json_text.IndexOf(credits_label) + credits_label.Length, json_text.Length - 1);
                sr.Close();
                string temp = "INSERT INTO Table_1 (name,country,gender,accuracy)VALUES ('";
                //String sql = "INSERT INTO Table_1 (id, name,country,gender)VALUES ('1','lion','China','male');" ;
                string sql = temp + name + "','" + country + "','" + gender + "','" + accuracy + "');";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                dataReader.Close();
                command.Dispose();
            if (Int32.Parse(accuracy) >= 60)
            {
                return gender;
            }
            else
                return "both";
            //}
            //catch (Exception e)
            //{
            //    e.GetBaseException();
            //}
           
        }

       public Boolean isInDataBase(string nm)
        {
            string temp = "SELECT * FROM Table_1 WHERE name='"+nm+"'";
            command = new SqlCommand(temp, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
                
        }

        public string getGenderFromDatabase(string nm)
        {
            string gender= "";
            string accuracy = "";
            string temp = "SELECT * FROM Table_1 WHERE name='" + nm + "'";
            command = new SqlCommand(temp, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                gender = reader["gender"].ToString();
                accuracy = reader["accuracy"].ToString();
            }
            reader.Close();
            if (Int32.Parse(accuracy) >= 60)
            {
                return gender;
            }
            else
                return "both";
            // return gender;
        }
        

        private string getSubString(string str, int start, int end)
        {
            string value = "";
            for (int i = start; i < end; i++)
                value += str[i];
            return value;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            
            connection = new SqlConnection(ConnectTheString);
            connection.Open();
            //command = new SqlCommand(sql, connection);
            //dataReader = command.ExecuteReader();
            //dataReader.Close();
            //command.Dispose();

            btn_Start.Visible = false;
            btn_Stop.Visible = true;
            if (currentPos == 0)
            {
                if (tb_randomStartTime.Text.ToString() != "")
                    startTime = Int32.Parse(tb_randomStartTime.Text.ToString());
                if (tb_randomEndTime.Text.ToString() != "")
                    endTime = Int32.Parse(tb_randomEndTime.Text.ToString());
            }
            if (currentPos == 1)
            {
                if (tb_unfollowRandomStartTime.Text.ToString() != "")
                    startTime = Int32.Parse(tb_unfollowRandomStartTime.Text.ToString());
                if (tb_unfollowRandomEndTime.Text.ToString() != "")
                    endTime = Int32.Parse(tb_unfollowRandomEndTime.Text.ToString());
            }
            if (currentPos == 2)
            {
                if (tb_likeRandomStartTime.Text.ToString() != "")
                    startTime = Int32.Parse(tb_likeRandomStartTime.Text.ToString());
                if (tb_likeRandomEndTime.Text.ToString() != "")
                    endTime = Int32.Parse(tb_likeRandomEndTime.Text.ToString());
            }
            if (currentPos == 3)
            {
                if (tb_likeRandomStartTime.Text.ToString() != "")
                    startTime = Int32.Parse(tb_likeRandomStartTime.Text.ToString());
                if (tb_likeRandomEndTime.Text.ToString() != "")
                    endTime = Int32.Parse(tb_likeRandomEndTime.Text.ToString());
            }
            //init a dictionary of mre
            mapMRE = new Dictionary<int, ManualResetEvent>();
            for(int i = 0; i < SIZE_OF_MRE; i++)
            {
                ManualResetEvent mre = new ManualResetEvent(false);
                //int a manual reset event
                mre.Set();
                mapMRE.Add(i, mre);
            }

            //init and start a timer thread
            GetTimeThreadStart = new ThreadStart(StartGetCurrentTime);
            GetTimeThread = new Thread(GetTimeThreadStart);
            GetTimeThread.Start();

            //init a random thread


            RandomTimeThreadStart = new ThreadStart(StartRandomTime);
            RandomTimeThread = new Thread(RandomTimeThreadStart);
            RandomTimeThread.Start();

            //init and start a bot thread
            emailThread = new ThreadStart(StartThread);
            emailThread_Thread = new Thread(emailThread);
            emailThread_Thread.Start();
        }

        private void StartRandomTime()
        {
            int rdPauseMin = -1;
            int rdResumMin = -1;
           // Thread.Sleep(3000);
            for (int sec = 0; ; sec++){
                if (sec % 3600 == 0)
                {
                    if (startTime > 0 && endTime > 0)
                    {
                        int length = random.Next(startTime * 60, endTime * 60);
                        //rdPauseMin = random.Next(0, 3600 - length) + sec;
                        rdPauseMin = 20;
                        rdResumMin = rdPauseMin + length;
                    }
                }
                if (sec == rdPauseMin)
                    mapMRE[currentPos].Reset();
                else if (sec == rdResumMin)
                    mapMRE[currentPos].Set();
                Thread.Sleep(1000);
            }

        }
 
        private void StartGetCurrentTime()
        {
            do
            {
                DateTime currentDateTime = DateTime.Now;
                int currentHour = currentDateTime.Hour;
                int currentMin = currentDateTime.Minute;
                int currentSec = currentDateTime.Second;
                if ( (PauseHour * 60 + PauseMin <= currentHour*60 + currentMin) && (currentHour * 60 + currentMin < ResumeHour * 60 + ResumeMin))
                {
                    if (RandomTimeThread.IsAlive)
                        RandomTimeThread.Abort();
                    mapMRE[currentPos].Reset();
                }

                else if (currentHour == ResumeHour && currentMin == ResumeMin && currentSec == 0)
                {
                   RandomTimeThread.Start();
                   mapMRE[currentPos].Set();
                }
                    
                Thread.Sleep(1000);
            } while (true);
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            //pool.Text = instagram.pool.toString();
            btn_Start.Visible = true;
            btn_Stop.Visible = false;
            try { navigator.Quit(); } catch (Exception) { }
            try { GetTimeThread.Abort(); } catch (Exception) { }
            try { RandomTimeThread.Abort(); } catch (Exception) { }
            try { emailThread_Thread.Abort(); } catch (Exception) { }
        }

        private void StartThread()
        {
            try
            {
                var comments = textBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                for (int i = 0; i < dgv_account.RowCount; i++)
                {
                    string username = dgv_account.Rows[i].Cells[0].Value.ToString();
                    string password = dgv_account.Rows[i].Cells[1].Value.ToString();

                    string ip = "";
                    string port = "";
                    string comment = "";

                    try
                    {
                        comment = comments[i];
                    }
                    catch (Exception)
                    {
                    }

                    navigator = wb.GoogleChrome(ip, port);

                    instagram.InstagramLogin(navigator, username, password);
                    Thread.Sleep(1000);
                    navigator.Navigate().Refresh();
                    Thread.Sleep(1000);

                    if (!navigator.Url.Contains("login"))
                    {
                        for (int j = 0; j < dgv_link.RowCount; j++)
                        {
                            try
                            {
                                string gender;
                                string url = dgv_link.Rows[j].Cells[0].Value.ToString();

                                // get name and get it from api and save it in the database
                                //check if the account is in database
                                string name = GetNameFromUrl(url);
                               // getGenderFromDatabase(name);
                                if (isInDataBase(name))
                                {
                                    //get gender from the database
                                    gender = getGenderFromDatabase(name);
                                }
                                else
                                {
                                    gender = DataProcessIntoDataBase(name);
                                }
                                


                                navigator.Navigate().GoToUrl(url);
                                Thread.Sleep(1000);
                                //instagram.InstagramPlayVideo(navigator);
                                //I added constraints here
                                int k = 0;
                                if (maleGender.Checked)
                                    k = 0;
                                else if (femaleGender.Checked)
                                    k = 1;
                                else if (allGender.Checked)
                                    k = 2;
                                string CheckedString = "";
                                switch (k) {
                                    case 1: CheckedString = "female"; break;
                                    //case 2: CheckedString = "both"; break;
                                    case 0: CheckedString = "male"; break;
                                    default: break;
                                }
                                if ((radioButton_follow.Checked && allGender.Checked) || (radioButton_follow.Checked && gender.Equals(CheckedString)))
                                {
                                    try
                                    {
                                       if (tb_followStartH.Text.ToString() != "")
                                            PauseHour = Int32.Parse(tb_followStartH.Text.ToString());
                                       if (tb_followStartM.Text.ToString() != "")
                                            PauseMin = Int32.Parse(tb_followStartM.Text.ToString());
                                       if (tb_followEndH.Text.ToString() != "")
                                            ResumeHour = Int32.Parse(tb_followEndH.Text.ToString());
                                       if (tb_followEndM.Text.ToString() != "")
                                            ResumeMin = Int32.Parse(tb_followEndM.Text.ToString());
                                       //if (tb_randomStartTime.Text.ToString() != "")
                                        //    startTime = Int32.Parse(tb_randomStartTime.Text.ToString());
                                       //if (tb_randomEndTime.Text.ToString() != "")
                                        //    endTime = Int32.Parse(tb_randomEndTime.Text.ToString());
                                        
                                        
                                    }
                                    catch(Exception){}
                                    //follow accounts
                                    instagram.getFollowingAccounts(mapMRE[currentPos], navigator, minFollowingCount, maxFollowingCount, minFollowerCount, maxFollowerCount, minPostCount, maxPostCount);
                                }
                                //if(radioButton_follow.Checked) instagram.InstagramFollow(navigator);

                                if (radioButton_unfollow.Checked)
                                {
                                    try
                                    {
                                        if (tb_unfollowStartH.Text.ToString() != "")
                                            PauseHour = Int32.Parse(tb_unfollowStartH.Text.ToString());
                                        if (tb_unfollowStartM.Text.ToString() != "")
                                            PauseMin = Int32.Parse(tb_unfollowStartM.Text.ToString());
                                        if (tb_unfollowEndH.Text.ToString() != "")
                                            ResumeHour = Int32.Parse(tb_unfollowEndH.Text.ToString());
                                        if (tb_unfollowEndM.Text.ToString() != "")
                                            ResumeMin = Int32.Parse(tb_unfollowEndM.Text.ToString());
                                        //if (tb_unfollowRandomStartTime.Text.ToString() != "")
                                          //  startTime = Int32.Parse(tb_unfollowRandomStartTime.Text.ToString());
                                        //if (tb_unfollowRandomEndTime.Text.ToString() != "")
                                          //  endTime = Int32.Parse(tb_unfollowRandomEndTime.Text.ToString());
                                    }
                                    catch(Exception) { }
                                    ++currentPos;
                                    //unfollow accounts
                                    instagram.InstagramUnfollow(mapMRE[currentPos], navigator);
                                }
                                if (cb_like.Checked)
                                {
                                    try {
                                        if (tb_likeStartH.Text.ToString() != "")
                                            PauseHour = Int32.Parse(tb_likeStartH.Text.ToString());
                                        if (tb_likeStartM.Text.ToString() != "")
                                            PauseMin = Int32.Parse(tb_likeStartM.Text.ToString());
                                        if (tb_likeEndH.Text.ToString() != "")
                                            ResumeHour = Int32.Parse(tb_likeEndH.Text.ToString());
                                        if (tb_likeEndM.Text.ToString() != "")
                                            ResumeMin = Int32.Parse(tb_likeEndM.Text.ToString());
                                        //if (tb_likeRandomStartTime.Text.ToString() != "")
                                         //   startTime = Int32.Parse(tb_likeRandomStartTime.Text.ToString());
                                        //if (tb_likeRandomEndTime.Text.ToString() != "")
                                          //  endTime = Int32.Parse(tb_likeRandomEndTime.Text.ToString());
                                    }
                                    catch(Exception) { }
                                    ++currentPos;
                                    //like accounts
                                    instagram.InstagramLike(mapMRE[currentPos], navigator);
                                }
                                if (cb_comment.Checked)
                                {
                                    try
                                    {
                                        if (tb_likeStartH.Text.ToString() != "")
                                            PauseHour = Int32.Parse(tb_likeStartH.Text.ToString());
                                        if (tb_likeStartM.Text.ToString() != "")
                                            PauseMin = Int32.Parse(tb_likeStartM.Text.ToString());
                                        if (tb_likeEndH.Text.ToString() != "")
                                            ResumeHour = Int32.Parse(tb_likeEndH.Text.ToString());
                                        if (tb_likeEndM.Text.ToString() != "")
                                            ResumeMin = Int32.Parse(tb_likeEndM.Text.ToString());
                                        //if (tb_likeRandomStartTime.Text.ToString() != "")
                                          //  startTime = Int32.Parse(tb_likeRandomStartTime.Text.ToString());
                                        //if (tb_likeRandomEndTime.Text.ToString() != "")
                                         //   endTime = Int32.Parse(tb_likeRandomEndTime.Text.ToString());
                                    }
                                    catch (Exception) { }
                                    ++currentPos;
                                    //comment accounts
                                    instagram.InstagramComment(mapMRE[currentPos],navigator, comment);
                                } 
                                if (cb_pool.Checked) instagram.InstagramPool(navigator, poolDisplay, minFollowingCount, maxFollowingCount, minFollowerCount, maxFollowerCount, minPostCount, maxPostCount);
                                if (cb_pool_follower.Checked) instagram.InstagramPoolFollower(navigator, poolDisplay, minFollowingCount, maxFollowingCount, minFollowerCount, maxFollowerCount, minPostCount, maxPostCount);
                                currentPos = 0;
                                Thread.Sleep(3000);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    

                    navigator.Quit();
                }
            }
            catch (Exception)
            {
            }
            Stop();
        }

        public string GetNameFromUrl(string url)
        {
            string name = "";
            string domain = "https://www.instagram.com/";
            for (int i = domain.Length; i < url.Length - 1; i++)
                name += url[i];
            
            //int num = url.Length;
                return name;
        }

       // private void btn_Poll_Start_Click(object sender, EventArgs e)
       // {
       //     btn_poolOn.Visible = false;
       //     btn_poolOff.Visible = true;
        //    pollPostTread = new ThreadStart(StartPollPostThread);
        //    pollPostTread_Tread = new Thread(pollPostTread);
        //    pollPostTread_Tread.Start();
       // }

      //  private void btn_Poll_Stop_Click(object sender, EventArgs e)
       // {
        //    Poll_Stop();
       // }

       // private void Poll_Stop()
       // {
        //    btn_poolOn.Visible = true;
         //   btn_poolOff.Visible = false;
           // try { navigator.Quit(); } catch (Exception) { }
           // try { emailThread_Thread.Abort(); } catch (Exception) { }
      //  }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxFollowingCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pool_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_proxy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton_unfollow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_like_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void poolDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
