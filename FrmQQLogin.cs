using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;//跳转网页

namespace QQ2018
{
    public partial class FrmQQLogin : Form
    {
        public FrmQQLogin()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        //鼠标进入变黑色
        private void lblRetrieve_MouseEnter(object sender, EventArgs e)
        {
            lblRetrieve.ForeColor = Color.Black;
        }
        //鼠标离开变灰色
        private void lblRetrieve_MouseLeave(object sender, EventArgs e)
        {
            lblRetrieve.ForeColor = Color.Gray;
        }

        //鼠标进入变黑色
        private void lblRegistered_MouseEnter(object sender, EventArgs e)
        {
            lblRegistered.ForeColor = Color.Black;
        }
        //鼠标离开变灰色
        private void lblRegistered_MouseLeave(object sender, EventArgs e)
        {
            lblRegistered.ForeColor = Color.Gray;
        }

        //鼠标移动到关闭按钮时变红色提示
        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }
        //鼠标离开恢复原色
        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }

        //点击，找回密码
        private void lblRetrieve_Click(object sender, EventArgs e)
        {
            Process.Start("https://aq.qq.com/v2/uv_aq/html/reset_pwd/pc_reset_pwd_input_account.html?v=3.0&old_ver_account="+ txtNumber.Text);//跳转找回密码网页
        }
        //点击，注册账号
        private void lblRegistered_Click(object sender, EventArgs e)
        {
            Process.Start("https://ssl.zc.qq.com/v3/index-chs.html?from=client&pt_clientver=5563&pt_src=1&regkey=025DE28F3EDCF4753CA972FDAD9C725AC24DD7BDAD9D0C4800C6C1E397516FEA&ADUIN=0&ADSESSION=0&ADTAG=CLIENT.QQ.5563_NewAccount_Btn.0&ADPUBNO=26781");//跳转注册账号网页
        }
        //鼠标进入变灰色
        private void picMinus_MouseEnter(object sender, EventArgs e)
        {
            picMinus.BackColor = Color.Gray;
        }
        //鼠标离开恢复原色
        private void picMinus_MouseLeave(object sender, EventArgs e)
        {
            picMinus.BackColor = Color.Transparent;
        }
        //鼠标进入变灰色
        private void picSetup_MouseEnter(object sender, EventArgs e)
        {
            picSetup.BackColor = Color.Gray;
        }
        //鼠标离开恢复原色
        private void picSetup_MouseLeave(object sender, EventArgs e)
        {
            picSetup.BackColor = Color.Transparent;
        }
        //鼠标进入替换背景图片
        private void picInput_MouseEnter(object sender, EventArgs e)
        {
            picInput.BackgroundImage = Properties.Resources.keyboard;
        }
        //鼠标离开恢复原图片
        private void picInput_MouseLeave(object sender, EventArgs e)
        {
            picInput.BackgroundImage = Properties.Resources.keyboard1;
        }
        //点击账号输入框，变色
        private void txtNumber_Click(object sender, EventArgs e)
        {
            //OnTabIndexChanged(e);
            pnlNum.BackColor = Color.DeepSkyBlue;
            picQQNum.BackgroundImage = Properties.Resources.iconqq_blue_;

            pnlPwd.BackColor = Color.Transparent;
            picPwd.BackgroundImage = Properties.Resources._lock;

        }
        //点击账号输入框，变色
        private void txtPwd_Click(object sender, EventArgs e)
        {
            pnlPwd.BackColor = Color.DeepSkyBlue;
            picPwd.BackgroundImage = Properties.Resources.lock_blue;

            //密码框恢复原色
            pnlNum.BackColor = Color.Transparent;
            picQQNum.BackgroundImage = Properties.Resources.iconqq;
        }
        //点击密码输入框，变色
        private void FrmQQLogin_Click(object sender, EventArgs e)
        {
            pnlNum.BackColor = Color.Transparent;
            picQQNum.BackgroundImage = Properties.Resources.iconqq;

            pnlPwd.BackColor = Color.Transparent;
            picPwd.BackgroundImage = Properties.Resources._lock;
        }
        //点击主界面，恢复
        private void picQRCode_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            FrmQRCode frmQRCode = new FrmQRCode();
            frmQRCode.Size = this.Size;
            //frmQRCode.Left = this.Left;
            //frmQRCode.Top = this.Top;
            Point point = new Point(this.Location.X,this.Location.Y);
            frmQRCode.Location = point;
            frmQRCode.ShowDialog();

            this.Show();
        }

        //检测加号标志
        bool isMoveOut;
        bool isMoveBack;
        private void picMultiUserSelection_MouseEnter(object sender, EventArgs e)
        {
            //弹出加号
            tmrAddtion.Enabled = true;
            isMoveOut = true;
            isMoveBack = false;
        }

        private void picMultiUserSelection_MouseLeave(object sender, EventArgs e)
        {
            //加号回来
            isMoveOut = false;
            isMoveBack = true;
        }
        private void tmrAddtion_Tick(object sender, EventArgs e)
        {
            if (isMoveOut)
            {
                //加号最右侧距离
                if (picAddtion.Location.X > 230)
                {
                    isMoveOut = true;
                    return;
                }
                picAddtion.Location = new Point(picAddtion.Location.X + 10, picAddtion.Location.Y);//移动
            }
            else
            {
                //加号最左侧距离
                if (picAddtion.Location.X <= 190)
                {
                    isMoveBack = false;
                    return;
                }
                picAddtion.Location = new Point(picAddtion.Location.X - 10, picAddtion.Location.Y);//移动
            }
        }

        //点击登录，跳转至聊天主界面，隐藏当前窗口
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChat frmChat = new FrmChat();
            frmChat.ShowDialog();
        }
        //点击设置，跳转至设置界面，隐藏当前窗口
        private void picSetup_Click(object sender, EventArgs e)
        {
            this.Hide();

   
            FrmSet frmSet = new FrmSet();
            frmSet.Size = this.Size;

            Point point = new Point(this.Location.X, this.Location.Y);
            frmSet.Location = point;
            frmSet.ShowDialog();

            this.Show();
        }

        //页面最小化
        private void picMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }







        bool isDrag;//是否拖动窗体
        Point clickPoint;
        
        private void FrmQQLogin_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            clickPoint = new Point(e.X, e.Y);
        }

        private void FrmQQLogin_MouseMove(object sender, MouseEventArgs e)
        {
              if (isDrag == true)
              {
                  int offsetX = e.X - clickPoint.X;
                  int offsetY = e.Y - clickPoint.Y;
                  //   this.Location = new Point(this.Location.X + offsetX, this.Location.Y + offsetY);
                  this.Location = new System.Drawing.Point(this.Location.X + offsetX,this.Location.Y + offsetY);

              }
         /*   if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - clickPoint.X,this.Location.Y + e.Y - clickPoint.Y);
            }*/
        }

        private void FrmQQLogin_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }
    }
}
