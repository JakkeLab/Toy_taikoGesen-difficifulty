using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace TaikoDifficulty
{
    public partial class Form1 : Form
    {
        protected ChromeDriverService driverService = null;
        protected ChromeOptions options = null;
        protected ChromeDriver driver = null;
        public Form1()
        {
            InitializeComponent();
            try
            {
                driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;

                options = new ChromeOptions();
                options.AddArgument("disable-gpu");
            }
            catch (Exception exc)
            {
                Trace.Write("exc.Message");
            }
        }

        public void SongNameAndDifficulty()
        {
            
            var driver = new ChromeDriver(driverService,options);

            driver.Navigate().GoToUrl("https://taiko.namco-ch.net/taiko/songlist/namco.php#sgnavi");
            var songTable = driver.FindElement(By.XPath("//*[@id=\'namco\']/table"));
            var tbodyElements = songTable.FindElements(By.TagName("tbody"));
            IWebElement tbodyToFindSongs = tbodyElements[1];
            var songInfos = tbodyToFindSongs.FindElements(By.TagName("tr"));
            
            for(int i = 0; i< songInfos.Count; i++)
            {
                var songInfo = songInfos[i];
                string songName = songInfo.FindElements(By.TagName("th")).First().Text;
                List<IWebElement> songOtherInfo =  songInfo.FindElements(By.TagName("td")).ToList();
                string diffKantan = songOtherInfo[1].Text;
                string diffHutsuu = songOtherInfo[2].Text;
                string diffMuzu = songOtherInfo[3].Text;
                string diffOni = songOtherInfo[4].Text;
                string diffUra = songOtherInfo[5].Text;
                string[] songStrSet = new string[7] { (i+1).ToString() , songName, diffKantan, diffHutsuu, diffMuzu, diffOni, diffUra };
                ListViewItem lvi = new ListViewItem(songStrSet);
                lvSongDiffs.Items.Add(lvi);
                if (i == songInfos.Count - 1)
                {
                    MessageBox.Show("곡 난이도 불러오기 완료");
                }
            }
        }

        private void btGetSongs_Click(object sender, EventArgs e)
        {
            SongNameAndDifficulty();
        }
    }
}