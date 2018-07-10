using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;

namespace MoLang_cs
{
    public partial class Form1 : Form
    {
        //菜单项参数
        int panelWidth = new int();
        bool panelRulesHidden = new bool();
        bool panelFilesHidden = new bool();
        bool panelViewHidden = new bool();
        bool panelSettingsHidden = new bool();
        //搜索项：中间量
        string searchtext;
        string inputtext;
        //输入项：中间量
        public Form1()
        {
            InitializeComponent();

            filePathRule = @"A:\数据结构课设\MoLang_cs\MoLang_cs\MoLang_cs\rules\默认规则.rul";
            inputLines = File.ReadAllLines(filePathRule).ToList();
            //映照到空间中显示
            showRules();

            //菜单项：规则面板取数与消失
            panelWidth = panelRules.Width;
            panelRules.Width = 0;
            panelFiles.Width = 0;
            panelView.Width = 0;
            panelSettings.Width = 0;
            panelRulesHidden = true;
            panelFilesHidden = true;
            panelViewHidden = true;
            panelSettingsHidden = true;
            //搜索框：中间量
            searchtext = txtSearch.Text;
            //输入框：中间量
            inputtext = txtOrigin.text;
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            Button Sender = (Button)sender;
            panelSelected.Top = Sender.Top;
            //选中后，Selected可见Selecting不可见
            panelSelected.Visible = true;
            panelSelecting.Visible = false;
            timerFiles.Start();
        }

