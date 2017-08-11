using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DL_Builder
{
    public partial class AlterTableAddColumn : Form
    {
        public AlterTableAddColumn()
        {
            InitializeComponent();
        }

        private void Table_Add_Column_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;    //隐藏标题栏
        }

        private void createSQL_Click(object sender, EventArgs e)
        {
            #region 输入校验

            if (this.txtSqlSource.Text == "")
            {
                MessageBox.Show("请输入源数据", "温馨提示");
                return;
            }

            #region 字段定义规则校验

            if (this.txtRule.Text == "")
            {
                MessageBox.Show("请输入生成规则", "温馨提示");
                return;
            }

            Regex regex = new Regex("[^MTNVD*]", RegexOptions.IgnoreCase);
            if (regex.IsMatch(this.txtRule.Text))
            {
                MessageBox.Show("生成规则不合法", "温馨提示");
                return;
            }

            #endregion

            #endregion

            int fieldNameIndex = this.txtRule.Text.IndexOf("M");
            int fieldTypeIndex = this.txtRule.Text.IndexOf("T");
            int fieldNullIndex = this.txtRule.Text.IndexOf("N");
            int fieldValueIndex = this.txtRule.Text.IndexOf("V");
            int fieldDescIndex = this.txtRule.Text.IndexOf("D");

            StringBuilder fieldDefiSb = new StringBuilder();
            StringBuilder fieldDescSb = new StringBuilder();

            String[] arrRow = this.txtSqlSource.Text.Split('\n');
            string tableName = arrRow[0].Split('\t')[0].Replace("\r", "").Replace("\n", "");

            for (int i = 1; i < arrRow.Length; i++)
            {
                string[] arrCol = arrRow[i].Split('\t');

                if (arrCol.Length > 1)
                {
                    string fieldName = arrCol[fieldNameIndex].TrimEnd('\r');  //字段名称
                    string fieldType = arrCol[fieldTypeIndex].TrimEnd('\r');  //字段类型
                    string fieldNull = fieldNullIndex > -1 ? arrCol[fieldNullIndex].TrimEnd('\r') : string.Empty;  //字段NULL或NOT NULL，默认NULL
                    string fieldValue = fieldValueIndex > -1 ? arrCol[fieldValueIndex].TrimEnd('\r') : string.Empty;   //字段默认值
                    string fieldDesc = fieldDescIndex > -1 ? arrCol[fieldDescIndex].TrimEnd('\r') : fieldName;  //字段说明

                    fieldDefiSb.AppendLine("alter table [dbo].[" + tableName + "] add " + fieldName + " " + fieldType + " " + fieldNull + " " + fieldValue);

                    fieldDescSb.AppendLine("exec dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'" + fieldDesc + "' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'" + tableName + "', @level2type=N'COLUMN',@level2name=N'" + fieldName + "'");
                }
            }

            this.txtSqlResult.Text = fieldDefiSb.ToString().TrimEnd(',') + "\r\n";
            this.txtSqlResult.AppendText(fieldDescSb.ToString());
            this.txtSqlResult.AppendText("go");
        }

        private void originalData_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                this.txtSqlSource.SelectAll();
            }
        }

        private void currentData_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                this.txtSqlResult.SelectAll();
            }
        }

        private void chkIsNull_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkIsNull.Checked)
            {
                this.txtRule.Text += "N";
            }
            else
            {
                this.txtRule.Text = this.txtRule.Text.Replace("N", "");
            }
        }

        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkName.Checked)
            {
                this.txtRule.Text += "M";
            }
            else
            {
                this.txtRule.Text = this.txtRule.Text.Replace("M", "");
            }
        }

        private void chkType_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkType.Checked)
            {
                this.txtRule.Text += "T";
            }
            else
            {
                this.txtRule.Text = this.txtRule.Text.Replace("T", "");
            }
        }

        private void chkDefaultValue_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDefaultValue.Checked)
            {
                this.txtRule.Text += "V";
            }
            else
            {
                this.txtRule.Text = this.txtRule.Text.Replace("V", "");
            }
        }

        private void chkDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDesc.Checked)
            {
                this.txtRule.Text += "D";
            }
            else
            {
                this.txtRule.Text = this.txtRule.Text.Replace("D", "");
            }
        }
    }
}
