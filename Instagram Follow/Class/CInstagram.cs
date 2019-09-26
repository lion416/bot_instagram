using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram_Email_Scrape.Class
{
    class CInstagram
    {

        public void InstagramLogin(IWebDriver driver, string username, string password)
        {
            try
            {
                driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");
                Thread.Sleep(1500);
                driver.FindElement(By.XPath("(//input[@class='_2hvTZ pexuQ zyHYP'])[1]")).SendKeys(username);
                Thread.Sleep(500);
                driver.FindElement(By.XPath("(//input[@class='_2hvTZ pexuQ zyHYP'])[2]")).SendKeys(password);
                Thread.Sleep(300);
                var collection = driver.FindElements(By.XPath("//button"));
                foreach (var item in collection)
                {
                    if (item.Text.Contains("Log in"))
                    {
                        item.Click();
                        break;
                    }
                }
                Thread.Sleep(500);
            }
            catch (Exception)
            {
            }
        }

        public void InstagramPlayVideo(IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.XPath("//a[@class='QvAa1 ']")).Click();
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
            }
        }
        public void getFollowingAccounts(ManualResetEvent mre, IWebDriver driver , TextBox minFollowingCount, TextBox maxFollowingCount, TextBox minFollowCount, TextBox maxFollowCount, TextBox minPostCount, TextBox maxPostCount)
        {
            try
            {
                var post_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[1]")).Text;
                var follower_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[2]")).Text;
                var following_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[3]")).Text;
                var number_of_post_string = post_text.Split(' ')[0];
                var number_of_follower_string = follower_text.Split(' ')[0];
                var number_of_following_string = following_text.Split(' ')[0];
                //remove , and replace k
                string post_num = number_of_post_string.Replace(",", "");
                post_num = post_num.Replace("k", "000");
                post_num = post_num.Replace("m", "000000");

                string follower_num = number_of_follower_string.Replace(",", "");
                follower_num = follower_num.Replace("k", "000");
                follower_num = follower_num.Replace("m", "000000");

                string following_num = number_of_following_string.Replace(",", "");
                following_num = following_num.Replace("k", "000");
                following_num = following_num.Replace("m", "000000");
                // below convert string into int

                int number_of_post = Int32.Parse(post_num);
                int number_of_follower = Int32.Parse(follower_num);
                int number_of_following = Int32.Parse(following_num);  // here get the number of posts and followers and following

                //sleep Time
                //

                //follow code

                var collection = driver.FindElements(By.XPath("//button"));
                if (((Int32.Parse(minFollowingCount.Text.ToString()) <= number_of_following) && (number_of_following <= Int32.Parse(maxFollowingCount.Text.ToString()))) && ((Int32.Parse(minFollowCount.Text.ToString()) <= number_of_follower) && (number_of_follower <= Int32.Parse(maxFollowCount.Text.ToString()))) && ((Int32.Parse(minPostCount.Text.ToString()) <= number_of_post) && (number_of_post <= Int32.Parse(maxPostCount.Text.ToString()))))
                {
                    foreach (var item in collection)
                    {
                        if (item.Text == "Follow")
                        {
                            mre.WaitOne();
                            item.Click();
                            Thread.Sleep(3000);
                            break;
                        }
                    }
                }
                else
                    mre.WaitOne();
               
            }
            catch (Exception)
            {
                
            }
        }
        public void InstagramFollow(IWebDriver driver)
        {
           // var text = driver.FindElement(By.XPath("//section[@class='zwlfE']//span[@class='g47SY ']")).Text;
           // var text1 = driver.FindElement(By.XPath("//section[@class='zwlfE']//span[@class='g47SY ']")).Text;

            try
            {
                var collection = driver.FindElements(By.XPath("//button"));
                foreach (var item in collection)
                {
                    if (item.Text == "Follow")
                    {
                        item.Click();
                        Thread.Sleep(3000);
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void InstagramPool(IWebDriver driver, TextBox pool, TextBox minFollowingCount, TextBox maxFollowingCount, TextBox minFollowCount, TextBox maxFollowCount, TextBox minPostCount, TextBox maxPostCount)
        {
           // var collection = driver.FindElements(By.XPath("//div[@class='Nnq7C weEfm']"));
           // int count = collection.Count;
            var collection = driver.FindElements(By.XPath("//div[@class='v1Nh3 kIKUG  _bz0w']"));
            int count = collection.Count;
            if (count == 0) return;
            int number_of_pool = 0;
            for (int i = 1; i < 10000; i++)
            {
                do
                {
                    try
                    {
                        
                        driver.FindElement(By.XPath("(//div[@class='v1Nh3 kIKUG  _bz0w'])[" + i + "]")).Click();
                        Thread.Sleep(5000);
                        // commentor code started here
                        var url_list = driver.FindElements(By.XPath("//a[@class='FPmhX notranslate TlrDj']")); // get the items of commentors
                        for (int k = 1; k < url_list.Count; k++)
                        {
                           
                            //skip the first element here
                            string url = url_list[k].GetAttribute("href");
                            NewTabWithUrl(driver, url); //open the new tab of the commentors and likers
                            Thread.Sleep(3000);
                            var post_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[1]")).Text;
                            var follower_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[2]")).Text;
                            var following_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[3]")).Text;
                            var number_of_post_string = post_text.Split(' ')[0]; 
                            var number_of_follower_string = follower_text.Split(' ')[0];
                            var number_of_following_string = following_text.Split(' ')[0];
                            //remove , and replace k
                            string post_num = number_of_post_string.Replace(",", "");
                            post_num = post_num.Replace("k", "000");

                            string follower_num = number_of_follower_string.Replace(",", "");
                            follower_num = follower_num.Replace("k", "000");
                            

                            string following_num = number_of_following_string.Replace(",", "");
                            following_num = following_num.Replace("k", "000");
                            // below convert string into int

                            int number_of_post = Int32.Parse(post_num);
                            int number_of_follower = Int32.Parse(follower_num);
                            int number_of_following = Int32.Parse(following_num);  // here get the number of posts and followers and following
                           
                            if (((Int32.Parse(minFollowingCount.Text.ToString()) <= number_of_following) && (number_of_following <= Int32.Parse(maxFollowingCount.Text.ToString()))) && ((Int32.Parse(minFollowCount.Text.ToString()) <= number_of_follower) && (number_of_follower <= Int32.Parse(maxFollowCount.Text.ToString()))) && ((Int32.Parse(minPostCount.Text.ToString()) <= number_of_post) && (number_of_post <= Int32.Parse(maxPostCount.Text.ToString()))))
                            {
                                number_of_pool++;
                                pool.Text = number_of_pool.ToString();

                            }
                            CloseLastTab(driver);
                            Thread.Sleep(3000);
                        }
                        driver.FindElement(By.XPath("//button[@class='ckWGn']")).Click();
                        Thread.Sleep(2000);
                        // ended here

                        // below is the code for likers

                        driver.FindElement(By.XPath("//div[@class='Nm9Fw']//button[@class='_0mzm- sqdOP yWX7d    _8A5w5    ']")).Click();
                        Thread.Sleep(3000);
                        var url_list_of_likers = driver.FindElements(By.XPath("//a[@class='FPmhX notranslate _0imsa ']")); // get the items of likers
                        for (int k = 0; k < url_list_of_likers.Count; k++)
                        {
                            try
                            {
                                string url_liker = url_list_of_likers[k].GetAttribute("href");
                                NewTabWithUrl(driver, url_liker); //open the new tab of the commentors and likers

                                var post_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[1]")).Text;
                                var follower_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[2]")).Text;
                                var following_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[3]")).Text;
                                var number_of_post_string = post_text.Split(' ')[0];
                                int number_of_post = Int32.Parse(number_of_post_string);
                                var number_of_follower_string = follower_text.Split(' ')[0];
                                int number_of_follower = Int32.Parse(number_of_follower_string);
                                var number_of_following_string = follower_text.Split(' ')[0];
                                int number_of_following = Int32.Parse(number_of_follower_string);  // here get the number of posts and followers and following

                                if (((Int32.Parse(minFollowingCount.Text.ToString()) <= number_of_following) && (number_of_following <= Int32.Parse(maxFollowingCount.Text.ToString()))) && ((Int32.Parse(minFollowCount.Text.ToString()) <= number_of_follower) && (number_of_follower <= Int32.Parse(maxFollowCount.Text.ToString()))) && ((Int32.Parse(minPostCount.Text.ToString()) <= number_of_post) && (number_of_post <= Int32.Parse(maxPostCount.Text.ToString()))))
                                {
                                    number_of_pool++;
                                    PageDown(driver);
                                    //pool.Text = number_of_pool.ToString();
                                }
                                CloseLastTab(driver);
                            }
                            catch (Exception)
                            {
                                //page down code
                            }
                            
                        }

                        //liker code ended here

                        break;
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        // page down code
                        PageDown(driver);
                        collection = driver.FindElements(By.XPath("//div[@class='v1Nh3 kIKUG  _bz0w']"));
                        if (count == collection.Count)
                        {
                            return;
                        }
                        count = collection.Count;
                        break;
                    }
                    catch (Exception)
                    {
                    }
                } while (false);
            }
        }

        public void InstagramPoolFollower(IWebDriver driver, TextBox pool, TextBox minFollowingCount, TextBox maxFollowingCount, TextBox minFollowCount, TextBox maxFollowCount, TextBox minPostCount, TextBox maxPostCount)
        {
            driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[2]")).Click();
            Thread.Sleep(3000);

            //var follower_collection = driver.FindElements(By.XPath("//div[@class='pbNvD fPMEg  HYpXt']//li[@class='wo9IH']"));
            var follower_collection = driver.FindElements(By.XPath("//a[@class='FPmhX notranslate _0imsa ']"));
            int count = follower_collection.Count;
            if (count == 0) return;
            int number_of_pool_ = 0;
            for (int i = 0; i < 999999999; i++)
            {
                try
                {
                    string url = follower_collection[i].GetAttribute("href");
                    NewTabWithUrl(driver, url);
                    Thread.Sleep(2000);
                    var post_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[1]")).Text;
                    var follower_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[2]")).Text;
                    var following_text = driver.FindElement(By.XPath("(//section[@class='zwlfE']//li[@class='Y8-fY '])[3]")).Text;
                    var number_of_post_string = post_text.Split(' ')[0];
                    var number_of_follower_string = follower_text.Split(' ')[0];
                    var number_of_following_string = following_text.Split(' ')[0];
                    //remove , and replace k
                    string post_num = number_of_post_string.Replace(",", "");
                    post_num = post_num.Replace("k", "000");

                    string follower_num = number_of_follower_string.Replace(",", "");
                    follower_num = follower_num.Replace("k", "000");


                    string following_num = number_of_following_string.Replace(",", "");
                    following_num = following_num.Replace("k", "000");
                    // below convert string into int

                    int number_of_post = Int32.Parse(post_num);
                    int number_of_follower = Int32.Parse(follower_num);
                    int number_of_following = Int32.Parse(following_num);  // here get the number of posts and followers and following

                    if (((Int32.Parse(minFollowingCount.Text.ToString()) <= number_of_following) && (number_of_following <= Int32.Parse(maxFollowingCount.Text.ToString()))) && ((Int32.Parse(minFollowCount.Text.ToString()) <= number_of_follower) && (number_of_follower <= Int32.Parse(maxFollowCount.Text.ToString()))) && ((Int32.Parse(minPostCount.Text.ToString()) <= number_of_post) && (number_of_post <= Int32.Parse(maxPostCount.Text.ToString()))))
                    {
                        number_of_pool_++;
                        pool.Text = number_of_pool_.ToString();

                    }
                    CloseLastTab(driver);
                    Thread.Sleep(2000);
                }
                catch (Exception)
                {
                    //pagedown code
                    var element = driver.FindElement(By.XPath("//div[@class='isgrP']"));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollTop = arguments[1];", element, 500);
                    Thread.Sleep(2000);
                    follower_collection = driver.FindElements(By.XPath("//a[@class='FPmhX notranslate _0imsa ']"));
                    if (count == follower_collection.Count)
                    {
                        break;
                    }
                    count = follower_collection.Count;


                }
            }

        }

        public void NewTabWithUrl(IWebDriver driver, string url)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.open()");
                driver.SwitchTo().Window(driver.WindowHandles[driver.WindowHandles.Count - 1]);
                driver.Navigate().GoToUrl(url);
                Thread.Sleep(500);
            }
            catch (Exception)
            {
            }
        }

        public void CloseLastTab(IWebDriver driver)
        {
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public void PageUp(IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, 0);");
                Thread.Sleep(500);
            }
            catch (Exception)
            {
            }
        }

        public void PageDown(IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                Thread.Sleep(500);
            }
            catch (Exception)
            {
            }
        }

        public void InstagramUnfollow(ManualResetEvent mre, IWebDriver driver)
        {
            try
            {
                var collection = driver.FindElements(By.XPath("//button"));
                foreach (var item in collection)
                {
                    if (item.Text == "Following")
                    {
                        mre.WaitOne();
                        item.Click();
                        Thread.Sleep(3000);
                        break;
                    }
                }
                collection = driver.FindElements(By.XPath("//button"));
                foreach (var item in collection)
                {
                    if (item.Text == "Unfollow")
                    {
                        mre.WaitOne();
                        item.Click();
                        Thread.Sleep(3000);
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void InstagramLike(ManualResetEvent mre, IWebDriver driver)
        {
            var collection = driver.FindElements(By.XPath("//div[@class='v1Nh3 kIKUG  _bz0w']"));
            int count = collection.Count;
            if (count == 0) return;
            for (int i = 1; i < 10000; i++)
            {
                do
                {
                    try
                    {
                        
                        driver.FindElement(By.XPath("(//div[@class='v1Nh3 kIKUG  _bz0w'])[" + i + "]")).Click();
                        mre.WaitOne();
                        Thread.Sleep(5000);
                        // like code started here
                        try
                        {

                            var element = driver.FindElement(By.XPath("//section[@class='ltpMr Slqrh']//button//span"));
                            if (element.GetAttribute("aria-label") == "Like")
                            {
                                element.Click();
                                Thread.Sleep(2000);
                            }
                        }
                        catch (Exception)
                        {
                        }
                        // ended here
                        driver.FindElement(By.XPath("//button[@class='ckWGn']")).Click();
                        break;
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        // page down code
                        PageDown(driver);
                        collection = driver.FindElements(By.XPath("//div[@class='v1Nh3 kIKUG  _bz0w']"));
                        if (count == collection.Count)
                        {
                            return;
                        }
                        count = collection.Count;
                        break;
                    }
                    catch (Exception)
                    {
                    }
                } while (false);
            }
            
        }

        public void InstagramComment(ManualResetEvent mre, IWebDriver driver, string comment)
        {
            var collection = driver.FindElements(By.XPath("//div[@class='v1Nh3 kIKUG  _bz0w']"));
            int count = collection.Count;
            if (count == 0) return;
            for (int i = 1; i < 10000; i++)
            {
                do
                {
                    try
                    {

                        driver.FindElement(By.XPath("(//div[@class='v1Nh3 kIKUG  _bz0w'])[" + i + "]")).Click();
                        Thread.Sleep(5000);
                        // comment code started here
                        try
                        {
                            mre.WaitOne();
                            driver.FindElement(By.XPath("//textarea[@class='Ypffh']")).Click();
                            Thread.Sleep(500);
                            //driver.FindElement(By.XPath("//textarea[@class='Ypffh']")).SendKeys(comment + Environment.NewLine);
                            driver.FindElement(By.XPath("//textarea[@class='Ypffh']")).SendKeys("How are you?" + Environment.NewLine);
                            Thread.Sleep(2000);
                        }
                        catch (Exception)
                        {
                        }
                        // ended here
                        driver.FindElement(By.XPath("//button[@class='ckWGn']")).Click();
                        break;
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        // page down code
                        PageDown(driver);
                        collection = driver.FindElements(By.XPath("//div[@class='v1Nh3 kIKUG  _bz0w']"));
                        if (count == collection.Count)
                        {
                            return;
                        }
                        count = collection.Count;
                        break;
                    }
                    catch (Exception)
                    {
                    }
                } while (false);
            }

            
        }

        //public void ConvertStringToInt(string s_num, int num)
        //{
         //   string temp = s_num.Replace(",", "");
        //    string temp_ = temp.Replace("k", "000");
       //     num = Int32.Parse(temp_);
       // }
    }
}