        private void btnViews_Click(object sender, EventArgs e)
        {
            Button Sender = (Button)sender;
            panelSelected.Top = Sender.Top;
            //选中后，Selected可见Selecting不可见
            panelSelected.Visible = true;
            panelSelecting.Visible = false;
            timerView.Start();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {


            Button Sender = (Button)sender;
            panelSelected.Top = Sender.Top;
            //选中后，Selected可见Selecting不可见
            panelSelected.Visible = true;
            panelSelecting.Visible = false;
            timerSettings.Start();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            Button Sender = (Button)sender;
            panelSelected.Top = Sender.Top;
            //选中后，Selected可见Selecting不可见
            panelSelected.Visible = true;
            panelSelecting.Visible = false;
            //拉伸动画
            timerRules.Start();
            //映照到空间中显示规则
            //showRules();
        }

        private void timerFiles_Tick(object sender, EventArgs e)
        {
            timerRules.Enabled = false;
            timerView.Enabled = false;
            timerSettings.Enabled = false;
            panelRules.Width = 0;
            //panelFiles.Width = 0;
            panelView.Width = 0;
            panelSettings.Width = 0;
            panelRulesHidden = true;
            //panelFilesHidden = true;
            panelViewHidden = true;
            panelSettingsHidden = true;
            if (panelFilesHidden)
            {
                if (panelFiles.Width >= panelWidth)
                {
                    timerFiles.Stop();
                    panelFilesHidden = false;
                    //结束时判断是否隐藏Selected
                    if (panelFilesHidden)
                    {
                        panelSelected.Visible = false;
                    }
                    else
                    {
                        panelSelected.Visible = true;
                    }
                    this.Refresh();
                }
                else
                    panelFiles.Width = panelFiles.Width + 10;
            }
            else
            {
                if (panelFiles.Width <= 0)
                {
                    timerFiles.Stop();
                    panelFilesHidden = true;
                    //结束时判断是否隐藏Selected
                    if (panelFilesHidden)
                    {
                        panelSelected.Visible = false;
                    }
                    else
                    {
                        panelSelected.Visible = true;
                    }
                    this.Refresh();
                }
                else
                    panelFiles.Width = panelFiles.Width - 10;
            }
        }

        private void timerView_Tick(object sender, EventArgs e)
        {
            timerFiles.Enabled = false;
            timerRules.Enabled = false;
            timerSettings.Enabled = false;
            panelRules.Width = 0;
            panelFiles.Width = 0;
            //panelView.Width = 0;
            panelSettings.Width = 0;
            panelRulesHidden = true;
            panelFilesHidden = true;
            //panelViewHidden = true;
            panelSettingsHidden = true;
            if (panelViewHidden)
            {
                if (panelView.Width >= panelWidth)
                {
                    timerView.Stop();
                    panelViewHidden = false;
                    //结束时判断是否隐藏Selected
                    if (panelViewHidden)
                    {
                        panelSelected.Visible = false;
                    }
                    else
                    {
                        panelSelected.Visible = true;
                    }
                    this.Refresh();
                }
                else
                    panelView.Width = panelView.Width + 10;
            }
            else
            {
                if (panelView.Width <= 0)
                {
                    timerView.Stop();
                    panelViewHidden = true;
                    //结束时判断是否隐藏Selected
                    if (panelFilesHidden)
                    {
                        panelSelected.Visible = false;
                    }
                    else
                    {
                        panelSelected.Visible = true;
                    }
                    this.Refresh();
                }
                else
                    panelView.Width = panelView.Width - 10;
            }
        }

        private void timerSettings_Tick(object sender, EventArgs e)
        {
            timerFiles.Enabled = false;
            timerRules.Enabled = false;
            timerView.Enabled = false;
            panelRules.Width = 0;
            panelFiles.Width = 0;
            panelView.Width = 0;
            //panelSettings.Width = 0;
            panelRulesHidden = true;
            panelFilesHidden = true;
            panelViewHidden = true;
            //panelSettingsHidden = true;
            if (panelSettingsHidden)
            {
                if (panelSettings.Width >= panelWidth)
                {
                    timerSettings.Stop();
                    panelSettingsHidden = false;
                    //结束时判断是否隐藏Selected
                    if (panelSettingsHidden)
                    {
                        panelSelected.Visible = false;
                    }
                    else
                    {
                        panelSelected.Visible = true;
                    }
                    this.Refresh();
                }
                else
                    panelSettings.Width = panelSettings.Width + 10;
            }
            else
            {
                if (panelSettings.Width <= 0)
                {
                    timerSettings.Stop();
                    panelSettingsHidden = true;
                    //结束时判断是否隐藏Selected
                    if (panelSettingsHidden)
                    {
                        panelSelected.Visible = false;
                    }
                    else
                    {
                        panelSelected.Visible = true;
                    }
                    this.Refresh();
                }
                else
                    panelSettings.Width = panelSettings.Width - 10;
            }
        }

        private void timerRules_Tick(object sender, EventArgs e)
        {
            timerFiles.Enabled = false;
            timerView.Enabled = false;
            timerSettings.Enabled = false;
            //panelRules.Width = 0;
            panelFiles.Width = 0;
            panelView.Width = 0;
            panelSettings.Width = 0;
            //panelRulesHidden = true;
            panelFilesHidden = true;
            panelViewHidden = true;
            panelSettingsHidden = true;
            if (panelRulesHidden)
            {
                if (panelRules.Width >= panelWidth)
                {
                    timerRules.Stop();
                    panelRulesHidden = false;
                    //结束时判断是否隐藏Selected
                    if (panelRulesHidden)
                    {
                        panelSelected.Visible = false;
                    }
                    else
                    {
                        panelSelected.Visible = true;
                    }
                    this.Refresh();
                }
                else
                    panelRules.Width = panelRules.Width + 10;
            }
            else
            {
                if (panelRules.Width <= 0)
                {
                    timerRules.Stop();
                    panelRulesHidden = true;
                    //结束时判断是否隐藏Selected
                    if (panelRulesHidden)
                    {
                        panelSelected.Visible = false;
                    }
                    else
                    {
                        panelSelected.Visible = true;
                    }
                    this.Refresh();
                    //隐藏添加文件有关控件
                    btnCancelRules.Hide();
                    btnSaveRules.Hide();
                    btnClearRules.Hide();
                }
                else
                    panelRules.Width = panelRules.Width - 10;
            } 
          
        }

        private void btnFiles_MouseMove(object sender, MouseEventArgs e)
        {
            Button Sender = (Button)sender;
            panelSelecting.Top = Sender.Top;
            //当两个重叠的时候不显示Seleing图表
            if (panelSelecting.Top != panelSelected.Top || panelSelected.Visible == false)
            {
                panelSelecting.Visible = true;
                panelSelecting.BackColor = Color.Yellow;
            }
        }

        private void btnFiles_MouseLeave(object sender, EventArgs e)
        {
            panelSelecting.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timerOpacity.Start();
        }

        private void btnMaxSize_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            try
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    //btnMaxSize.Image = Image.FromFile(@"..\\..\\picture\\icons8_Final_State_25px_1.png");
                    btnMaxSize.Image = Image.FromFile(@"A:\数据结构课设\MoLang_cs\MoLang_cs\MoLang_cs\picture\icons8_Final_State_25px_1.png");
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    btnMaxSize.Image = (Image)(resources.GetObject("btnMaxSize.Image"));
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("所引用图标文件不存在", "出现问题");
            }
        }

