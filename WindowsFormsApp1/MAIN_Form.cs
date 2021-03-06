﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MAIN_Form : Form
    {

        int sX = 1500, sY = 1000; // 폼 사이즈 지정.

        ///////// 좌표 체크시 추가 /////////
        static ToolStripStatusLabel StripLb;
        StatusStrip statusStrip;
        ///////////////////////////////////
        

        public MAIN_Form()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {           

            ClientSize = new Size(sX, sY);  // 폼 사이즈 지정.
            this.IsMdiContainer = false;     // MDI 설정.

            /// 좌표 체크시 추가 ///
            Point_Print();

            // 컨트롤 객체생성. 
            CREATE_CTLclass create_ctl = new CREATE_CTLclass();

            // 생성할 패널 정보 객체 생성.
            PANELclass pn1 = new PANELclass(this, "panel1", "panel_main~", 500, 530, 10, 10, panel_MouseMove);

            Panel panel = create_ctl.panel(pn1);  // ex) 판넬만들기 :  create_ctl.CTL명(CTL값);
            Controls.Add(panel);  // 원하는 컨트롤에 추가함.
                       

            Sample_Form Child1 = new Sample_Form();
            // Set the Parent Form of the Child window.
            Child1.TopLevel = false;
            //Child1.TopMost = true;
            Child1.MdiParent = this;
            Child1.Dock = DockStyle.Fill; //판넬크기에 맞게 사이즈 늘림.
            panel.Controls.Add(Child1);
            Child1.Show();

        }


        private void btn_Click(Object o, EventArgs e)
        {
            MessageBox.Show("동작확인 : btn_Click");
        }

        private void label_Click(Object o, EventArgs e)
        {
            MessageBox.Show("동작확인 : label_Click");
        }

        private void txtbox_Click(Object o, EventArgs e)
        {
            MessageBox.Show("동작확인 : txtbox_Click");
        }

        private void chkbox_Click(Object o, EventArgs e)
        {
            MessageBox.Show("동작확인 : chkbox_Click2");
        }

        private void radio_btn_Click(Object o, EventArgs e)
        {
            MessageBox.Show("동작확인 : radio_btn_Click");
        }

        private void picturbox_Click(Object o, EventArgs e)
        {
            MessageBox.Show("동작확인 : picturbox_Click");
        }

        private void panel_Click(Object o, EventArgs e)
        {
            MessageBox.Show("동작확인 : panel_Click");
        }
        private void panel_MouseMove(Object o, MouseEventArgs e)
        {
            StripLb.Text = "(" + e.X + ", " + e.Y + ")";
        }

        private void tabctl_Click(Object o, EventArgs e)
        {
            MessageBox.Show("동작확인 : tabctl_Click");
        }
        private void tabctl_MouseMove(Object o, MouseEventArgs e)
        {
            StripLb.Text = "(" + e.X + ", " + e.Y + ")";
        }

        private void tabpage_Click(Object o, EventArgs e)
        {
            MessageBox.Show("동작확인 : tabpage_Click");
        }
        private void tabpage_MouseMove(Object o, MouseEventArgs e)
        {
            StripLb.Text = "(" + e.X + ", " + e.Y + ")";
        }
                     

        ///////////////////////// 좌표 체크시 추가 /////////////////////////////

        private void Point_Print()
        {
            MouseMove += new MouseEventHandler(this.Current_FORM_MouseMove);
            statusStrip = new StatusStrip();
            StripLb = new ToolStripStatusLabel();
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { StripLb });
            statusStrip.Location = new Point(0, sY);
            statusStrip.Name = "statusStrip1";
            statusStrip.Size = new Size(sX, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // toolStripStatusLabel1
            StripLb.Name = "StripLb1";
            StripLb.Size = new Size(121, 17);
            StripLb.Text = "StripLb1";
            Controls.Add(statusStrip);
        }
        private void Current_FORM_MouseMove(object sender, MouseEventArgs e)
        {
            StripLb.Text = "(" + e.X + ", " + e.Y + ")";
        }
        ///////////////////////////////////////////////////////////////////////
    }
}
