using System;
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
            throw new NotImplementedException();

            
        }


    }
}
