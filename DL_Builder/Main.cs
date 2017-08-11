using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DL_Builder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CreateTable_Click(object sender, EventArgs e)
        {
            DL_Builder.CreateTable tb = new DL_Builder.CreateTable();
            tb.MdiParent = this;
            tb.Text = "创建表";
            tb.Show();
            tb.Dock = DockStyle.Fill;
            tb.MdiParent.Text = "代码生成器 - 创建表";
        }

        private void AlterTableAddColumn_Click(object sender, EventArgs e)
        {
            DL_Builder.AlterTableAddColumn tb = new DL_Builder.AlterTableAddColumn();
            tb.MdiParent = this;
            tb.Text = "新增字段";
            tb.Show();
            tb.Dock = DockStyle.Fill;
            tb.MdiParent.Text = "代码生成器 - 新增字段";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DL_Builder.CreateTable tb = new DL_Builder.CreateTable();
            tb.MdiParent = this;
            tb.Text = "代码生成器";
            tb.Show();
            tb.Dock = DockStyle.Fill;
            tb.MdiParent.Text = "代码生成器 - 创建表";
        }

    }
}
