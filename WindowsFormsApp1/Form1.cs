using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        CREATE_CTLclass btn = new CREATE_CTLclass();

        Panel panel1 = new Panel(); // 도서정보
        Panel panel2 = new Panel(); // 회원정보
        Panel panel3 = new Panel(); // 도서관리
        Panel panel4 = new Panel(); // 연체관리
        Panel panel1u = new Panel(); // 도서정보
        Panel panel2u = new Panel(); // 대여목록
        Panel panel3u = new Panel(); // 나의정보
        Panel panel4u = new Panel(); // 도서위치MAP

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Button_Load();
            Panel1_Load();
        }

        private void Button1_Click(object o, EventArgs e)   // 최적화
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            Panel1_Load();
        }

        private void Panel1_Load() //유저 도서정보
        {
            
            panel1u.Location = new Point(0, 90);
            panel1u.Size = new Size(800, 400);
            panel1u.BackColor = Color.Blue;

            Controls.Add(panel1u);
        }

        //private void Button_Load()
        //{
        //    ArrayList arrayList = new ArrayList();

        //    arrayList.Add(new BtnSet(this, 110, 90, 1, 0, Button1_Click));

        //    for (int i = 0; i < arrayList.Count; i++)
        //    {
                
        //    }
        //}
    }
}