        private void btnMinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timerOpacity_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.025;
            }
            else
            {
                timerOpacity.Stop();
                Application.Exit();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            TextBox Sender = (TextBox)sender;
            if (Sender.Text == searchtext)
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
           TextBox Sender = (TextBox)sender;
            if (Sender.Text == "")
            {
                Sender.Text = searchtext;
            }
        }
        
        private void txtOrigin_Enter(object sender, EventArgs e)
        {
            UserControls.ucInput Sender = (UserControls.ucInput)sender;
            if (Sender.text == inputtext || Sender.text == "(No Data)" || Sender.text == "Brackets don't match!")
            {
                Sender.text = "";
            }
        }

        private void txtOrigin_Leave(object sender, EventArgs e)
        {
            UserControls.ucInput Sender = (UserControls.ucInput)sender;
            if (Sender.text == "")
            {
                Sender.text = inputtext;
            }
        }

        /// <summary>
        /// 以下为底层代码：翻译实现，显示实现
        /// </summary>
        Stack<char> s1 = new Stack<char>();
        Stack<char> s2 = new Stack<char>();
        Stack<char> s3 = new Stack<char>();
        Stack<char> s4 = new Stack<char>();
        Queue<char> q = new Queue<char>();
        string originLang;
        string EngLang;
        string ChaLang;
        int rulesNum = 5;
        string[] ruleFormer = new string[5];
        string[] ruleLatter = new string[5];
        int length;
        bool bracketMatched;

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            Initialization();
            //打开进度条
            timerProgress.Start();
            inputRules();
            originLang = txtOrigin.text.Trim();
            bracketMatched = checkBracket();
            doExceptions();
            if (bracketMatched)
            {
                translate(originLang);
            }
            
            //showEnglish();
            //showChinese();
        }

        private bool checkBracket()
        {
            int leftBracket = 0;
            int RightBracket = 0;
            for(int i = 0; i < originLang.Length; i++)
            {
                if (originLang[i].ToString() == "(")
                {
                    leftBracket++;
                }
                else if(originLang[i].ToString() == ")")
                {
                    RightBracket++;
                }
                if(RightBracket > leftBracket )
                {
                    return false;
                }
            }
            if (RightBracket == leftBracket)
                return true;
            else
                return false;
        }

        private void inputRules()
        {
            //ruleFormer[0] = "B";
            //ruleLatter[0] = "tAdA";
            //ruleFormer[1] = "A";
            //ruleLatter[1] = "sae";
            //((TextBox)Controls.Find($"txtFormer{i + 1}", true)[0]).Text
            //((TextBox)Controls.Find($"txtlatter{i + 1}", true)[0]).Text
            for (int i = 0; i < 5; i++)
            {
                ruleFormer[i] = ((TextBox)Controls.Find($"txtFormer{i + 1}", true)[0]).Text;
                ruleLatter[i] = ((TextBox)Controls.Find($"txtlatter{i + 1}", true)[0]).Text;
            }
        }
        private void Initialization()
        {
            s1.Clear();
            s2.Clear();
            s3.Clear();
            s4.Clear();
            q.Clear();
            EngLang = "";
            ChaLang = "";
            txtEnglish.text = "(English)";
            txtChinese.text = "(汉语)";
        }
        //翻译方法
        private void translate(string originLang)
        {
            length = originLang.Length;
            char tmp;

            //从尾至首依次入栈
            for (int i = length - 1; i >= 0; i--)
            {
                s1.Push(originLang[i]);
            }
            ///翻译：s1栈不空时，依次入栈s3，直到遇到‘)’，将s2元素依次出栈并入栈s2，直到遇到'('，
            ///此时s2中存放最里层字段,对其进行去括号处理，然后存到s3中（倒序），直到s1空了，最后
            ///再存入s1
            while (s1.Count > 0)
            {
                tmp = s1.Pop();
                char thete;
                if (tmp != ')')
                {
                    s3.Push(tmp);
                }
                else
                {
                    s2.Push(tmp);
                    tmp = s3.Pop();
                    while (tmp != '(')
                    {
                        s2.Push(tmp);
                        tmp = s3.Pop();
                    }
                    thete = s2.Pop();
                    tmp = s2.Pop();
                    while (tmp != ')')
                    {
                        s4.Push(tmp);
                        tmp = s2.Pop();
                    }
                    //最内层括号的结果入栈s3
                    s3.Push(thete);
                    while (s4.Count > 0)
                    {
                        tmp = s4.Pop();
                        s3.Push(tmp);
                        s3.Push(thete);
                    }
                }
            }
            while (s3.Count > 0)
            {
                tmp = s3.Pop();
                s1.Push(tmp);
            }
            while (s1.Count > 0)
            {
                tmp = s1.Pop();
                EngLang += tmp.ToString();
            }
            ///以上为第二层规则
            ///下面是第一层规则
            for (int i = 0; i < rulesNum; i++)
            {
                string a = ruleFormer[i];
                string b = ruleLatter[i];
                string ans = "";
                for (int j = 0; j < EngLang.Length; j++)
                {
                    if (EngLang[j].ToString() == a)
                    {
                        ans += b;
                    }
                    else
                    {
                        ans += EngLang[j].ToString();
                    }
                }
                EngLang = ans;
            }
            //txtEnglish.text = EngLang;
        }

        //显示英文方法
        private void showEnglish()
        {
            txtEnglish.text = EngLang;
        }

        //显示中文方法
        private void showChinese()
        {
            for (int j = 0; j < EngLang.Length; j++)
            {
                switch (EngLang[j].ToString())
                {
                    case "t":
                        ChaLang += "天"; break;
                    case "d":
                        ChaLang += "地"; break;
                    case "s":
                        ChaLang += "上"; break;
                    case "a":
                        ChaLang += "一只"; break;
                    case "e":
                        ChaLang += "鹅"; break;
                    case "z":
                        ChaLang += "追"; break;
                    case "g":
                        ChaLang += "赶"; break;
                    case "x":
                        ChaLang += "下"; break;
                    case "n":
                        ChaLang += "蛋"; break;
                    case "h":
                        ChaLang += "恨"; break;

                }
            }
            txtChinese.text = ChaLang;
        }

        //各种异常处理
        private void doExceptions()
        {
            if(originLang == "" || originLang == null)
            {
                
            }
            else if(originLang == "(Input)" || originLang == "(No Data)" || originLang == "Brackets don't match!")
            {
                originLang = "";
                timerProgress.Start();
            }
            if (!bracketMatched)
            {
                timerProgress.Start();
            }
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            progressBarTrans.Show();
            progressBarTrans.Increment(2);
            if(originLang == "")
            {
                if (progressBarTrans.Value == 30)
                {
                    timerProgress.Stop();
                    //MessageBox.Show("未输入数据", "魔王语言解释系统",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOrigin.text = "(No Data)";
                    progressBarTrans.Hide();
                    progressBarTrans.Value = 0;
                }
            }
            if (bracketMatched)
            {
                if (progressBarTrans.Value == 100)
                {
                    timerProgress.Stop();
                    showEnglish();
                    showChinese();
                    progressBarTrans.Hide();
                    progressBarTrans.Value = 0;
                } 
            }
            else if(!bracketMatched)
            {
                if (progressBarTrans.Value == 30)
                {
                    timerProgress.Stop();
                    //异常处理：括号不匹配
                    //MessageBox.Show("输入错误：括号不匹配！", "魔王语言解释系统", 
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOrigin.text = "Brackets don't match!";
                    progressBarTrans.Hide();
                    progressBarTrans.Value = 0;
                }
            }
        }

        /// <summary>
        /// 以下为各种配置（设置）代码
        /// </summary>

        ///翻译规则部分配置
        List<RuleClass> Rules = new List<RuleClass>();
        List<string> inputLines = new List<string>();
        List<string> outputLines = new List<string>();
        string filePathRule;

        private void btnSelectRule_Click(object sender, EventArgs e)
        {
            if(openFileDialogRule.ShowDialog() == DialogResult.OK)
            {
                filePathRule = openFileDialogRule.FileName;
                inputLines = File.ReadAllLines(filePathRule).ToList();
                //映照到空间中显示
                showRules();
            }
        }

        private void showRules()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < inputLines.Count)
                {
                    string line = inputLines[i];
                    string[] entries = line.Split(',');
                    ((TextBox)Controls.Find($"txtFormer{i + 1}", true)[0]).Text = entries[0];
                    ((TextBox)Controls.Find($"txtlatter{i + 1}", true)[0]).Text = entries[1]; 
                }
                else
                {
                    ((TextBox)Controls.Find($"txtFormer{i + 1}", true)[0]).Text = "";
                    ((TextBox)Controls.Find($"txtlatter{i + 1}", true)[0]).Text = "";
                }
            }
            txtRuleNow.Text = Path.GetFileNameWithoutExtension(filePathRule);
        }

        private void btnSaveRules_Click(object sender, EventArgs e)
        {
            if(saveFileDialogRule.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialogRule.FileName;
                //从控件中读入数据
                getRelus();
                File.WriteAllLines(filename, outputLines);
            }
        }

        private void getRelus()
        {
            for (int i = 0; i < rulesNum && ((TextBox)Controls.Find($"txtFormer{i + 1}", true)[0]).Text != ""; i++)
            {
                //string line = inputLines[i];
                //string[] entries = line.Split(',');
                //((TextBox)Controls.Find($"txtFormer{i + 1}", true)[0]).Text = entries[0];
                //((TextBox)Controls.Find($"txtlatter{i + 1}", true)[0]).Text = entries[1];
                string lineFormer = ((TextBox)Controls.Find($"txtFormer{i + 1}", true)[0]).Text;
                string lineLatter = ((TextBox)Controls.Find($"txtlatter{i + 1}", true)[0]).Text;
                string output = $"{lineFormer},{lineLatter}";
                outputLines.Add(output);
            }
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            if (!btnSaveRules.Visible)
            {
                btnSaveRules.Show();
                btnCancelRules.Show();
                btnClearRules.Show();
            }
        }

        private void btnCancelRules_Click(object sender, EventArgs e)
        {
            btnSaveRules.Hide();
            btnCancelRules.Hide();
            btnClearRules.Hide();
            //for (int i = 0; i < 5; i++)
            //{
            //    ((TextBox)Controls.Find($"txtFormer{i + 1}", true)[0]).Text = "";
            //    ((TextBox)Controls.Find($"txtlatter{i + 1}", true)[0]).Text = "";
            //}
            showRules();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                ((TextBox)Controls.Find($"txtFormer{i + 1}", true)[0]).Text = "";
                ((TextBox)Controls.Find($"txtlatter{i + 1}", true)[0]).Text = "";
            }
        }


        ///文件部分配置
        string filePathMoLang;
        private void btnSelectMoLang_Click(object sender, EventArgs e)
        {
            if(openFileDialogMoLang.ShowDialog() == DialogResult.OK)
            {
                filePathMoLang = openFileDialogMoLang.FileName;
                txtMoLangNow.Text = Path.GetFileNameWithoutExtension(filePathMoLang);
                txtMoLang.Text = File.ReadAllText(filePathMoLang);
            }
        }

        private void btnAddMoLang_Click(object sender, EventArgs e)
        {
            if (!btnSaveMoLang.Visible)
            {
                btnSaveMoLang.Show();
                btnCancelMoLang.Show();
                btnClearMoLang.Show();
            }
        }

        private void btnSaveMoLang_Click(object sender, EventArgs e)
        {
            if(saveFileDialogMoLang.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialogMoLang.FileName;
                string outputMoLang = txtMoLang.Text;
                File.WriteAllText(filename, outputMoLang);
            }
        }

        private void btnClearMoLang_Click(object sender, EventArgs e)
        {
            txtOrigin.text = txtMoLang.Text;
        }

        private void btnCancelMoLang_Click(object sender, EventArgs e)
        {
            btnSaveMoLang.Hide();
            btnCancelMoLang.Hide();
        }

        private void numericUpDownOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = Convert.ToDouble(1 - numericUpDownOpacity.Value / 100);
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            Button Sender = sender as Button;
            ColorDialog colorDialog = new ColorDialog();
            Color color = new Color();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                if (Sender.Name == "btnSelectColorMenusStatus")
                {
                    panelMenus.BackColor = color;
                    panelStaus.BackColor = color;
                    btnSelectColorMenusStatus.BackColor = color;
                }
                else if (Sender.Name == "btnSelectColorOptions")
                {
                    panelFiles.BackColor = color;
                    panelView.BackColor = color;
                    panelSettings.BackColor = color;
                    panelRules.BackColor = color;
                    btnSelectColorOptions.BackColor = color;
                }
                else if (Sender.Name == "btnSelectColorFunction")
                {
                    panelMainaSpace.BackColor = color;
                    btnSelectColorFunction.BackColor = color;
                }
                else
                {
                    ;
                }
            }
            
        }

        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.Font = btnSelectFont.Font;
            fontDialog.Color = btnSelectFont.ForeColor;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font font = fontDialog.Font;
                foreach(Control control in Controls)
                {
                    foreach(Control x in control.Controls)
                    {
                        //MessageBox.Show(x.GetType().ToString());
                        if(x.GetType() == new Label().GetType()
                            || x.GetType() == new Button().GetType())
                        {
                            x.Font = font;
                            x.ForeColor = fontDialog.Color;
                        }
                    }
                }
                btnSelectFont.Font = font;
            }
        }
    }
}
