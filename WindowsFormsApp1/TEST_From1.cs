using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class TEST_From1 : Form
    {
        int sX = 1500, sY = 700; // 폼 사이즈 지정.

        ///////// 좌표 체크시 추가 /////////
        static ToolStripStatusLabel StripLb;
        StatusStrip statusStrip;
        ///////////////////////////////////
        

        public TEST_From1()
        {
            InitializeComponent();

            Load += MAINclass_Load;
        }

        private void MAINclass_Load(object sender, EventArgs e)
        {           
            ClientSize = new Size(sX, sY);  // 폼 사이즈 지정.

            /// 좌표 체크시 추가 ///
            Point_Print(); 

            CREATE_CTLclass create_ctl = new CREATE_CTLclass();

            // (this, Name, Text, SizeX, SizeY, PointX, PointY, event_handler);
            BTNclass bt1 = new BTNclass(this, "Home", "button1", 100, 100, 10, 10, btn_Click);
            LBclass lb1 = new LBclass(this, "label1", "label_name~", 100, 100, 10, 10, label_Click);
            PANELclass pn1 = new PANELclass(this, "panel1", "panel_txt~", 200, 200, 100, 100, panel_MouseMove);
            TABCTLclass tabctl = new TABCTLclass(this, "tabctl1", "tabctl1~", 450, 160, 7, 313, 30, tabctl_MouseMove);
            TABPAGEclass tabpg1 = new TABPAGEclass(this, "tabpage1", "tapage1~", 100, 100, 0, 0, tabpage_MouseMove);
            CHKBOXclass bhkbox1 = new CHKBOXclass(this, "tabpage1", "tapage1~", 100, 100, 20, 20, chkbox_Click);
            LISTVIEWclass listview1 = new LISTVIEWclass(this, "ListView1", 500, 500, 10, 10, listview_mousedoubleclick, 3, "col1", 100, "col2", 100, "col3", 100);
            COMBOBOXclass combobox1 = new COMBOBOXclass(this, "ComboBox1", 100, 100, 721, 12, comboBox_MouseClick, 5, "test1", "test2", "test3", "test4", "test5");

            ComboBox 콤보박스 = create_ctl.comboBox(combobox1);
            Controls.Add(콤보박스);

            ListView 리스트뷰 = create_ctl.listView(listview1);
            Controls.Add(리스트뷰);


            ListViewItem item1 = new ListViewItem("item1");
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            ListViewItem item2 = new ListViewItem("item2");
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            ListViewItem item3 = new ListViewItem("item3");
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            리스트뷰.Items.Add(item1);
            리스트뷰.Items.Add(item2);
            리스트뷰.Items.Add(item3);



            //TabControl 아래탭컨트롤 = create_ctl.tab_ctl(tabctl);
            //tabctl.Form.Controls.Add(아래탭컨트롤);

            //TabPage 탭페이지1 = create_ctl.tab_page(tabpg1);
            //아래탭컨트롤.Controls.Add(탭페이지1);

            //CheckBox 체크박스1 = create_ctl.chkbox(bhkbox1);

            //탭페이지1.Controls.Add(체크박스1);

        }




        private void listview_mousedoubleclick(object sender, MouseEventArgs e)
        {

        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox_MouseClick(object sender, MouseEventArgs e)
        {

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
            MessageBox.Show("동작확인 : chkbox_Click");
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
