using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace AnnualLottery
{
    class CItem
    {
        private string m_szUserName;
        private string m_szUserEName;
        private string m_szCellPhone;
        private string m_szUserDepart;
        public string CName
        {
            get
            {
                return m_szUserName;
            }
        }
        public string EName
        {
            get
            {
                return m_szUserEName;
            }
        }
        public string CDpart
        {
            get
            {
                return m_szUserDepart;
            }
        }
        public CItem()
        {
            Initailize();
        }
        public void Initailize()
        {
            m_szUserName = "";
            m_szUserEName = "";
            m_szCellPhone = "";
            m_szUserDepart = "";
        }
        public void SetInfo(string name, string ename, string department, string cellPhone)
        {
            Initailize();
            m_szUserName = name;
            m_szUserEName = ename;
            m_szCellPhone = cellPhone;
            m_szUserDepart = department;
        }
        public string GetString()
        {
            if (m_szUserName != "")
            {
                return m_szUserName + "-" + m_szUserEName + "-" + m_szUserDepart + "-" + m_szCellPhone + "-";
            }
            return null;
        }
        public string UserID
        {
            get
            {
                return m_szUserName + m_szUserEName + m_szUserDepart + m_szCellPhone;
            }
        }
    };
    class CUser
    {
        /// <Date Member>
        private string m_UserName;
        private string m_UserEName;
        private string m_UserDepart;
        private string m_UserCellPhone;
        private Int16 m_nAwardLevel;
        /// </Date Member>
        //////////////////////////////////////////////////////////////////////////
        public CUser()
        {
            m_UserName = "";
            m_UserEName = "";
            m_UserCellPhone = "";
            m_nAwardLevel = 0;
        }
        public Int16 nAwardLevel
        {
            set
            {
                m_nAwardLevel = value;
            }
            get
            {
                return m_nAwardLevel;
            }
        }
        public string UserEName
        {
            set
            {
                m_UserEName = value;
            }
            get
            {
                return m_UserEName;
            }
        }
        public string UserCellPhone
        {
            set
            {
                m_UserCellPhone = value;
            }
            get
            {
                return m_UserCellPhone;
            }
        }
        public string UserName
        {
            set
            {
                m_UserName = value;
            }
            get
            {
                return m_UserName;
            }
        }
        public string UserDepart
        {
            set
            {
                m_UserDepart = value;
            }
            get
            {
                return m_UserDepart;
            }
        }
        public string UserID
        {
            get
            {
                return m_UserName + m_UserEName + m_UserDepart + m_UserCellPhone;
            }
        }
        public string GetString()
        {
            if (m_UserName != "")
            {
                return m_UserName + "-" + m_UserEName + "-" + m_UserDepart + "-" + m_UserCellPhone;// +"-" + m_nAwardLevel;
            }
            return null;
        }

    };
    ////////////////////////////////////////////////////////////////


    public enum ShowLineNumber
    {
        OneLine = 1,
        twoLine = 2 ,
        threeLine =3   
    }


    class CItemMamager
    {
        public CItemMamager()
        {
            m_isRunningOn = false;
            nCurrentSheepUsedCount = 0;
            nCurrentDealLevel = 5;
            for (int i = 0; i < 50; ++i)
            {
                CreateAItem();
            }

            m_Chinese = new List<string>();
            m_Chinese.Add("总经理特别奖");
            m_Chinese.Add("一等奖");
            m_Chinese.Add("二等奖");
            m_Chinese.Add("三等奖");
            m_Chinese.Add("四等奖");
            m_Chinese.Add("五等奖");
            m_Chinese.Add("六等奖");
            m_Chinese.Add("七等奖");
            m_container = null;
            m_form = null;
        }
        public List<CItem> m_cItmes = new List<CItem>();
        public List<CUser> m_AllUsers = new List<CUser>();
        public List<CUser> m_dirtyUsers = new List<CUser>();
        public List<CUser> m_AllDealedUsers = new List<CUser>();
        private Panel m_container;
        private MainForm m_form;
        public ShowLineNumber lineNumer;
        private volatile bool m_isRunningOn;
        private Thread m_thread;
        private int nTotalLevel = 0;
        private int[] nAwardLevelLeftCount = null;
        private int[] nAwardLevelTotalCount = null;
        private int[] nAwardLevelRowCount = null;
        private int[] nAwardLevelclickCount = null;
        private int[] nCurrentSheepUserIndex = new int[50];
        private int nCurrentSheepUsedCount;
        private bool isShowBothLine = false;
        public string dateSt = "";
        private List<string> m_Chinese = null;
        Random _random = new Random();
        public string GetHead()
        {
            int nCount = 0;
            int nReady = 0;
            if (nCurrentDealLevel >= 0 && nCurrentDealLevel <= nTotalLevel)
            {
                nCount = nAwardLevelTotalCount[nCurrentDealLevel];
                nReady = nAwardLevelLeftCount[nCurrentDealLevel];
            }

            //return string.Format("中心员工人数:{0}，目前没参加会议人数:{1}", nCount, nReady);
            return m_Chinese[nCurrentDealLevel] + "名额为" + nCount + "个,目前中该奖人数:" + (nCount - nReady) + "人";
        }

        public string GetPictureName()
        {
            nAwardLevelclickCount[nCurrentDealLevel]++;
            if (!Directory.Exists(ResultPath))
            {
                Directory.CreateDirectory(ResultPath);
            }

            return "Result\\" + dateSt + "\\" + m_Chinese[nCurrentDealLevel] + "_" + nAwardLevelclickCount[nCurrentDealLevel].ToString() + "_" + DateString + ".Png";
        }
        public string GetawardName( bool isInitialize)
        {
            string interfaceInfo = isInitialize ? "等待抽取" : "正在抽取";
            return interfaceInfo + m_Chinese[nCurrentDealLevel];
        }

        public string ResultPath
        {
            get
            {
                return System.Environment.CurrentDirectory + "\\Result\\" + dateSt;
            }
        }


        public int DisplayCount
        {
            get
            {
                return nCurrentSheepUsedCount;
            }
        }

        public bool IsShowBothLine
        {
            get
            {
                return isShowBothLine;
            }
        }

        public bool IsRunningOn
        {
            get 
            {
               return m_isRunningOn;
            }
        }
        public int LevelCount
        {
            get { return nTotalLevel; }
        }

        public Panel panel
        {
            set
            {
                m_container = value;
            }
        }
        public MainForm form
        {
            set
            {
                m_form = value;
            }
        }
        private int nCurrentDealLevel;
        public void SetCurrentDealLevel(int nValue)
        {
            nCurrentDealLevel = nValue;
            nCurrentSheepUsedCount = nAwardLevelRowCount[nCurrentDealLevel];
            if (nCurrentSheepUsedCount > 30)
            {
                lineNumer = ShowLineNumber.threeLine;
            }
            else if (nCurrentSheepUsedCount <= 30 && nCurrentSheepUsedCount > 10)
            {
                lineNumer = ShowLineNumber.twoLine;
            }
            else
            {
                lineNumer = ShowLineNumber.OneLine;
            }
            //switch (nCurrentDealLevel)
            //{
            //    case 0:
            //        nCurrentSheepUsedCount = nAwardLevelRowCount[];
            //        break;
            //    case 1:
            //        nCurrentSheepUsedCount = 2;
            //        break;
            //    case 2:
            //        nCurrentSheepUsedCount = 3;
            //        break;
            //    case 3:
            //        nCurrentSheepUsedCount = 4;
            //        break;
            //    case 4:
            //        nCurrentSheepUsedCount = 5;
            //        break;
            //    case 5:
            //        nCurrentSheepUsedCount = 2;
            //        break;
            //    case 6:
            //        nCurrentSheepUsedCount = 2;
            //        break;
            //    case 7:
            //        nCurrentSheepUsedCount = 2;
            //        break;
            //    default:
            //        nCurrentSheepUsedCount = 5;
            //        break;
            //}
        }
        public CItem GetItmeByIndex(int index)
        {
            if (index < m_cItmes.Count && index >= 0)
            {
                return m_cItmes[index];
            }
            return null;
        }
        public void ClearItem()
        {
            for (int i = 0; i < 50; ++i)
            {
                CItem item = GetItmeByIndex(i);
                item.SetInfo("", "", "", "");
            }
        }
        //public CItem CreateAItem(Control lhs,Control mlhs,Control mrhs, Control rhs)
        private CItem CreateAItem()
        {
            CItem item = new CItem();
            ///item.SetControls(lhs,mlhs,mrhs,rhs);
            m_cItmes.Add(item);
            return item;
        }
        public CUser CreateAUser(string strline)
        {
            CUser user = new CUser();
            int index = strline.IndexOf('-');
            user.UserName = strline.Substring(0, index);
            strline = strline.Remove(0, index + 1);

            index = strline.IndexOf('-');
            user.UserEName = strline.Substring(0, index);
            strline = strline.Remove(0, index + 1);

            index = strline.IndexOf('-');
            user.UserDepart = strline.Substring(0, index);
            strline = strline.Remove(0, index + 1);

            return user;
        }
        public CUser GetUserByIDInUndealList(string id)
        {
            int nSize = m_AllUsers.Count;
            for (int i = 0; i < nSize; ++i)
            {
                if (m_AllUsers[i].UserID == id)
                {
                    return m_AllUsers[i];
                }
            }
            return null;
        }
        public bool RemoveUserFromUndealList(string id)
        {
            int nSize = m_AllUsers.Count;
            for (int i = 0; i < nSize; ++i)
            {
                if (m_AllUsers[i].UserID == id)
                {
                    m_AllUsers.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public bool RemoveUserFromUndealList(CUser user)
        {
            return m_AllUsers.Remove(user);
        }
        public void AddUserInDealedList(CUser user)
        {
            m_AllDealedUsers.Add(user);
        }

        public bool LoadUserInformation(bool aoye)
        {
            bool boolDataString = true;
            dateSt = DateString;
            m_AllUsers = new List<CUser>();
            FileStream fstr;
            try
            {
                if (aoye == false)
                {
                    fstr = new FileStream("NameList.txt", FileMode.Open);
                }
                else
                {
                    fstr = new FileStream("NameList_AoYe.txt", FileMode.Open);
                }
            }
            catch (SystemException e)
            {
                return false;
            }

            if (fstr == null)
            {
                return false;
            }
            StreamReader strReader = new StreamReader(fstr, Encoding.GetEncoding("UTF-8"));

            // read the levelcount first
            string firstline = strReader.ReadLine();
            if (firstline != null)
            {
                string[] temp = firstline.Split('=');
                if (temp[0] == "LevelCount")
                {
                    nTotalLevel = Int32.Parse(temp[1]);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            // init the statistic array according to total level
            nAwardLevelTotalCount = new int[nTotalLevel];
            nAwardLevelLeftCount = new int[nTotalLevel];
            nAwardLevelRowCount = new int[nTotalLevel];
            nAwardLevelclickCount = new int[nTotalLevel];

            // read record line by line
            for (int i = 0; i < nTotalLevel; ++i)
            {
                nAwardLevelclickCount[i] = 0;

                string szhead = strReader.ReadLine();
                if (szhead == null)
                {
                    return false;
                }
                int index = szhead.IndexOf('=');
                string[] values = szhead.Substring(index + 1).Split(':');
                nAwardLevelTotalCount[i] = Int32.Parse(values[0]);
                nAwardLevelLeftCount[i] = Int32.Parse(values[1]);
                nAwardLevelRowCount[i] = Int32.Parse(values[2]);

                if (nAwardLevelTotalCount[i] != nAwardLevelLeftCount[i] && boolDataString)
                {
                    boolDataString = false;
                }

                if (nAwardLevelLeftCount[i] <= 0)
                {
                    if (m_form != null)
                    {
                        m_form.DisableTheRadioButton(i);
                    }

                }
            }
            string strline = strReader.ReadLine();
            while (!string.IsNullOrEmpty(strline))
            {
                CUser user = CreateAUser(strline);
                if (UserIsFake(user))
                {
                    // if the user is fake, just skip him/her
                    continue;
                }

                CUser temp = FindUser(user);
                if (temp != null)
                {
                    //MessageBox.Show(string.Format("User {0} already exist, remove he/she from the list", user.UserName));

                    try
                    {
                        m_AllUsers.Remove(temp);
                    }
                    catch { }

                    // if the user does not added into the fake list, add him/her
                    if (UserIsFake(temp) == false)
                    {
                        m_dirtyUsers.Add(user);
                    }
                }
                else
                {
                    m_AllUsers.Add(user);
                }

                strline = strReader.ReadLine();
            }

            if ( !boolDataString)
            {
                string resultPathString = System.Environment.CurrentDirectory + "\\Result";
                if ( Directory.Exists(resultPathString))
                {
                    List<string>resultNames = new List<string>();
                    DirectoryInfo di = new DirectoryInfo(resultPathString);
                    DirectoryInfo[] dirs = di.GetDirectories();
                    foreach(DirectoryInfo dir in dirs)
                    {
                        resultNames.Add(dir.Name);
                    }

                    if (resultNames.Count > 0)
                    {
                        resultNames.Reverse();
                        dateSt = resultNames[0];
                    }
                }          
            }
            WriteUserList<CUser>("Before.txt", m_AllUsers);
            //Random user twice.
            RandomShuffle<CUser>(m_AllUsers, _random);
            WriteUserList<CUser>("First_Shuffle.txt", m_AllUsers);
            RandomShuffle<CUser>(m_AllUsers, _random);
            WriteUserList<CUser>("Second_Shuffle.txt", m_AllUsers);
            
            fstr.Close();

            return true;
        }

        private static void WriteUserList<T>(string fileName, List<T> array)
        {           
            foreach (T item in array)
            {
                CUser user = item as CUser;
                File.AppendAllText(fileName, user.UserID.ToString() + "\r\n", Encoding.UTF8);
            }            
        }

        public static void RandomShuffle<T>(List<T> array, Random randomGenerator)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            if (randomGenerator == null)
                throw new ArgumentNullException("randomGenerator");

            int count = array.Count;
            for (int i = count - 1; i >= 1; --i)
            {
                int j = randomGenerator.Next(i + 1);

                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        private CUser FindUser(CUser user)
        {
            if (m_AllUsers != null)
            {
                // check from normal user list first
                foreach (CUser item in m_AllUsers)
                {
                    if (item.UserName == user.UserName &&
                        item.UserEName == user.UserEName &&
                        item.UserDepart == user.UserDepart)
                    {
                        return item;
                    }
                }
            }

            return null;
        }

        private bool UserIsFake(CUser user)
        {
            // if user does not exist in normal user list
            // we shall check if it is in fault user list
            // this is for users that had already been added more than once before
            foreach (CUser item in m_dirtyUsers)
            {
                if (item.UserName == user.UserName)
                {
                    return true;
                }
            }

            return false;
        }

        public string DateString 
        {
            get { return DateTime.Now.ToString("yyyyMMddhhmmss"); }        
        }

        public void SaveResult()
        {
            StreamWriter strWriter;
            const string ResultFile = "Result.txt";
            string resultFilePath = ResultPath + "\\" + ResultFile;

            if (!Directory.Exists(ResultPath))
            {
                Directory.CreateDirectory(ResultPath);
            }
               
            if (File.Exists(resultFilePath)) //如果文件存在,则创建File.AppendText对象
            {
                strWriter = File.AppendText(resultFilePath);
            }
            else  //如果文件不存在,则创建File.CreateText对象
            {
                strWriter = File.CreateText(resultFilePath);
            }
            for (int i = 0; i < nCurrentSheepUsedCount; ++i)
            {
                CItem item = m_cItmes[i];
                if (item.UserID != "")
                {
                    if (item.GetString() != null)
                    {
                        strWriter.WriteLine(item.GetString() + (nCurrentDealLevel));
                    }
                }
            }
            strWriter.Close();
            //////////////////////////////////////////////////////////////////////////
            const string UpdateInputFile = "NameList.txt";
            FileStream fs = new FileStream(UpdateInputFile, FileMode.Create, FileAccess.Write, FileShare.None);

            //strWriter = File.CreateText(UpdateInputFile);
            strWriter = new StreamWriter(fs, Encoding.GetEncoding("UTF-8"));
            //strWriter.Encoding.GetEncoding()

            // write the level count
            strWriter.WriteLine(string.Format("LevelCount={0}", nTotalLevel));

            // write left record
            for (int i = 0; i < nTotalLevel; i++)
            {
                strWriter.WriteLine("Level" + i + "=" + nAwardLevelTotalCount[i] + ":" + nAwardLevelLeftCount[i] + ":" + nAwardLevelRowCount[i]);
            }
            for (int i = 0; i < m_AllUsers.Count; i++)
            {
                CUser user = m_AllUsers[i];
                if (user.UserID != "")
                {
                    strWriter.WriteLine(user.GetString());
                }
            }
            strWriter.Close();

            ////////////////////////////////////////////////////////////////////////
            // save dirty list
            if (m_dirtyUsers != null && m_dirtyUsers.Count > 0)
            {
                const string dirtyFile = "DirtyList.txt";
                fs = new FileStream(dirtyFile, FileMode.Create, FileAccess.Write, FileShare.None);
                strWriter = new StreamWriter(fs, Encoding.GetEncoding("UTF-8"));
                foreach (CUser user in m_dirtyUsers)
                {
                    strWriter.WriteLine(user.GetString());
                }
                strWriter.Close();
                fs.Close();
            }
        }
        public bool GetRandomUser()
        {
            int nSize = m_AllUsers.Count < nCurrentSheepUsedCount ? m_AllUsers.Count : nCurrentSheepUsedCount;
            if (nSize == 0)
            {
                return false;
            }

            nSize = nAwardLevelLeftCount[nCurrentDealLevel] < nSize ? nAwardLevelLeftCount[nCurrentDealLevel] : nSize;
            for (int i = 0; i < 50; ++i)
            {
                nCurrentSheepUserIndex[i] = -1;
            }
            Random ran = new Random();
            for (int i = 0; i < nSize; ++i)
            {
                int nIndex = (Int16)ran.Next(0, m_AllUsers.Count);
                while (isIndexUsed(nIndex))
                {
                    nIndex = (Int16)ran.Next(0, m_AllUsers.Count);
                }
                nCurrentSheepUserIndex[i] = nIndex;
            }

            return true;
        }
        public bool isIndexUsed(int Index)
        {
            for (int i = 0; i < 50; ++i)
            {
                if (nCurrentSheepUserIndex[i] == Index)
                {
                    return true;
                }
            }
            return false;
        }
        public bool StrartThread()
        {
            if (nAwardLevelLeftCount[nCurrentDealLevel] <= 0)
            {
                return false;
            }
            m_isRunningOn = true;
            m_thread = new Thread(new ThreadStart(Running));
            m_thread.Start();
            return true;
        }
        public void StopThread()
        {
            m_isRunningOn = false;
        }
        public void Running()
        {
            Random ran = new Random();
            while (m_isRunningOn)
            {
                if (GetRandomUser() == false)
                {
                    System.Windows.Forms.MessageBox.Show("No more users can be selected");
                    return;
                }
                for (int i = 0; i < nCurrentSheepUsedCount; ++i)
                {
                    CUser user;
                    if (nCurrentSheepUserIndex[i] == -1)
                    {
                        user = new CUser();
                    }
                    else
                    {
                        user = m_AllUsers[nCurrentSheepUserIndex[i]];
                    }

                    CItem item = GetItmeByIndex(i);
                     
                    item.SetInfo(user.UserName, user.UserEName, user.UserDepart, user.UserCellPhone);
                }
                if (m_container != null)
                    m_container.Invalidate(new Rectangle(0, 0, 1, 1));
            }
            for (int i = 0; i < nCurrentSheepUsedCount; ++i)
            {
                CItem item = GetItmeByIndex(i);
                if (item.UserID != "")
                {
                    CUser user = GetUserByIDInUndealList(item.UserID);
                    user.nAwardLevel = (Int16)nCurrentDealLevel;
                    AddUserInDealedList(user);
                    RemoveUserFromUndealList(user);
                    --nAwardLevelLeftCount[nCurrentDealLevel];
                }
                else
                {
                    break;
                }
            }

            SaveResult();
            if (nAwardLevelLeftCount[nCurrentDealLevel] <= 0)
            {
                if (m_form != null)
                {
                    m_form.DisableTheRadioButton(nCurrentDealLevel);
                }

            }
            if (m_container != null)
                m_container.Invalidate(new Rectangle(0, 0, 1, 1));
        }

    };
}
